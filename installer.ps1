<#
This file is part of Winbuntu by Matt Wollam.

Winbuntu is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Winbuntu is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Winbuntu.  If not, see <https://www.gnu.org/licenses/>.
#>

# You must run the script as admin
#Requires -RunAsAdministrator

# Variables used in the script           
$start_time = Get-Date            
# This variable is where Winbuntu is going to install, change this if you want to change the install location
$install_loc = "C:\Program Files (x86)\Winbuntu"
$userenv = [System.Environment]::GetEnvironmentVariable("Path", "User")

$WSL = (Get-WindowsOptionalFeature -Online | Where-Object FeatureName -eq Microsoft-Windows-Subsystem-Linux)
if ($WSL.State -eq "Disabled") {
    Write-Host "Please install Windows Subsystem for Linux"
    exit
}

# Creating the home directory for Winbuntu
if (Test-Path $install_loc) {
    Write-Host "Installation location already exists, please remove '$install_loc' or change the installation location and restart the installer."
    exit
} else { Invoke-Expression "mkdir '$install_loc'" }

# Removes bloat, Script created by Sycnex @ https://github.com/Sycnex/Windows10Debloater
$debloat_url = "https://raw.githubusercontent.com/Sycnex/Windows10Debloater/master/Windows10SysPrepDebloater.ps1"
$debloat_file = "$install_loc\debloat.ps1"
Invoke-WebRequest -Uri $debloat_url -OutFile $debloat_file -UseBasicParsing
&"$debloat_file -Sysprep, -Debloat -Privacy -StopEdgePDF"

# Downloads the ubuntu client
Write-Host "Downloading and extracting Ubuntu terminal"
$ubuntu = "$install_loc\Ubuntu.appx"
Invoke-WebRequest -Uri https://aka.ms/wsl-ubuntu-1604 -OutFile $ubuntu -UseBasicParsing
Rename-Item $install_loc\Ubuntu.appx $install_loc\Ubuntu.zip
Expand-Archive $install_loc\Ubuntu.zip $install_loc\Ubuntu

# Adds the ubuntu application to your path
Write-Host "Adding Ubuntu to path"
[System.Environment]::SetEnvironmentVariable("PATH", $userenv + $install_loc, "User")

# Copies Winbuntu files to install location, or downloads them from the source if they aren't avalible
$files = ("winbuntu.py",
          "src/registry.json")
foreach ($f in $files) {
    if ([System.IO.File]::Exists($f)) { Copy-Item $f -Destination "$install_loc\$f" }
    else { Invoke-WebRequest -Uri "https://raw.githubusercontent.com/LvInSaNevL/Winbuntu/master/$f" -OutFile "$install_loc\$f" }
}

# Adding Winbuntu as a startup program
$trigger = New-JobTrigger -AtStartup -RandomDelay 00:00:01
Register-ScheduledJob -Trigger $trigger -FilePath "$install_loc\winbuntuWindows.ps1" -Name Winbuntu

# Finally, restarts the computer so changes take effect
Write-Host "Winbuntu has been installed in $((Get-Date).Subtract($start_time).Seconds) second(s)"
Write-Host -NoNewLine "Press any key to restart your computer...";
$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
Restart-Computer   