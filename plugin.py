import asyncio
import subprocess
import sys
import json, urllib.request, os, os.path
import user_config, corrections
import datetime
from galaxy.api.consts import LicenseType, LocalGameState, Platform
from galaxy.api.plugin import Plugin, create_and_run_plugin
from galaxy.api.types import Authentication, Game, LicenseInfo, LocalGame, GameTime

class RetroarchN64Plugin(Plugin):

    def __init__(self, reader, writer, token):
        super().__init__(Platform.Nintendo64, "0.2", reader, writer, token)
        self.game_list = []
        self.playlist_path = user_config.emu_path + "playlists/Nintendo - Nintendo 64.lpl"

   
    async def authenticate(self, stored_credentials=None):
        return Authentication("RAUser", "Retroarch")
    
    
    async def get_owned_games(self):
        self.update_game_list()   
        
        return self.game_list    
    
    #Scans retroarch playlist for roms in rom_path and adds them to self.game_list
    def update_game_list(self):   
    
        if os.path.isfile(self.playlist_path):
            with open(self.playlist_path) as playlist_json:
                playlist_dict = json.load(playlist_json)
            for entry in playlist_dict["items"]:
                if os.path.abspath(user_config.rom_path) in os.path.abspath(entry["path"]) and os.path.isfile(entry["path"]):
                    if entry["label"].split(" (")[0] in corrections.correction_list:
                        correct_name = corrections.correction_list[entry["label"].split(" (")[0]]
                    else:
                        correct_name = entry["label"].split(" (")[0]
                    self.game_list.append(
                        Game(                          
                            entry["crc32"].split("|")[0],
                            correct_name,
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
        sys.exit()
                      
    #only works with mupen64_plus_next core for now, mupen64_plus and ParaLLEl to be added
    #potentially give user more customization possibilities like starting in fullscreen etc 
    async def launch_game(self, game_id): 
        
        if os.path.isfile(self.playlist_path):
            with open(self.playlist_path) as playlist_json:
                playlist_dict = json.load(playlist_json)
        for entry in playlist_dict["items"]:
            if game_id == entry["crc32"].split("|")[0]:
                subprocess.Popen(os.path.abspath(user_config.emu_path + "retroarch.exe" + " -L \"" + user_config.emu_path + "cores/mupen64plus_next_libretro.dll\" \"" + entry["path"]))
                break          
    
    #imports retroarch playtime if existent. For this to work, activate "Save runtime log (aggregate)" in RetroArch settings -> Savings
    async def get_game_time(self, game_id: str, context:any):   

        file_path = ""
        time = 0
        last_played = None

        if os.path.isfile(self.playlist_path):
            with open(self.playlist_path) as playlist_json:
                playlist_dict = json.load(playlist_json)
            for rom in playlist_dict["items"]:
                if game_id == rom["crc32"].split("|")[0]:
                    file_path = user_config.emu_path + "/playlists/logs/" + os.path.abspath(rom["path"]).split(os.path.abspath(user_config.rom_path) + "\\")[1][:-4] + ".lrtl"       
                    if os.path.isfile(file_path):
                        with open(file_path) as json_data:
                            time_data = json.load(json_data)
                        last_played = datetime.datetime.timestamp(datetime.datetime.strptime(time_data["last_played"],'%Y-%m-%d %H:%M:%S'))
                        min_data = datetime.datetime.strptime(time_data["runtime"], '%H:%M:%S')
                        time = min_data.hour*60 + min_data.minute
        return GameTime(game_id, time, last_played)
        

def main():
    create_and_run_plugin(RetroarchN64Plugin, sys.argv)
    
if __name__ == "__main__":
    main()      
    
