import asyncio
import subprocess
import sys
import json
import urllib.request, os, os.path
import games
import user_config
import datetime
from galaxy.api.consts import LicenseType, LocalGameState, Platform
from galaxy.api.plugin import Plugin, create_and_run_plugin
from galaxy.api.types import Authentication, Game, LicenseInfo, LocalGame, GameTime

class RetroarchN64Plugin(Plugin):

    def __init__(self, reader, writer, token):
        super().__init__(Platform.Nintendo64, "0.1", reader, writer, token)
        self.game_list = []

    #Just need any authentication data, so I used emu_path and Retroarch
    async def authenticate(self, stored_credentials=None):
        return Authentication(user_config.emu_path, "Retroarch")
    
    
    async def get_owned_games(self):
        self.update_game_list()        
        return self.game_list    
    
    #Scans rom_path for valid roms and adds them to self.game_list with data written in games.py    
    def update_game_list(self):   
        with os.scandir(user_config.rom_path) as it:
            for entry in it:                               
                if entry.name in games.games and (entry.name.endswith('.n64') or entry.name.endswith('.z64') or entry.name.endswith('.v64')):
                    self.game_list.append(
                        Game(                          
                            games.games[entry.name]["Game ID"],
                            games.games[entry.name]["Game Title"],
                            None,
                            LicenseInfo(LicenseType.SinglePurchase, None)
                        )
                    )
                    
    #runs update_game_list in case it is started before get_owned_games. If it runs after it, it just returns self.game_list with each game as installed
    async def get_local_games(self):
        if not self.game_list:
            self.update_game_list()
        local_game_list = []
        for game_entry in self.game_list:
            local_game_list.append(LocalGame(game_entry.game_id, 1))
        return local_game_list
          
    # Only as placeholders so the launch game feature is recognized
    async def install_game(self, game_id):
        pass

    async def uninstall_game(self, game_id):
        pass
            
    def shutdown(self):
        pass
                      
    #only works with mupen64_plus_next core for now, mupen64_plus and ParaLLEl to be added
    #potentially give user more customization possibilities like starting in fullscreen etc 
    async def launch_game(self, game_id): 
        title = ""
        for entry in self.game_list:
            if str(entry.game_id) == game_id:
                title = entry.game_title
                break   
        for key in games.games:                
            if games.games[key]["Game Title"] == title:   
                subprocess.Popen(os.path.abspath(user_config.emu_path + "retroarch.exe" + " -L \"" + user_config.emu_path + "cores/mupen64plus_next_libretro.dll\" \"" + user_config.rom_path + key + "\""))
                break            
    
    #imports retroarch playtime if existent. For this to work, activate "Save runtime log (aggregate)" in RetroArch settings -> Savings
    async def get_game_time(self, game_id: str, context:any):    
        title = ""
        file_path = ""
        time = 0
        last_played = None
        for entry in self.game_list:
            if str(entry.game_id) == game_id:
                title = entry.game_title
                break
      
        for rom in games.games:
            if games.games[rom]["Game Title"] == title:
                file_path = user_config.emu_path + "/playlists/logs/" + rom[:-4] + ".lrtl"  
                if os.path.isfile(file_path):
                    with open(file_path) as json_data:
                        time_data = json.load(json_data)
                    last_played = datetime.datetime.timestamp(datetime.datetime.strptime(time_data["last_played"],'%Y-%m-%d %H:%M:%S'))
                    min_data = datetime.datetime.strptime(time_data["runtime"], '%H:%M:%S')
                    time = min_data.hour*60 + min_data.minute
        time_object = GameTime(game_id, time, last_played)
        return time_object    
        

def main():
    create_and_run_plugin(RetroarchN64Plugin, sys.argv)
    
