# galaxy-integration-n64-RetroArch-
N64 RetroArch integration for GOG Galaxy 2.0

This integration is still work in progress, but it's core features are working and the worst bugs are removed, so try it out if you'd like to.
Thanks to AHCoder for using his PS2 integrations as base for this one. Also thanks to several people on the GOG Discord for helping me out with some problems.

## Tutorial

### Setting up [RetroArch](https://retroarch.com/?page=platforms) - You need to repeat step 3 if you want to add new Roms.
1. Open RetroArch.
2. Navigate to the left until you're at *Main Menu*, click on *Load Core* -> *Download a Core* and select *Nintendo - Nintendo 64 (Mupen64Plus-Next)*.
3. Navigate to the right until you're at *Import Content*, click on *Scan Directory*, navigate to the folder where your Roms are and click on *Scan this Directory*.
4. Back in RetroArchs main menu, navigate to *Settings*, click on *Saving*, go to the last option there *Save runtime log (aggregate)* and turn it on.

### Setting up the Integration:
1. Download the integration (use clone or download or download the *Source Code.zip* file in releases or just [click here](https://github.com/Riku55/galaxy-integration-n64-RetroArch-/archive/0.2.zip)).
2. Extract the ZIP file.
3. Put it into your Galaxy plugin folder (standard is: *C:\Users\USERNAME\AppData\Local\GOG.com\Galaxy\plugins\installed*)
4. Open the file *user_config.py* with an editor.
5. Add your emulator and roms path as described in the file.
6. (Re)start Galaxy 2.0 and connect the integration.
_______________________________________________________________________________________________________________________________________

Issues and missing methods:
- While the integration is running, change of games (removing or adding roms) will only show up when restarting Galaxy or reconnecting the integration
- Only works with Mupen64Plus_Next core for now. Support for other cores added eventually or by demand.

Working Features:
- Enter path for roms in user_config.py and scan the same folder in Retroarch to add them into Galaxy 2.0
- Enter path for emulator and launch roms directly from Galaxy 2.0
- Import play times from RetroArch by enabling "Save runtime log (aggregate)" in RetroArch settings under "Saving"
