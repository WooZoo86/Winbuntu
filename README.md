<!-- PROJECT HEADER -->
<p align="center">
  <img src="https://raw.githubusercontent.com/LvInSaNevL/Winbuntu/master/Logos/Winbuntu.png" alt="Logo" width="100" height="100">
  <h1 align="center">Winbuntu</h1>

  <p align="center">
    A tool for everyone who wants a Linux-like experience on a Windows 10 kernel!
    <br />
    <a href="https://github.com/LvInSaNevL/Winbuntu/issues/new">Report Bug</a>
    <a href="https://github.com/LvInSaNevL/Winbuntu/issues/new">Request Feature</a>
    <a href="https://trello.com/invite/b/uSrAPzG7/96ffbf87ea45fa3580707a0dc034a7a5/winbuntu">Look at the todo list</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents
- [Table of Contents](#table-of-contents)
- [About The Project](#about-the-project)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Using Winbuntu](#using-winbuntu)
  - [Flags](#flags)
  - [Command Line Examples](#command-line-examples)
- [Help and Issues](#help-and-issues)
- [Contributing](#contributing)
- [Legal Jargon](#legal-jargon)
- [Contact](#contact)



<!-- ABOUT THE PROJECT -->
## About The Project
While I prefer Linux for my daily driven OS, it does come with some strings attached. This biggest string is compatibility. In comparison, Windows *just works* with everything from gaming to the Microsoft suite of programs (see Microsoft Office and Visual Studio).
<br>
Now, granted, with projects like [Wine](https://www.winehq.org/) or [Proton](https://github.com/ValveSoftware/Proton) that gap is closing every single day, but it's still not closed. 

Winbuntu aims to completely and totally close that gap by, in short, running Ubuntu on top of a Windows installation. Other people have figured out that you can simply run a desktop environment from a WSL terminal, but Winbuntu makes that Ubuntu DE *feel* like your desktop. With program pass-though, you are able to install and run any Windows or Linux program from the same desktop. 



<!-- GETTING STARTED -->
## Getting Started
The following instructions will let you get Winbuntu up and running locally

### Prerequisites
1. Currently the only prerequisite is that you have installed Windows 10 Personal or Professional Build 17763 or newer; if you are unsure which version of windows you have, open a powershell terminal and enter `[System.Environment]::OSVersion.Version`. There is no reason why this shouldn't work on older versions or the most recent update to LTSB, but it has not been tested or verified. 
2. Windows Subsystem for Linux needs to be enabled. If you would like to do it through powershell you can enter the command `Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux` and restart your computer when prompted. 

### Installation
1. Download this repository
2. Open a Powershell terminal as admin. The script is not able to run without admin rights.
3. Navigate to the directory location
4. Run `.\installer.ps1`
   1. If you get an error saying the script `cannot be loaded because running scripts is disabled on this machine`, run the command `set-executionpolicy unrestricted` and run the script again.
   2. During installation, Winbuntu will download and install [Sycnex's Windows 10 Debloater](https://github.com/Sycnex/Windows10Debloater). This script will ask you multiple questions with pop ups, and at the end of the script, if you want to reboot your system. Hit `no`, Winbuntu will reboot your system after installation. 




<!-- USING WINBUNTU -->
## Using Winbuntu
Once Winbuntu is installed it's pretty easy to use. Winbuntu should automatically run once you boot up you computer and while you're in the Ubuntu terminal you can simply use the `winbuntu` command with a flag!

### Flags
| Flag      | Short name | Description                                                                                       |
| --------- | ---------- | ------------------------------------------------------------------------------------------------- |
| Add       | A          | Adds a piece of software already installed on the system to Winbuntu's registry                   |
| Run       | E          | Runs a piece of software through Winbuntu                                                         |
| Help      | H          | Displays this chart in the terminal                                                               |
| Install   | I          | Installs a piece of software from an installer on the system and adds is to the Winbuntu registry |
| Remove    | R          | Removes a piece of software from the Winbuntu registry without removing it from the system        |
| Registry  | S          | Prints the entire Winbuntu registry to the console                                                |
| Uninstall | U          | Removes a piece of software from the system and removes it from the Winbuntu registry             |
| Version   | V          | Prints the current Winbuntu version to the console                                                |

### Command Line Examples
1. If you had the vscode installer you could run `winbuntu install "VSCodeUserSetup-x64-1.31.1.exe"` to run the installer and add the program to Winbuntu's registry 
2. Although, if you had already installed VS Code, `winbuntu add "\Program Files\code\code.exe"` would add VS Code to Winbuntu's working registry
3. Once you have it installed you can use the command `winbuntu run "vscode"` to launch the windows version of VS Code.


<!-- HELP AND ISSUES -->
## Help and Issues
If you have any issues or find any bugs while installing or using Winbuntu, we'd love to help you just make sure you ask it in the right place!
1. If you think the issue is operator related, the recommened place to ask is in the [Discord server](https://discord.gg/7uzCM92).
2. If you think the issue is programming related, or you just have a really strange issue you can join the [Discord server](https://discord.gg/7uzCM92) and talk about it there, or if you are someone who likes to tinker, follow the contributing guidelines below!
3. You can [also check out the Trello board](https://trello.com/invite/b/uSrAPzG7/96ffbf87ea45fa3580707a0dc034a7a5/winbuntu) if you would like to see the future of Winbuntu.




<!-- CONTRIBUTING -->
## Contributing
First off, thank you for taking the time to make Winbuntu better!! Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.
<br>
You may also be interested in the [documentation](docs), which goes into great detail on every line of code that makes Winbuntu run, or the [Trello board](https://trello.com/invite/b/uSrAPzG7/96ffbf87ea45fa3580707a0dc034a7a5/winbuntu) to look at the future of Winbuntu!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some amazing feature`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
### Legal Jargon
Winbuntu is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Winbuntu is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

For more information about Winbuntu's license, please see the [license packaged with the program](LICENSE)




<!-- CONTACT -->
## Contact
Community Link: [https://discord.gg/7uzCM92](https://discord.gg/7uzCM92)

Project Link:   [https://github.com/LvInSaNevL/Winbuntu](https://github.com/LvInSaNevL/Winbuntu)


