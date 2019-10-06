# galaxy-integration-n64-RetroArch-
N64 RetroArch integration for GOG Galaxy 2.0

This integration is still work in progress, but it's core features are working and the worst bugs are removed, so try it out if you'd like to.

Issues and missing methods:
- While the integration is running, change of games (removing or adding roms) will only show up when restarting Galaxy or reconnecting the integration
- Only works with Mupen64Plus_Next core for now. Mupen64Plus and ParaLLel to be added

Working Features:
- Enter path for roms in user_config.py and scan the same folder in Retroarch to add them into Galaxy 2.0
- Enter path for emulator and launch roms directly from Galaxy 2.0
- Import play times from RetroArch by enabling "Save runtime log (aggregate)" in RetroArch settings under "Saving"

Setting up the integration - Tutorial:
1) Download the integration by clicking on "Clone or Download" and then "Download ZIP"
2) Extract the ZIP file
3) Put the extracted folder into Galaxys plugin folder (on Windows: C:\Users\YOURUSERNAME\AppData\Local\GOG.com\Galaxy\plugins\installed)
4) Open user_config.py with an editor.
5) Enter the path for your Retroarch and roms there.
6) Start Retroarch.
7) Go to "Import content" and click on "Scan Directory".
8) Scan the directory where you roms are stored in (the same you entered in user_config.py).
9) Install Mupen64Plus_Next core (Main Menu -> Load Core -> Download a Core -> Nintendo - Nintendo 64 (Mupen64Plus-Next)).
10) Go to Settings -> Saving, and enable "Save runtime log (aggregate)".
11) Connect the integration.
