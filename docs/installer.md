# Installer Explination
The following document will walk you through the entire process of installing Winbuntu.

## Table of Contents
- [Installer Explination](#installer-explination)
  - [Table of Contents](#table-of-contents)
  - [Installer](#installer)
    - [Preflight Check](#preflight-check)
    - [Debloating](#debloating)
    - [Installing Ubuntu Terminal](#installing-ubuntu-terminal)
    - [Installing Winbuntu](#installing-winbuntu)
    - [Final Touches](#final-touches)


## Installer
Winbuntu's installer is written completely in Powershell. Powershell was chosen because it was the best option for all of the preparation's that the installer needs to do to the system. You can install and distribute `installer.ps1` to any internet connected machine by itself and it will download the rest of the files. If you are not able to connect to the internet you would need the following files as well;

- `winbuntu.py`
- `src/registry.json`
- `src/userPrefs.json`

### Preflight Check
The first bit of the code sets up some important parameters for the rest of the script.

The first line in the program, `#Requires -RunAsAdministrator`, checks to see if the current Powershell terminal is run as administrator. Due to the nature of the installation process, you *need* to run the installer as Admin.
<br>
The next couple lines are global variables so we'll address them all at once.
```$start_time = Get-Date      
$install_loc = "C:\Program Files (x86)\Winbuntu"
$userenv = [System.Environment]::GetEnvironmentVariable("Path", "User")
```
- `$start_time` is the time at the beginning of the script. This is used at the end to let the user know the installation took X amount of seconds.
- `$install_loc` is the location that Winbuntu will install too. By default, this is set to `C:\Program Files (x86)\Winbuntu`, but this can be changed by adjusting this line. 
- `$userenv` is the environment variable for the current user, this is used to add the WSl terminal to the path.
<br>
Next, the installer will check if WSL is installed, currently the installer will not enable WSL.
<br>
Finally the installer will create a directory at the location in `$install_loc` for Winbuntu to install to. 

### Debloating
The first actual thing that Winbuntu does is run [Sycnex's Windows 10 Debloater](https://github.com/Sycnex/Windows10Debloater), which removes a bunch of bloat that comes packaged with Windows.
<br>
The installer will download the file from the Github repository to insure that the user gets the most recent version.

### Installing Ubuntu Terminal
This is the main job of the installer so we'll spend a little more time here. 
- The first thing to do is download the most recent version of the [Ubuntu Application]( https://aka.ms/wsl-ubuntu-1604) to the install location
- After the program is downloaded we need to extract and install it
  - Step number one is to turn the downloaded file into a file type we can deal with. `Rename-Item` changes the file from `Ubuntu.appx` to `Ubuntu.zip`
  - Step number two is to extract the zip file with `Expand-Archive`
- Next we need to add the terminal to the path so we can run commands with Winbuntu.
  - Using the installation location and user environment variable saved in `$userenv` we can add Ubuntu to our path with the command `SetEnvironmentVariable`

### Installing Winbuntu
Now that we have Ubuntu installed, it's time to install Winbuntu. This is pretty simple to do. 
- Option number one is to simply copy the files from one location on the computer to the install location.
- Option number two is to download the files from the Github [repository](https://github.com/LvInSaNevL/Winbuntu) to the installation location

### Final Touches
Now that the Ubuntu terminal is installed and Winbuntu is installed, we only have a couple more things to do.
<br>
The installer will add `winbuntu.py` as a startup item, so when you turn your computer on Winbuntu will be started. 

Finally, the installer will tell you how long the installation took and prompt you to restart your computer. 