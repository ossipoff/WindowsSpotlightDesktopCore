# WindowsSpotlightDesktopCore
Windows 10 application that copies images from the Windows Spotlight (https://docs.microsoft.com/en-us/windows/configuration/windows-spotlight) folder to use for wallpapers or whatever you want.

## Building
You'll need

* Visual Studio Code
* .NET Core SDK 3.1

tasks.json file has a build and a publish task

Use the publish task to build the executable

## Using
Basically this application simply copies hi-res Windows Spotlight images to another location. So there may be a lot of things you can do with.
But what I have used it for is to get some beautiful wallpapers in Windows 10. 

* When run WindowsSpotlightDesktopCore.exe will copy all images with a resolution of 1920x1080 to an Images folder next to the executable.
* Make a shortcut to WindowsSpotlightDesktopCore.exe in %appdata%\Microsoft\Windows\Start Menu\Programs\Startup, to make it run at every login
* Change your wallpaper to slideshow (https://support.microsoft.com/en-us/help/17144/windows-10-change-desktop-background) and point to the Images folder next to the WindowsSpotlightDesktopCore.exe executable and set the desired interval.
