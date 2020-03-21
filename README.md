# Retro GOG
RetroArch integrations for GOG Galaxy 2.0

## About 
The goal of this project is to integrate all retro platforms that are supported by both [GOG Galaxy 2.0](https://www.gog.com/galaxy) and [RetroArch](https://retroarch.com/) so that games can easily be launched from GOG with minimal user configuration.  GOG Galaxy will track user's play time as well as achievement status from [RetroAchievements.org](https://retroachievements.org).  These integrations are designed for and have only been tested with Windows.

This project is currently a work in progress.  Bugs may be present.

Created with the Galaxy API: https://github.com/gogcom/galaxy-integrations-python-api

Forked from Riku55's N64 Integration Plugin: https://github.com/Riku55/galaxy-integration-n64-RetroArch-

#### Working Features:
- Add and launch retro games to your GOG Galaxy 2.0 library
- Import RetroArch Playtime

#### Future Features:
- Add configuration GUI for better usability
- Add achievements to GOG via web API


## Currently Supported Platforms
- Atari 2600
- Atari Jaguar
- Nintendo Entertainment System
- Super Nintendo Entertainment System
- Nintendo 64 (Riku55)
- Nintendo GameCube
- Nintendo Wii
- Nintendo Game Boy
- Nintendo Game Boy Color
- Nintendo Game Boy Advance
- Nintendo DS
- Nintendo 3DS
- SEGA Master System
- SEGA Genesis / Mega Drive
- SEGA CD
- SEGA Saturn
- SEGA Dreamcast
- PlayStation
- PlayStation Portable

![screenshot](https://imgur.com/A1Zk5Zt.png "Screenshot")

## Tutorial

#### Setting up [RetroArch](https://retroarch.com/?page=platforms)
1. Open RetroArch.
2. Navigate to the left until you're at *Main Menu*, click on *Load Core* -> *Download a Core* and download the core of your choice for the platform you want to integrate.
3. Navigate to the right until you're at *Import Content*, click on *Scan Directory*, navigate to the folder where your Roms are and click on *Scan this Directory*.
4. Navigate to *Settings*, click on *Saving*, go to the last option there *Save runtime log (aggregate)* and turn it on.

#### Setting up the Integration (for now, will be automated in the future):
1. Download the integration (use clone or download).
2. Extract the ZIP file.
3. Copy the folders to your Galaxy plugin folder (standard is: *C:\Users\USERNAME\AppData\Local\GOG.com\Galaxy\plugins\installed*)
4. For each integration, open the file *user_config.py* with an editor.
5. Add your emulator and roms path, along with your preferred core as described in the file.
6. (Re)start Galaxy 2.0 and connect the integration.