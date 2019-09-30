# galaxy-integration-n64-RetroArch-
N64 RetroArch integration for GOG Galaxy 2.0

This integration is still work in progress, so better not to be used for now.

Issues and missing methods:
- Local Game status update not yet implemented
- tick() for updates while running not yet implemented
- Removal of games not yet implemented (they even stay when disconnecting the integration)
- Integration disconnects after each restart of Galaxy 2.0
- Games are only added via python dictionary for now
- Game Title and Game ID have to be provided by user in games.py, not automatically working (yet)
- Only works with Mupen64Plus_Next core for now. Mupen64Plus and ParaLLel to be added

Working Features:
- Enter path for roms in user_config.py and file name, game title and game id in games.py for adding games into the Galaxy 2.0 library
- Enter path for emulator and launch roms directly from Galaxy 2.0
- Import play times from RetroArch by enabling "Save runtime log (aggregate)" in RetroArch settings under "Saving"
