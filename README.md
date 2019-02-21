<!-- PROJECT HEADER -->
<p align="center">
  <img src="https://raw.githubusercontent.com/LvInSaNevL/Winbuntu/master/Logos/Winbuntu.png" alt="Logo" width="100" height="100">
  <h1 align="center">Winbuntu</h1>

  <p align="center">
    A tool for everyone who wants a Linux-like experience on a Windows 10 kernel!
    <br />
    <a href="https://github.com/LvInSaNevL/Winbuntu/issues/new">Report Bug</a>
    ·
    <a href="https://github.com/LvInSaNevL/Winbuntu/issues/new">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)



<!-- ABOUT THE PROJECT -->
## About The Project
I completely prefer Linux for my daily driven OS, but that does come with some strings attached. The biggest string (or unbreakable cable for most people) is compatibility, Windows *just works* with everything from gaming to the Microsoft suite of programs (see Microsoft Office and Visual Studio).
<br>
Now, granted, with projects like [Wine](https://www.winehq.org/) or [Proton](https://github.com/ValveSoftware/Proton) that gap is closing every single day, but it's still not closed. 

Winbuntu aims to completely and totally close that gap by, in short, running a Ubuntu on top of a Windows installation. Other people have figured out that you can simply run a desktop environment from a WSL terminal, but Winbuntu makes that Ubuntu DE *feel* like your desktop with program pass-though, you are able to install and run any Windows or Linux program from the same desktop. 




<!-- GETTING STARTED -->
## Getting Started
The following instructions will let you get Winbuntu up and running locally

### Prerequisites
1. Currently the only prerequisite is that you have installed Windows 10 Personal or Professional Build 17763 or newer; if you are unsure which version of windows you have, open a powershell terminal and enter `[System.Environment]::OSVersion.Version`. There is no reason why this shouldn't work on older versions or the most recent update to LTSB, but it has not been tested or verified. 
2. Windows Subsystem for Linux needs to be enabled. If you would like to do it through powershell you can enter the command `Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux` and restart your computer when prompted. 

### Installation
1. Download this repository 
2. Copy the folder contents to the location you want Winbuntu to install (e.g `C:\ProgramFiles\Winbuntu`)
3. Open a Powershell terminal as admin. The script is not able to run without admin rights.
4. Navigate to the directory location
5. Run `.\installer.ps1`




<!-- HELP AND ISSUES -->
## Help and Issues
If you have any issues or find any bugs while installing or using Winbuntu, we'd love to help you just make sure you ask it in the right place!
1. If you think the issue is operator related, the recommened place to ask is in the [Discord server](https://discord.gg/7uzCM92).
2. If you think the issue is programming related, or you just have a really strange issue you can join the [Discord server](https://discord.gg/7uzCM92) and talk about it there, or if you are someone who likes to tinker, follow the contributing guidelines below!




<!-- CONTRIBUTING -->
## Contributing
Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License
Distributed under the GNU General Public License V3 License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact
Community Link: [https://discord.gg/7uzCM92](https://discord.gg/7uzCM92)

Project Link:   [https://github.com/LvInSaNevL/Winbuntu](https://github.com/LvInSaNevL/Winbuntu)


