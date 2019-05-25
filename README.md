# Tarkin's Revenge Updater
**Version 2.3.0.1** - March 2019  

This program is designed to keep the client files for the Tarkin's Revenge server up to date.

## Using The Updater

- Download the updater from the [current_release](./current_release) directory in this repo.
- Make a new folder on your computer, such as C:\Tarkin and put the Tarkin's Revenge Launcher into the folder.
- Double click the updater (Tarkin's Revenge Launcher.exe ) and point it to the folder you made above. Windows 10 may give you a warning in a big window where the only button might be Don't Run. Should this occur, there is a link in the lower right of the box that will present you with a "Run Anyway" button when you click it. You'll only see this message the first time you run the program.
- The updater will begin downloading your files when you press the Update button.
- Wait until the download is complete and then press the Play button to play the game.
- Right click the updater and choose "Pin to Start Menu" or create a link to it where you happen to find convenient.

## Updating the Updater

- Automatic updates are not enabled for this program. Should an update be required to play on Tarkin's Revenge, you can download the latest release in the link above.

## Tips and Tricks

- If the game doesn't work properly, you can force the updater to repair your files by going to the Setting page and clicking the Force Update button and then the Update button.
- If you get a pop-up message indicating that a file can't be downloaded, either the file is missing from the patch server or the patch server is offline. To Troubleshoot the issue, you can go to the Settings page and try using the Update or Reset Default buttons on the patch server download link (url). This will make sure that the updater is looking in the correct place. After you've done that, press Force Update and then the Update button. If that doesn't get the downloads going and the server status shows the server is online, then check the forum or Discord for more help.

## Requirements

- Windows Vista/7/8/10 32bit or 63bit
- Microsoft .Net Framework 4.5.2+
- The Internet

## Features

- Downloads files over http, https, and anonymous ftp.
- Client-side over-rides for all important settings (Updader can manage a list of any arbitrary files without needing to recompile the exe).
- Built in, easy to use file exclude/ignore list.
- On first installation, prompts to set resolution.
- It's a very small program.

## How It Works
On the server are bunch of the files that the client needs. Every so often some of the files on server will change or more files will be added, so the client needs to be kept informed of the changes. This is where a file on the server called PatchData.csv comes into play - it's an upto date list of all the files in client would need. The updater checks this file when it starts.  

The updater downloads PatchData.csv, reads the first to see if it's a new file or an updated version of the existing file, and then also checks to see if the last file in PatchData.csv has already been downloaded. If the first file in the list has already been downloaded and it hasn't changed and and the last file has already been downloaded, then no patching is required. Should either those conditions not be met, then patcher will walk through the list of files from top to bottom and download any updated, missing, or broken files.  

Note: The above description (and *all* other documentation found here) applies to version 2.0+ of the updater and that the "UpdaterPrep" program is not used any longer.

## About Programming

- Microsoft Visual Studio 2017
- C# / Windows Forms project

On the programming side of Version 2, I (Tatwi) did my best to slam the functionality and visual appeal into updater using the horrid nightmares that are the above noted programming monstrosities. By no means am I experienced with either Visual Studio or C# or even Windows Forms for that matter, but that's what I had to deal with on short notice, so I dealt. JavaScript/C++/Lua/Python/Bash are more my thing, ya dig? :)  

Anyway, logic wise the program is setup in such a way that all of the important values can be over-ridden using the user.config file that is stored in the following location:  

C:\Users\Rob\AppData\Local\Microsoft\Tarkin's_Revenge_Launcher_<file hash>\<version number>\  

where <file hash> looks like so, p30lcfd3m4zsqhdjmcuuez2dvsp2nxf1 and version number looks like 2.3.0.0. 

On the settings page of the updater there is a button that will open up the settings file, where you can manually edit the values. Simply change the values you want, save the file, close the updater, and relaunch it. There is also an area where you are able to type in the download url and save it to your setting file (this was handy while I was working on Version 2, making it easy to toggle between my web server and ftp server).  

More information on how to use PatchData.csv can be found in the [server_files](./server_files) directory. Updater also pulls an xml formated RSS feed and a text based "about page", both of which are customizable in the client settings file. A copy of the configuration is located in [App.config](./Updater/App.config).  

## Credits

- **Version 1:**  [Steven Helm](https://github.com/Trakaa) (Trakaa) - 2017
- **Version 2:** [R. Bassett Jr.](https://github.com/Tatwi) (Tatwi) - 2019
- **Art:** [Skolten](https://tarkinswg.com/index.php?/profile/7-skolten/)

## Maintained By

- No longer maintained. Maybe you want to do it?

## Future Updates
- I won't be making any. Maybe you want to do it?
