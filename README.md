<h1 align="center">
 <img src="https://user-images.githubusercontent.com/45159366/157766718-1d0780da-cfdf-4dd9-9cf6-d2a5cce3e57d.gif">
  <br />
  Windows 11 Guide
</h1>

#### A guide on setting up your Windows 11 Desktop with all the essential Applications, Tools, and Games to make your experience with Windows 11 great!

**Note: You can easily convert this markdown file to a PDF in [VSCode](https://code.visualstudio.com/) using this handy extension [Markdown PDF](https://marketplace.visualstudio.com/items?itemName=yzane.markdown-pdf).**

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/145648803-f2a6b145-0d2f-49a2-ba91-a6a2712d9d3f.png">
  <br />
</p>

# Table of Contents

1. [Getting Started](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#getting-started)

      - [Windows 11 Desktop](https://github.com/mikeroyal/Windows-11-Guide#windows-11-desktop)
      - [Bypass Windows 11's TPM, CPU and RAM Requirements](https://github.com/mikeroyal/Windows-11-Guide#bypass-Windows-11-requirements)
      - [Creating a Local Account on Windows 11 Home and Pro](https://github.com/mikeroyal/Windows-11-Guide#Creating-a-Local-Account-on-Windows-11-Home-and-Pro)
      - [Removing the Windows 11 Watermark for Unsupported Hardware](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#removing-the-windows-11-watermark)
      - [Ways to Customize Windows 11 Look and Feel](https://github.com/mikeroyal/Windows-11-Guide#Ways-to-Customize-Windows-11-Look-and-Feel)
      - [Installing drivers for Windows the easy way](https://github.com/mikeroyal/Windows-11-Guide#installing-drivers-for-windows)
        * [General Drivers](#General-Drivers)    
      - [Microsoft Office Alternatives](https://github.com/mikeroyal/Windows-11-Guide#microsoft-office-alternatives)
      - [Secure & Privacy-focused Web Browsers](https://github.com/mikeroyal/Windows-11-Guide#secure--privacy-focused-web-browsers)
         * [Privacy & Security Focused Browser extensions](https://github.com/mikeroyal/Windows-11-Guide#privacy--security-focused-browser-extensions)
         * [Privacy-focused Search Engines](https://github.com/mikeroyal/Windows-11-Guide#privacy-focused-search-engines)
      - [Windows Security Hardening](https://github.com/mikeroyal/Windows-11-Guide#Windows-Security-Hardening)
         * [Encryption Tools](https://github.com/mikeroyal/Windows-11-Guide#Encryption-Tools)
      - [Storage Disk Health/Data Recovery](https://github.com/mikeroyal/Windows-11-Guide#Storage-Disk-HealthData-Recovery)
      - [Battery Health](https://github.com/mikeroyal/Windows-11-Guide#Battery-Health)
     
2. [Getting Software](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#getting-software)

3. [Gaming](#Gaming)
   - [Manage/Control Fans (CPU, GPU, and motherboard)](#managecontrol-fans)
   - [Gaming Peripherals](#Gaming-Peripherals)
     * [Gaming mice, keyboards, and headsets](#RGB-Devices)
     * [Game Controllers](#Game-controllers)
   - [Graphics](#Graphics)
        * [NVIDIA](#NVIDIA)
        * [AMD](#AMD)
        * [Intel ARC](#Intel-ARC)
   - [Setting up DXVK on Windows](#Setting-up-DXVK-on-Windows)
   - [Improving Game Performance & Load Times](#Improving-Game-Performance--Load-Times)
        * [DirectStorage](#DirectStorage)
        * [NVIDIA RTX IO](#NVIDIA-RTX-IO)
        * [AMD StoreMI](#AMD-StoreMI)
	 * [Intel® Rapid Storage Technology (Intel® RST)](#Intel-RST)
   - [Setting up OBS Studio](#Setting-up-OBS-Studio)
      * [Useful OBS Studio 3rd party Plugins & Themes](#useful-obs-studio-3rd-party-plugins-and-themes)
   - [Discord](#Discord)
   - [Twitch](#Twitch)
   - [Game Stores & Launchers](#Game-Stores--Launchers)
     * [Steam](#Steam)
     * [Playnite](#Playnite)
     * [Launchbox](#Launchbox)
     * [Razor Cortex](#Razor-Cortex)
     * [Epic Games Store](#Epic-games-store)
     * [Blizzard Battle.net](#Blizzard-Battlenet)
     * [Origin](#Origin)
     * [EA Play](#EA-Play)
     * [Ubisoft Connect](#Ubisoft-Connect)
     * [Rockstar Games](#Rockstar-Games)
     * [GOG Galaxy Store](#GOG-Galaxy)
     * [Itch.io Store](#Itchio-Store)
     * [Prism for Minecraft](#Prism)
   - [Game Streaming](#Game-streaming)
     * [Cloud Game Streaming](#Cloud-Game-Streaming)
     * [Local Game Streaming](#Local-Game-Streaming)
   - [Game Emulators](#Game-emulators)
     * [Emulator Frontends](#Frontends)
     * [Nintendo GameCube & Wii](#Nintendo-GameCube--Wii)
     * [Nintendo Switch](#Nintendo-Switch)
     * [Nintendo 64](#Nintendo-64)
     * [Nintendo 3DS](#Nintendo-3DS)
     * [Nintendo DS](#Nintendo-DS)
     * [Super Nintendo Entertainment System (SNES)](#Super-Nintendo-Entertainment-System-SNES)
     * [Nintendo Entertainment System (NES)](#Nintendo-Entertainment-System)
     * [Game Boy Advance](#Game-Boy-Advance)
     * [DOS](#DOS)
     * [Atari](#Atari)
     * [Sega Dreamcast](#Sega-Dreamcast)
     * [PlayStation Portable](#PlayStation-Portable)
     * [PlayStation 1](#PlayStation-1)
     * [PlayStation 2](#PlayStation-2)
     * [PlayStation 3](#PlayStation-3)
     * [Xbox](#Xbox)
     * [MAME](#MAME)
   - [Performance Benchmarks](#Performance-benchmarks)

4. [Windows Subsystem for Android (WSA)](https://github.com/mikeroyal/Windows-11-Guide#windows-subsystem-for-android-wsa)

   - [Getting started with Windows Subsystem for Android](https://github.com/mikeroyal/Windows-11-Guide#getting-started-with-windows-subsystem-for-android)
   - [Windows Subsystem for Android Settings](https://github.com/mikeroyal/Windows-11-Guide#windows-subsystem-for-android-settings)
   - [WSA Toolbox](https://github.com/mikeroyal/Windows-11-Guide#wsa-toolbox)

5. [Windows Subsystem for Linux (WSL)](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#windows-subsystem-for-linux-wsl)
  
    - [WSL Learning Resources](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#wsl-learning-resources)
    - [WSL Tools and Projects](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#wsl-tools--projects)
    - [Setting up WSL Linux Distributions](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#setting-up-wsl-linux-distributions)

6. [Windows Terminal](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#windows-terminal)

7. [Visual Studio and VSCode](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#visual-studio-and-vscode)
    - [Visual Studio Extensions for Developer Productivity](https://github.com/mikeroyal/Windows-11-Guide#Visual-Studio-Extensions-for-Developer-Productivity)
    - [VS Code Extensions for Developer Productivity](https://github.com/mikeroyal/Windows-11-Guide#VS-Code-Extensions-for-Developer-Productivity)

8. [Game Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#game-development)

9. [Setting up a macOS Workspace](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#setting-up-a-macos-workspace)

10. [Android Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#android-development)

11. [Professional Audio/Video Editing](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#professional-audio--video-editing)

12. [3D Graphics and Design](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#3d-graphics-and-design)

13. [Kubernetes](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#kubernetes)

14. [Machine Learning](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#machine-learning)

15. [Robotics](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#robotics)

16. [Open Source Security](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#open-source-security)

17. [Differential Privacy](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#differential-privacy)

18. [DevOps](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#devops)

19. [.NET Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#net-development)

20. [C# Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#c-development)

21. [F# Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#f-development)

22. [PowerShell Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#powershell-development)

23. [TypeScript Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#typescript-development)

24. [React Native Development](https://github.com/mikeroyal/Windows-11-Guide#react-native-development)

25. [ElectronJS Development](https://github.com/mikeroyal/Windows-11-Guide#electron-development)

26. [C/C++ Development](https://github.com/mikeroyal/Windows-11-Guide#cc-development)

27. [Java Development](https://github.com/mikeroyal/Windows-11-Guide#java-development)

28. [Python Development](https://github.com/mikeroyal/Windows-11-Guide#python-development)

29. [Ruby Development](https://github.com/mikeroyal/Windows-11-Guide#ruby-development)

30. [Flutter Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#flutter-development)

31. [Node.js Development](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#nodejs-development)

32. [Networking](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#networking)

33. [Databases](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#databases)

# Getting Started

[Getting started with your new Windows 11 PC](https://www.microsoft.com/en-us/windows/windows-11)

[Windows 11 Installation Assistant](https://www.microsoft.com/en-us/software-download/windows11)

[Update to Windows Subsystem for Android™ on Windows 11](https://blogs.windows.com/windows-insider/2022/03/08/update-to-windows-subsystem-for-android-on-windows-11-for-windows-insiders/)

[Getting Started with the DirectX 12 Agility SDK](https://devblogs.microsoft.com/directx/gettingstarted-dx12agility/)

[Microsoft Windows Server](https://www.microsoft.com/en-us/windows-server/) is the operating system that connects on-premises environments with [Azure](https://azure.microsoft.com), adding additional layers of security while helping you modernize your applications and infrastructure.

[Windows as a Service (WaaS)](https://docs.microsoft.com/en-us/windows/deployment/update/waas-overview) is a new development concept, introduced with the release of Windows 11. It simplifies the lives of IT professionals and maintains a consistent Windows 11 experience for all Windows customers. These improvements primarily focus on maximizing customer involvement in Windows development, simplifying the deployment and servicing of Windows client computers, and leveling out the resources needed to deploy and maintain Windows over time.

[Windows Virtual Desktop](https://azure.microsoft.com/en-us/services/virtual-desktop/) is a service that enables a secure, remote desktop experience from anywhere.

[Windows 365 Cloud PC](https://www.microsoft.com/en-us/windows-365) is a service that provides a secure way to stream your Windows experience including your personalized apps, content, and settings from the Microsoft cloud([Azure](https://azure.microsoft.com/)) to any device with your Windows 365 Cloud PC. Available August 2nd, 2021.

[Microsoft Dynamics 365](https://dynamics.microsoft.com/en-us/) is the essential business solution for busy professionals who need to engage with customers while staying productive at work and on the go. Arrive prepared for every appointment and update notes, tasks, and attachments. Along with relevant service and sales records.

[Microsoft Edge](https://www.microsoft.com/edge) is a cross-platform web browser developed by Microsoft. It is supported on Windows 11, Windows 10, Xbox, Android, iOS, macOS, and as a [preview for Linux](https://www.microsoftedgeinsider.com/en-us/download/?platform=linux).

[Microsoft Azure](https://azure.microsoft.com) is a public cloud computing platform that comes with solutions developed by Microsoft including Infrastructure as a Service (IaaS), Platform as a Service (PaaS), Windows as a Service (WaaS), and Software as a Service (SaaS) that can be used for services such as analytics, virtual computing, storage, networking, and security.

[VMware Horizon Cloud on Microsoft Azure](https://azure.microsoft.com/en-us/services/virtual-desktop/vmware-horizon-cloud/) is a desktop virtualization service available in Azure Marketplace. Simplify your delivery of on-premises and cloud virtual desktops and applications by connecting your instance of Azure to VMware.

[Citrix Virtual Apps and Desktops for Azure](https://azure.microsoft.com/en-us/services/virtual-desktop/citrix-virtual-apps-desktops-for-azure/) is a desktop and app virtualization service available through Azure Marketplace or agreements with Citrix. Use familiar tools to manage on-premises Citrix deployments alongside Windows Virtual Desktop on Azure, supporting cloud modernization while maximizing your existing investment.

[DirectStorage API](https://devblogs.microsoft.com/directx/directstorage-is-coming-to-pc/) is an API in the DirectX family originally designed for the [Velocity Architecture](https://news.xbox.com/en-us/2020/07/14/a-closer-look-at-xbox-velocity-architecture/) to Windows. The DirectX API is architected in a way that takes all this into account and maximizes performance throughout the entire pipeline from NVMe drive all the way to the GPU. It does this in several ways: by reducing per-request NVMe overhead, enabling batched many-at-a-time parallel IO requests which can be efficiently fed to the GPU, and giving games finer grain control over when they get notified of IO request completion instead of having to react to every tiny IO completion. The DirectStorage API will be available on [Windows 11](https://www.microsoft.com/en-us/windows/windows-11) PCs with NVMe SSDs, but will also be support in [Windows 10](https://www.microsoft.com/software-download/windows10) version 1909 and newer.

[WinDirStat(Windows Directory Statistics)](https://windirstat.net/) is a disk usage statistics viewer and cleanup tool for various versions of Microsoft Windows.

[eBPF for Windows](https://github.com/microsoft/ebpf-for-windows) is an eBPF implementation that runs on top of Windows. eBPF is a well-known technology for providing programmability and agility, especially for extending an OS kernel, for use cases such as DoS protection and observability.

[Sysinternals Suite](https://docs.microsoft.com/en-us/sysinternals/downloads/sysinternals-suite) is the entire set of Sysinternals Utilities rolled up into a single download. Also, checkout the [Sysinternals Utilities Index](https://docs.microsoft.com/en-us/sysinternals/downloads/).

[Secure boot](https://docs.microsoft.com/en-us/windows-hardware/design/device-experiences/oem-secure-boot) is a security standard developed by members of the PC industry to help make sure that a device boots(Unified Extensible Firmware Interface (UEFI) BIOS) using only software(such as bootloaders, OS, UEFI drivers, and utilities) that is trusted by the Original Equipment Manufacturer (OEM).

[Microsoft Defender Security Center](https://docs.microsoft.com/en-us/microsoft-365/security/defender-endpoint/microsoft-defender-security-center?view=o365-worldwide) is a user portal where you can access Microsoft Defender for Endpoint capabilities. It gives enterprise security operations teams a single pane of glass experience to help secure networks.

[BitLocker Drive Encryption](https://docs.microsoft.com/en-us/windows/security/information-protection/bitlocker/bitlocker-overview) is a data protection feature that integrates with the operating system and addresses the threats of data theft or exposure from lost, stolen, or inappropriately decommissioned computers. BitLocker provides the most protection when used with a Trusted Platform Module (TPM) version 1.2 or later.

[ARM64EC (“Emulation Compatible”)](https://docs.microsoft.com/en-us/windows/uwp/porting/arm64ec) is a new application binary interface (ABI) for Windows 11 on ARM that runs with native speed and is interoperable with x64 architecture. An app, process, or even a module can freely mix and match with ARM64EC and x64 as needed. The ARM64EC code in the app will run natively while any x64 code will run using Windows 11 on ARM’s built-in emulation. The ARM64EC ABI differs slightly from the current [ARM64 ABI](https://docs.microsoft.com/en-us/cpp/build/arm64-windows-abi-conventions?view=msvc-160) in ways that make it binary compatible with x64 code. Specifically, the ARM64EC ABI follows x64 software conventions including calling convention, stack usage, and data alignment, making ARM64EC and x64 interoperable. Apps built as ARM64EC may contain x64 code but do not have to, since ARM64EC is its own complete, first-class ABI for Windows.

## Windows 11 Desktop
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/124991551-acdc4e00-dff6-11eb-9711-eb03460f144e.png">
  <br />
</p>

**Windows 11 Desktop with new Start menu. Source: [Microsoft](https://www.microsoft.com/en-us/windows/windows-11)**

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/124991554-aea61180-dff6-11eb-8677-07876e9b313d.png">
  <br />
</p>

**By Default the Start menu and icons are centered. Source: [Microsoft](https://www.microsoft.com/en-us/windows/windows-11)**

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/124991560-b06fd500-dff6-11eb-8cf3-ab300cf6e82a.png">
  <br />
</p>

**In system settings to change the position of the Start menu back to the Left-side layout. Source: [Microsoft](https://www.microsoft.com/en-us/windows/windows-11)**

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/124991557-afd73e80-dff6-11eb-990c-7a8fd1b2776c.png">
  <br />
</p>

**Windows 11 desktop with the traditional Left-side layout. Source: [Microsoft](https://www.microsoft.com/en-us/windows/windows-11)**

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/124991563-b1a10200-dff6-11eb-95a9-0d224a4d4007.png">
  <br />
</p>

**Easily snap the layout of your Desktop Apps on Windows 11. Source: [Microsoft](https://www.microsoft.com/en-us/windows/windows-11)**

## Bypass Windows 11 Requirements
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

**Note 1: Before performing any upgrade to your system make sure to do a full backup of your system in case anything happens during the upgrade process!**

**Note 2: Some anti-cheat software for video games(like Valorant) will require TPM, Secure Boot on Windows 11.**

[Ways to install Windows 11 on Unsupported hardware | Microsoft Support](https://support.microsoft.com/en-us/windows/ways-to-install-windows-11-e0edbbfb-cfc5-4011-868b-2ce77ac7c70e)

[Fido](https://github.com/pbatard/Fido) is a PowerShell script that is primarily designed to be used in [Rufus](https://github.com/pbatard/rufus), but that can also be used in standalone fashion, and whose purpose is to automate access to the official Microsoft Windows retail ISO download links as well as provide convenient access to bootable UEFI Shell images.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158471944-242c2dba-e40a-4802-9a34-e767e14d1c18.png">
  <br />
  Fido
</p>

**OR**

[Rufus](https://rufus.ie/) is a utility that helps format and create bootable USB flash drives.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158471950-74640216-66ed-407b-a615-e643284ba0b8.png">
  <br />
  Rufus
</p>

**In Rufus 3.19:**

Add a new selection dialog for Windows 11 setup customization:

  * Secure Boot and TPM bypass have now been moved to this dialog.
  * Allows to bypass the mandatory requirement for a Microsoft account on Windows 11 22H2.
    **(Note: Network must be temporarily disabled for the local account creation to be proposed).**
  * Added an option to skip all collection questions (Sets all answers to “Don’t allow”).
  * Added an option for setting internal drives offline for Windows To Go.
  
 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/183272077-015b8bb2-af94-443a-a455-f2018fcbd52a.png">
  <br />
  Rufus 3.19 Windows 11 setup customization.
</p>

## Creating a Local Account on Windows 11 Home and Pro
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

**In Windows 11 Home and Pro editions Microsoft will require you to sign-in with Microsoft Account. Though, by following these simple steps below you can create a Local Account on the your Windows 11 device.**

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/155907610-1ec0e0c3-ebfc-4906-b88c-ef36e71e8d71.png">
  <br />
  Microsoft Account Sign-in on Windows 11
</p>

**Before we begin this process make sure to not connect your Wi-Fi or unplug your Ethernet cable if you use one.**

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/155907612-a1220895-cbf7-4a21-a5d8-334685d9d781.png">
  <br />
</p>

### Steps 1-5:

1. Press keys **Shift + F10** this will open the Windows Command prompt as System.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/155907621-03f48d86-ede0-4668-92cc-6fa5b5742f8d.png">
  <br />
</p>

2. Then type **taskmgr** and Press Enter.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/155907624-f73f18b4-9b9c-43ad-b86f-26b897cf7141.png">
  <br />
</p>

3. This opens up the **Task Manager**. Click the **more details** option in the bottom left corner.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/155907633-d531dbab-6475-437e-9f25-994fbe388535.png">
  <br />
</p>

4. Now scroll down til you see **Network Connection Flow**. Right click on the process and select **End task**.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/155907635-010e70fe-a4e5-40e5-839a-7a76da83948b.png">
  <br />
</p>

5. You will now see on the Windows screen that you can sign-up for a Local account.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/155907640-f89a6b5a-8226-4d47-a5da-f0038a4e661b.png">
  <br />
</p>

## Removing the Windows 11 Watermark
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

There’s already a way to remove the Windows 11 watermark. It’s important to know that removing the watermark does include editing some system registry files. So, do this at your own risk, and be careful.

 - 1.  Access the Registry Editor by typing **‘Regedit’** in the Windows 11 search box and hitting OK to open it.
  
 - 2.  On the left side, open up **HKEY_CURRENT_USER** and scroll down to the **Control Panel**.
  
 - 3.  Find the entry called **UnsupportedHardwareNotificationCache**.
  
 - 4. **Right-click** that entry and select **‘Modify’** from the menu.
  
 - 5. Change the **SV2 DWORD** value from 1 to **0**.
  
 - 6. Save, exit, and then restart your PC.
 
<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/168446887-eba7be6f-7f23-4f50-bbfa-4ed5ea0dbd3d.png">
<br />
</p>


## Ways to Customize Windows 11 Look and Feel
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[ThisIsWin11](https://github.com/builtbybel/ThisIsWin11) is a tool which helps you set up and customize Windows 11. Created by [Builtbybel](https://twitter.com/builtbybel).

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158269020-6157e460-0636-468a-82b4-dace91e9a739.png">
  <br />
</p>

[Chris Titus Tech Windows Utility](https://github.com/ChrisTitusTech/winutil) is the Ultimate Windows 10 & 11 script designed to be a swiss army knife of Windows tools to help setup and optimize machines. [The Ultimate Windows Utility | Chris Titus Tech YouTube.](https://www.youtube.com/watch?v=tPRv-ATUBe4)

**Paste this command into Powershell (admin):**

```iwr -useb https://christitus.com/win | iex```

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/169711131-7b8e000c-e544-470e-9164-d76938759ccf.png">
  <br />
</p>

[WingetUI](https://github.com/martinet101/WingetUI) is a GUI Store for the most common cli package managers, such as Winget and Scoop. It's developed by [Martí Climent AKA martinet101](https://github.com/martinet101).

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/169711126-0d56a8fe-229e-4d4b-a8c5-d44c1a074b59.png">
  <br />
</p>

[ViVe](https://github.com/thebookisclosed/ViVe) is a C# library you can use to make your own programs that interact with Windows 10/11's A/B feature mechanism.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158266474-688046df-c708-4273-87c7-b057378838ef.png">
  <br />
</p>

[O&O ShutUp10++](https://www.oo-software.com/en/shutup10) is a free tool that let's you have full control over which comfort functions under **Windows 10 and Windows 11** you wish to use, and you decide when the passing on of your data goes too far.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/173458921-b24022a1-b76f-41b0-83df-547a50b8a2eb.png">
  <br />
</p>

[NTLite ($40)](https://www.ntlite.com/) is a local Windows configuration tool for updating and editing Windows images and deployments made for IT professionals and enthusiasts.

**Features:**

 * Download Latest Windows Updates.
 * Integrate/Install Updates and Languages.
 * Integrate Drivers, Applications and REG files.
 * Unattended Windows Setup, including Disk Partitioning.
 * Hardware Driver Targeting.
 * Windows Settings Configuration.
 * Component Removal.
 * Image, live (e.g. C:\Windows) and offline (e.g. D:\Windows, mounted VHD etc) editing *no capturing.
 * Pending Changes Overview.
 
 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/199430788-8c733b76-510a-48fc-9dac-55e3f327d2fd.png">
  <br />
</p>

[WinPaletter](https://github.com/Abdelrhman-AK/WinPaletter) is a tool to colorize Windows 10/11 Accents without restrictions. It was created/developed by [Abdelrhman-AK](https://github.com/Abdelrhman-AK/).

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/173133138-1c90cba4-923d-42ac-a072-ae58e7acbd87.png">
  <br />
</p>

[SecureUxTheme](https://github.com/namazso/SecureUxTheme) is a secure boot compatible in-memory UxTheme patcher.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/173458933-6ffb8910-8d49-477c-9892-e3906a17645a.png">
  <br />
</p>

[Files](https://github.com/files-community/Files) is a file manager for Windows with a powerful yet intuitive design. It has features like multiple tabs, panes, columns, shell extensions in the context menu and tags.

[Sysinternals Suite](https://docs.microsoft.com/en-us/sysinternals/downloads/sysinternals-suite) is the entire set of Sysinternals Utilities rolled up into a single download. Also, checkout the [Sysinternals Utilities Index](https://docs.microsoft.com/en-us/sysinternals/downloads/).

[ExplorerPatcher](https://github.com/valinet/ExplorerPatcher) is a tool that restores the taskbar, start menu, context menus, explorer, style and order back to the Windows 7 & 10 style.

[Directory Opus](https://www.gpsoft.com.au/) is a complete replacement for Explorer, with far more power and functionality than any other file manager available today. Image marking lets you sort your photos quickly and easily.

[StartAllBack](https://startallback.com/) ($4.99) is another tool that restores the taskbar, start menu, context menus, explorer, style and order back to the Windows 7 & 10 style.

[Start11](https://www.stardock.com/products/start11/) (£5.99) is a tool designed to bring menus back from Windows 7/10 to Windows 11.

[ElevenClock](https://github.com/martinet101/ElevenClock) is a tool that provides a customizable clock on your Windows 11 multi-monitor displays. It's developed by [Martí Climent AKA martinet101](https://github.com/martinet101).

[Live Tiles Anywhere](https://www.reddit.com/r/windows/comments/q18fq7/live_tiles_anywhere_create_custom_live_tiles_for/) is a tool that brings a new way of thinking and using Windows Live Tiles, this is Live Tiles Anywhere. LTA is the first app that allows you to create not only working custom Live Tiles, but also add Live Tiles as widgets on your Desktop.

[RoundedTB](https://github.com/torchgm/RoundedTB) is a tool that adds margins, rounded corners and segments to your taskbars.

[Win11DisableOrRestoreRoundedCorners](https://github.com/valinet/Win11DisableRoundedCorners) is a tool that cold patches dwm (uDWM.dll) in order to disable window rounded corners in Windows 11.

[MSEdgeRedirect](https://github.com/rcmaehl/MSEdgeRedirect) is a tool that redirects News, Search, Widgets, Weather and more to Your Default Browser of choice in Windows 11.

[AltSnap](https://github.com/RamonUnch/AltSnap) is a maintained continuation of [Stefan Sundin's AltDrag](https://stefansundin.github.io/altdrag/). It allows you to move and resize windows by using the Alt key and clicking wherever on the window instead of relying on very precise clicking. This behavior is very common on Linux distributions and is not actually hard to implement on Windows.
   
[Twinkle Tray](https://twinkletray.com/) is a tool that lets you easily manage the brightness levels of multiple monitors. This app adds a new icon into your system tray, where you can click to have instant access to the brightness levels of all compatible monitors. 

[Microsoft PowerToys](https://docs.microsoft.com/en-us/windows/powertoys/) is a set of utilities for power users to tune and streamline their Windows 10 experience for greater productivity. To get more information on [PowerToys](https://docs.microsoft.com/windows/powertoys/), or any other tools and resources for [Windows development environments](https://docs.microsoft.com/windows/dev-environment/overview), go to [docs.microsoft.com](https://docs.microsoft.com/windows/powertoys/).

[WPF UI](https://github.com/lepoco/wpfui) is a tool that prvides a simple way to make your application written in WPF keep up with modern design trends. Library changes the base elements like Page, ToggleButton or List, and also includes additional controls like Navigation, NumberBox, Dialog or Snackbar.

[Windows 11 Drag & Drop to the Taskbar (Fix)](https://github.com/HerMajestyDrMona/Windows11DragAndDropToTaskbarFix) is a program that fixes the missing "Drag & Drop to the Taskbar" support in Windows 11. It works with the new Windows 11 taskbar and does not require nasty changes like UndockingDisabled or restoration of the classic taskbar. 

[ConfigureDefender](https://github.com/AndyFul/ConfigureDefender) is a small utility for configuring Windows 10/11 (and Windows Server) built-in Defender Anti-Virus settings. It is a part of Hard_Configurator project (including source files), but it can be used as a standalone application (portable).

[TweakUIX](https://github.com/builtbybel/TweakUIX) is a PowerToys/Tweak UI Replica created by [Builtbybel](https://twitter.com/builtbybel).

[Winaero Tweaker](https://winaero.com/winaero-tweaker/) is an all-in-one application that comes with dozens of options for fine-grained tuning of various Windows settings and features.

[QTTab Bar](https://indiff.github.io/qttabbar/) is a simple utility that will enable you to operate files and folders like tab browser folder grouping, and histories for Windows Explorer in Windows 10/11. 

[Ear Trumpet](https://eartrumpet.app/) is a powerful volume control app for Windows 10/11 providing a system tray utility that gives you volume levels for every app and the ability to set custom inputs and outputs for those apps.

[Wallpaper Engine](https://store.steampowered.com/app/431960/Wallpaper_Engine/) (£2.99) is a tool enables you to use live wallpapers on your Windows desktop. Various types of animated wallpapers are supported, including 3D and 2D animations, websites, videos and even certain applications. 

[Lively Wallpaper](https://rocksdanister.github.io/lively/) is a Windows application designed to turn GIFs, games, and videos into animated wallpapers. 

## Installing drivers for
[Back to the Top](#table-of-contents)

### General Drivers
[Back to the Top](#table-of-contents)

[Snappy Driver Installer(SDI) Origin](https://www.snappy-driver-installer.org) is a portable Windows tool to install and update device drivers. It can be used offline to install drivers where Internet isn't available. No more searching for drivers after a clean install of Windows 10/11.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158266415-3d675f1d-5fd0-4671-8713-763a6e1fe397.png">
  <br />
  Snappy Driver Installer(SDI) Origin
</p>

[Download Display Driver Uninstaller(DDU)](https://www.guru3d.com/files-details/display-driver-uninstaller-download.html) is a driver removal utility that can help you completely uninstall AMD/NVIDIA graphics card drivers and packages from your system, without leaving leftovers behind (including registry keys, folders and files, driver store). 

**Recommended usage:**

  * The tool can be used in Normal mode but for absolute stability when using DDU, Safemode is always the best.
  * Make a backup or a system restore (but it should normally be pretty safe).
  * It is best to exclude the DDU folder completely from any security software to avoid issues.
  
 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/193400130-34f1f713-e471-4e3c-a10f-2eec2465e7f1.png">
  <br />
  Download Display Driver Uninstaller(DDU)
</p>


## Microsoft Office Alternatives
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[OnlyOffice](https://www.onlyoffice.com/) is a secure offline/online office suite highly compatible with MS Office formats  for Windows, Mac and Linux.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158472597-9ca73786-4e28-497f-9c6d-0a0040e8c3da.png">
  <br />
  OnlyOffice
</p>

[FreeOffice](https://www.freeoffice.com/) is a secure office suite highly compatible with MS Office formats for Windows, Mac and Linux.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158266331-321a1004-14cb-473f-a01f-9a9a6e67623a.png">
  <br />
  FreeOffice
</p>

[LibreOffice](https://www.libreoffice.org/) is a free and open-source office productivity software suite similar to Microsoft Office.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158470268-2834d32d-72ef-4e5e-8cd6-02db51a5dcfa.png">
  <br />
  LibreOffice
</p>


## Secure & Privacy Focused Web Browsers
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[Mozilla Firefox](https://www.mozilla.org/firefox/) is a free and open-source web browser developed by the Mozilla Foundation.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158266387-04609c3f-1324-4c21-9186-5ed338835260.png">
  <br />
  Firefox
</p>

[LibreWolf](https://librewolf.net/) is an open-source web browser designed to increase protection against tracking and fingerprinting techniques, while also including a few security improvements. It removes all the telemetry, data collection and annoyances, as well as disabling anti-freedom features like DRM.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/193399901-56f1b47d-f092-4a3f-b7f3-9141ff5644f0.png">
  <br />
  LibreWolf
</p>

[Brave](https://brave.com/) is a fast, private and secure web browser for PC, Mac and mobile. It comes with [Brave Search](https://brave.com/search/), which is a private search engine that puts you first, not big tech for those that don't want to use Google Search.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158266393-8891913c-5acd-4a3a-98cf-ce214282126d.png">
  <br />
  Brave
</p>

[Ungoogled-Chromium](https://github.com/ungoogled-software/ungoogled-chromium) is a lightweight approach to removing Google web service dependency.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/173683899-a91b5b02-533f-4ad2-ba84-c3a70108e0dd.png">
  <br />
 Ungoogled-Chromium
</p>

[Vivaldi](https://vivaldi.com/) is a fast, private and secure web browser for PC, Mac and mobile. It comes with built-in features like Notes, Screen Capture, Image Properties and (a lot) more.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158266396-25f48ceb-9868-4d8f-80a3-30bbd0bbf092.png">
  <br />
  Vivaldi
</p>

[Ghostery Dawn](https://www.ghostery.com/dawn) is a fast, private and secure web browser for PC, Mac and mobile. It comes with the complete Ghostery Privacy Suite including [Ghostery Glow](https://www.ghostery.com/glow) a private search engine that does not log your search history, which means you get served objective results, not results that are filtered by the likelihood you’ll click on them.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/169711128-745e445d-0c1e-46d8-a7cf-12b0d6fcbda5.png">
  <br />
  Ghostery Dawn
</p>

### Privacy & Security Focused Browser extensions

[Back to the Top](#table-of-contents)

[UBlock Origin](https://ublockorigin.com/) is a free and open-source, cross-platform browser extension for content filtering primarily aimed at neutralizing privacy invasion in an efficient, user-friendly method.

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/ublock-origin/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/ublock-origin/cjpalhdlnbpafiamejdnhcphjbkeiagm)

[Privacy Badger](https://privacybadger.org/) is a browser extension that automatically learns to block invisible trackers.

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/privacy-badger17/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/privacy-badger/pkehgijcmpdhfbdbbnkijodmdjhbjlgp)

[DuckDuckGo Privacy Essentials](https://duckduckgo.com/app) is an extension that seamlessly helps prevent your personal information from being exposed during everyday online activity. 

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/duckduckgo-for-firefox/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/duckduckgo-privacy-essent/bkdgflcldnnnapblkhphbgpggdiikppg?hl=fr)

[Ghostery](https://www.ghostery.com/ghostery-browser-extension) is a comprehensive privacy protection Ad Blocker browser extension.

 * [Firefox extension](https://www.ghostery.com/ghostery-ad-blocker-firefox)
 * [Chrome extension](https://www.ghostery.com/ghostery-ad-blocker-chrome)

[HTTPS Everywhere](https://www.eff.org/https-everywhere)  is an extension created by EFF and the Tor Project which automatically switches thousands of sites from insecure "http" to secure "https".

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/https-everywhere/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/https-everywhere/gcbommkclmclpchllfjekcdonpmejbdp?hl=en)

[CleanURLs](https://gitlab.com/KevinRoebert/ClearUrls) is an extension will automatically remove tracking elements from URLs to help protect your privacy when browsing through the Internet.

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/clearurls/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/clearurls/lckanjgmijmafbedllaakclkaicjfmnk/)

**PixelBlock** is an Gmail extension that blocks email tracking attempts used to detect when you open and read emails. 

 * [Chrome extension](https://chrome.google.com/webstore/detail/pixelblock/jmpmfcjnflbcoidlgapblgpgbilinlem/)

[Sitejabber](https://www.sitejabber.com/) is an extension for consumers to find trustworthy online businesses and avoid scams.

[Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/sitejabber/)

[Chrome extension](https://chrome.google.com/webstore/detail/sitejabber-ratings-review/ckiddbafgcfifpioacgfijgicacanflo)

[1Password](https://1password.com/) is a password manager that provides a place for users to store various passwords, software licenses, and other sensitive information in a virtual vault that is locked with a PBKDF2-guarded master password.

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/1password-x-password-manager/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/1password-%E2%80%93-password-mana/aeblfdkhhhdcdjpifhhbdiojplfjncoa?hl=en)

[Bitwarden](https://bitwarden.com/) is a free and open-source password management service that stores sensitive information such as website credentials in an encrypted vault.

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/bitwarden-password-manager/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/bitwarden-free-password-m/nngceckbapebfimnlniiiahkandclblb)

[Guardio](https://guard.io/) is a lightweight extension designed to help you browse quickly and securely. It will clean your browser, speed it up, and protect your private information.

 * [Chrome extension](https://chrome.google.com/webstore/detail/guardio-protection-for-ch/gjfpmkejnolcfklaaddjnckanhhgegla)

[OneTab](https://www.one-tab.com/) is an extension that converts your tabs to a list and speeds up your browser.

 * [Firefox extension](https://addons.mozilla.org/en-US/firefox/addon/onetab/)
 * [Chrome extension](https://chrome.google.com/webstore/detail/onetab/chphlpgkkbolifaimnlloiipkdnihall)

### Privacy-focused Search Engines

[Back to the Top](#table-of-contents)

 * [Brave Search](https://brave.com/search/)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009061-21142683-0943-4ef2-9ca1-a66831410ae4.png">
  <br />

</p>

 * [Ghostery Glow](https://www.ghostery.com/glow)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009065-2d360d4f-9712-4f80-9da2-e8808773ba7f.png">
  <br />

</p>

 * [DuckDuckGo](https://duckduckgo.com/)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009064-2d753a92-6e80-48a5-9e88-deb9d886162e.png">
  <br />

</p>

 * [Startpage](https://www.startpage.com/)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009074-7e0ae42e-84b2-4815-9280-d56ff289462b.png">
  <br />

</p>

 * [Qwant](https://www.qwant.com/)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009070-b652dab1-0f4a-4020-b231-bc7da3897c04.png">
  <br />

</p>

 * [Ecosia](https://www.ecosia.org/)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009066-d81594fe-873f-4aed-ac0f-2f9f6673ebc9.png">
  <br />

</p>

 * [Swisscows](https://swisscows.com/)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009076-74c38325-077d-4511-be75-981646dd11c8.png">
  <br />

</p>

 * [searX](https://searx.info/)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009072-54539257-92f9-4f7e-9515-3cb14a2e8695.png">
  <br />

</p>

 * [Mojeek](https://www.mojeek.com/)

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187009069-afd5a4e2-aea5-4143-87ba-8882c31476a8.png">
  <br />

</p>

## Windows Security Hardening
[Back to the Top](#table-of-contents)

 * [Personal Security Checklist](https://github.com/Lissy93/personal-security-checklist) is a curated checklist of 300+ tips for protecting digital security and privacy in 2022.

 * [Awesome Privacy](https://github.com/Lissy93/awesome-privacy) is acurated list of privacy & security-focused software and services. 
 
 * [Cover Your Tracks AKA Panopticlick](https://coveryourtracks.eff.org/) is a web tool developed by the Electronic Frontier Foundation (EFF) that tests your browser to see how well you are protected from tracking and fingerprinting.

[Sysinternals Suite](https://docs.microsoft.com/en-us/sysinternals/downloads/sysinternals-suite) is the entire set of Sysinternals Utilities rolled up into a single download. Also, checkout the [Sysinternals Utilities Index](https://docs.microsoft.com/en-us/sysinternals/downloads/).

[Microsoft Security Compliance Toolkit (SCT) 1.0](https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-security-configuration-framework/security-compliance-toolkit-10) is a set of tools that allows enterprise security administrators to download, analyze, test, edit, and store Microsoft-recommended security configuration baselines for Windows and other Microsoft products. Also checkout [Microsoft Security Baselines](https://techcommunity.microsoft.com/t5/microsoft-security-baselines/new-amp-updated-security-tools/ba-p/1631613).

 - [Microsoft recommended block rules](https://docs.microsoft.com/en-us/windows/security/threat-protection/windows-defender-application-control/microsoft-recommended-block-rules)
 
 - [Windows Server Security documentation](https://docs.microsoft.com/en-us/windows-server/security/security-and-assurance)

[PingCastle](https://www.pingcastle.com/) is a tool to check the security of [Active Directory](https://docs.microsoft.com/en-us/windows-server/identity/ad-ds/get-started/virtual-dc/active-directory-domain-services-overview).

[ConfigureDefender](https://github.com/AndyFul/ConfigureDefender) is a small GUI application to view and configure important Defender settings on Windows 10/11 and Windows Server 2019 or later. It uses [PowerShell cmdlets](https://docs.microsoft.com/en-us/powershell/scripting/developer/cmdlet/cmdlet-overview) (with a few exceptions) to change the Windows Defender settings.

[Hardentools](https://github.com/securitywithoutborders/hardentools) is designed to disable a number of "features" exposed by operating systems (Microsoft Windows, for now) and some widely used applications (Microsoft Office and Adobe PDF Reader, for now). These features, commonly thought for enterprise customers, are generally useless to regular users and rather pose as dangers as they are very commonly abused by attackers to execute malicious code on a victim's computer. 

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/179671248-1546acd4-9c92-4daa-962f-f262b2d08f2b.png">
  <br />
  Hardentools UI
</p>

[Chris Titus Tech Windows Utility](https://github.com/ChrisTitusTech/winutil) is the Ultimate Windows 10 & 11 script designed to be a swiss army knife of Windows tools to help setup and optimize machines. [The Ultimate Windows Utility | Chris Titus Tech YouTube.](https://www.youtube.com/watch?v=tPRv-ATUBe4)

**Paste this command into Powershell (admin):**

```iwr -useb https://christitus.com/win | iex```

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/169711131-7b8e000c-e544-470e-9164-d76938759ccf.png">
  <br />
</p>

[O&O ShutUp10++](https://www.oo-software.com/en/shutup10) is a free tool that let's you have full control over which comfort functions under **Windows 10 and Windows 11** you wish to use, and you decide when the passing on of your data goes too far.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/173458921-b24022a1-b76f-41b0-83df-547a50b8a2eb.png">
  <br />
</p>

### Encryption Tools

[Back to the Top](#table-of-contents)

[BitLocker Drive Encryption](https://docs.microsoft.com/en-us/windows/security/information-protection/bitlocker/bitlocker-overview) is a data protection feature that integrates with the Windows operating system and addresses the threats of data theft or exposure from lost, stolen, or inappropriately decommissioned computers. BitLocker provides the most protection when used with a Trusted Platform Module (TPM) version 1.2 or later.

[Folder Lock](https://www.newsoftwares.net/folderlock/) is an encryption tool that can Lock and Hide files and folders within seconds. It enables you to Password Protect and restricts the unwanted eyes from viewing files, folders and drives. 

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187567416-46dc4eb7-0217-4010-9509-c4e826784128.png">
  <br />
</p>

[VeraCrypt](https://www.veracrypt.fr/code/VeraCrypt/) is free open-source disk encryption software for Windows, Mac OS X and Linux. The file encryption, data encryption performed by VeraCrypt is real-time (on-the-fly), automatic, transparent, needs very little memory, and does not involve temporary unencrypted files.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/187567414-7b1348e5-da9c-4cf8-8505-27d203493c0f.png">
  <br />
</p>

## Storage Disk Health/Data Recovery 

[Back to the Top](#table-of-contents)

[DiskMon](https://docs.microsoft.com/en-us/sysinternals/downloads/diskmon) is an application that logs and displays all hard disk activity on a Windows system.

[Disk Drill](https://www.cleverfiles.com/data-recovery-software.html) is a Data Recovery Software that recover any type of deleted files in Windows including Office documents, messages, and media files quickly and easily. Disk Drill for Windows is free data recovery software that restores deleted files from an HDD, USB drive or any kind of disk-based storage media. 

[Scrutiny](https://github.com/AnalogJ/scrutiny) is a WebUI tool for smartd [S.M.A.R.T monitoring](https://www.crucial.com/articles/about-ssd/smart-and-ssds), Historical Trends & Real World Failure Thresholds.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/183272245-468ac924-ebd6-475d-94af-6dfa7b97e7cb.png">
<br />
Scrutiny UI
</p>


## Battery Health

[Back to the Top](#table-of-contents)

### Powercfg Battery Report

[Powercfg](https://docs.microsoft.com/en-us/windows-hardware/design/device-experiences/powercfg-command-line-options) is a tool built-in to Windows that generates detailed report on battery health of your Windows device. 

To generate a battery report, **press Windows Key + X and select Command Prompt**. Then type in **powercfg /batteryreport**. This command saves a battery report in HTML format to

```C:\Users\Your_Username\battery-report.html```

Open the file in your browser and check the following parameters:

  * The difference between Design Capacity and Full Charge Capacity. As batteries wear over time, the full charge capacity will be less than the design capacity.
  
  * Battery capacity drained over the last few days in different power states. Also, check out the battery usage graph.
  
  * Compare the battery life from the time you purchased the laptop and see the trends of Full Charge Capacity in relation to Design Capacity.
  
  * Check the battery’s usage and duration. And the time your computer ran on battery or plugged into the power outlet.
  
### Microsys Smarter Battery

[Smarter Battery](https://www.microsys.ro/smarterbattery.htm) is a battery monitoring utility for portable computers, intended to provide all the data of your battery, to help prolong its life and save its energy. It shows you the evolution of the battery's capacity during the charge / discharge cycles and computes a few important battery parameters, such as the wear level and discharge cycles count.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/183272241-70318426-0302-41c8-9cb2-c262b9d13b30.png">
<br />
 Microsys Smarter Battery UI
</p>


# Getting Software

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

[Windows Package Manager](https://docs.microsoft.com/en-us/windows/package-manager/) is a comprehensive [package manager solution](https://docs.microsoft.com/en-us/windows/package-manager/#understanding-package-managers) that consists of a command line tool and set of services for installing applications on Windows 10. Developers can use the winget command line tool to discover, install, upgrade, remove and configure a curated set of applications. After it is installed, developers can access winget via the [Windows Terminal](https://docs.microsoft.com/en-us/windows/terminal/), [PowerShell](https://docs.microsoft.com/en-us/powershell/), or the Command Prompt.

**[Using the winget tool to install and manage software packages](https://docs.microsoft.com/en-us/windows/package-manager/winget/)**

**[Submitting packages to Windows Package Manager](https://docs.microsoft.com/en-us/windows/package-manager/package/)**

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/115297923-9e764880-a111-11eb-9eb6-7bb9ab0b6192.png">
  <br />
</p>

[Microsoft PowerToys](https://github.com/microsoft/PowerToys) is a set of utilities for power users to tune and streamline their Windows 10 experience for greater productivity. To get more information on [PowerToys](https://docs.microsoft.com/windows/powertoys/), or any other tools and resources for [Windows development environments](https://docs.microsoft.com/windows/dev-environment/overview), go to [docs.microsoft.com](https://docs.microsoft.com/windows/powertoys/).

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/111210946-17223c00-858b-11eb-90c1-be411aab7107.png">
</p>

[Homebrew](https://brew.sh) is the missing Package Manager for your macOS, Linux, and Windows 10 (with [Windows Subsystem for Linux (WSL)](https://docs.microsoft.com/en-us/windows/wsl/)) system. Homebrew is an essential tool for any developer/engineer.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/115158810-ee3b0e00-a044-11eb-98b4-3c0dc35ff972.png">
  <br />
</p>

[Ninite](https://ninite.com/) is a package management system offering that enables users automatically install popular applications for their Windows 10 OS.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/110880123-f740fe80-8292-11eb-9599-b4cc34b38552.png">
<br />

</p>

[Ninite Pro](https://ninite.com/pro) is the commercially-licensed version of Ninite. It will update/deploy more apps and popular plugins than the free home-use version. Other functionalities include Ninite Pro's audit mode that shows you the apps on each machine and whether they are up-to-date.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/115158813-f09d6800-a044-11eb-9584-702f82734fcd.png">
  <br />
</p>

[Chocolatey](https://chocolatey.org/) is a software management solution unlike anything else you've ever experienced on Windows. It focuses on simplicity, security, and infinite scalability. The GUI is perhaps the best way to start for beginners. It can be installed by using `choco install chocolateygui` after having installed choco as described [here](https://chocolatey.org/install).

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/110880124-f7d99500-8292-11eb-9e7d-e9c335cbc173.png">
<br />

</p>

[Scoop](https://scoop.sh/) is an open source package manager for Windows 10. It gives Windows users an efficient way to download programs without having to visit each site manually, downloading the files, and running the installer.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/115158811-ef6c3b00-a044-11eb-9988-a705d35115ff.png">
  <br />
</p>

# Gaming

[Back to the Top](#table-of-contents)

## Manage/Control Fans

[Back to the Top](#table-of-contents)

[Fan Control](https://github.com/Rem0o/FanControl.Releases) is a highly customizable fan controlling software for Windows

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/168446885-58a41783-cfbb-4058-a9c9-21bd01a49c3f.png">
<br />
Fan Control main UI
</p>

[MSI Afterburner](https://www.msi.com/page/afterburner) is a tool that provides a detailed overview of your hardware, and also allows graphics card overclocking. It includes RTSS which also provides an on-screen-display during games.

[MSI Afterburner Remote Server](https://www.msi.com/page/afterburner) is a that serves up an HTTP endpoint with data from MSI Afterburner in an XML format.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/168446889-6ac9837d-b534-4749-966d-28aef7c03bef.png">
<br />
MSI Afterburner UI
</p>

## Gaming Peripherals

### RGB Devices

[Back to the Top](#table-of-contents)

[Razer Synapse](https://www.razer.com/synapse-3) is a unified cloud-based hardware configuration tool that takes your Razer devices to the next level.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208275996-70a83775-a6aa-4496-a37d-d3945c751beb.png">
</p>

[Logitech G Hub](https://www.logitechg.com/en-us/innovation/g-hub.html) is software tool that lets you customize Logitech G gaming mice, keyboards, headsets, speakers, and other devices.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208275997-2b60eac7-0fa3-43d0-a5c6-d49ae2447d61.png">
</p>

[Corsair iCUE](https://www.corsair.com/us/en/icue) is a tool that enables gaming peripherals and personal computer components including computer case fans, RGB lighting, gaming headsets, gaming keyboards, gaming mouse, remap buttons and switches, RAM DIMMS and AIO CPU cooler together.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208275999-4904fece-56c6-4a04-a2de-04bb587d7c1b.png">
</p>

[Project Aurora](https://www.project-aurora.com/) is a Unified Keyboard RGB Lighting for Logitech, Razer, and Corsair.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208276000-f84c1929-a9b0-45bf-a700-c17c4ece8a6e.png">
</p>

[SignalRGB](https://signalrgb.com/) is a tool that lets you control your RGB devices, your way. Please close all your other RGB apps (ICUE, Synapse, GHub, Armory Crate, etc.) before installing SignalRGB.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208276003-408c7866-5d19-4061-84b0-afcbe2349e9b.png">
</p>

[Artemis RGB](https://artemis-rgb.com/) is an open source a unified hardware configuration tool.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208276002-6983c582-0e60-487f-b7f6-8c56d7cebf7d.png">
</p>

[OpenRGB](https://openrgb.org/) is an open source RGB lighting control tool that doesn't depend on manufacturer software.  This includes ASUS Aura, ASRock, Corsair, G.Skill, Gigabyte, HyperX, MSI, Razer Synapse, ThermalTake, RGB Fusion, iCue, Mystic Light, Alienware AlienFX, Logitech G Hub, and any other RGB app. OpenRGB has support for Windows, Linux, MacOS(Apple Silicon ARM64 and Intel). 

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158273200-4a3f733c-73b3-4353-b4f0-90e787ea178a.PNG">
  <br />
  OpenRGB Device View
</p>

[OpenRGB SDK](https://gitlab.com/CalcProgrammer1/OpenRGB/-/wikis/OpenRGB-SDK-Documentation) is a network-based Software Development Kit, which allows third-party software to control all of your RGB. This allows for game integrations, music visualization, ambient lighting, and anything else you can imagine. SDK bindings are available for multiple programming languages including C++, Python, C#, Java, and more.

### Game Controllers
[Back to the Top](#table-of-contents)

[Xbox Wireless Controller + USB-C® Cable](https://www.xbox.com/en-us/accessories/controllers/xbox-wireless-controller-usb-c)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/187094245-3c406751-4e4b-42fd-bd2c-a72181722fad.png">
<br />
Xbox Controller
</p>

* [Xbox Game Bar](https://aka.ms/controllerbar) is a tool for Windows 10 and 11 that can be opened with Win+G, or by pressing the Xbox button on an Xbox controller. It has quick shortcuts for taking screenshots or screen recordings, checking CPU and GPU usage, changing audio levels/outputs, and more.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/196626403-bd00391f-f576-48c6-82db-437f738583dd.png">
<br />
</p>

Game Controller Bar. Image Credit: [Microsoft](https://blogs.windows.com/windows-insider/2022/05/05/windows-insiders-can-now-try-out-an-early-preview-of-controller-bar/)

[PlayStation 5 DualSense™ Wireless Controller](https://www.playstation.com/en-us/accessories/dualsense-wireless-controller/)

* [Update the wireless controller firmware](https://controller.dl.playstation.net/controller/lang/gb/fwupdater.html)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/187094347-109c80cd-5cc3-4a97-8a8f-0181687ab0d4.png">
<br />
PS 5  DualSense™ Controller
</p>

[Nintendo Switch Pro Controller](https://www.amazon.com/Nintendo-Switch-Pro-Controller/dp/B01NAWKYZ0)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/194023448-09e74efa-67f8-4503-87f5-5b7e59289608.png">
<br />
Nintendo Switch Pro Controller
</p>

## Graphics Drivers

### NVIDIA
[Back to the Top](#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/189858113-0d681062-8bd5-4db9-b92b-71bec318f2f5.png">
  <br />
</p>

[NVCleanstall](https://www.techpowerup.com/nvcleanstall/) is a tool that lets you customize the NVIDIA GeForce Driver package by removing components that you don't need (or want). This not only keeps things tidy, but also lowers disk usage and memory footprint.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158471956-9a6d5225-f27e-4096-a36f-8c0c72437e7e.png">
  <br />
  NVCleanstall UI
</p>

[EVGA PrecisionX1](https://www.evga.com/precisionx1/) is a software that allows you to fine tune your NVIDIA graphics card, including GPU Clock Offsets, Memory Clock Offsets, Fan Speed, voltage and much more. 

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/200516181-aa7d5033-7f45-47a9-a8ae-de9a1067955b.png">
</p>
    

### AMD 
 [Back to the Top](#table-of-contents)
 
 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/190588167-4fd0bd50-cd43-47f1-b28f-16f70a243549.png">
  <br />
</p>

[Precision Boost 2](https://www.amd.com/en/support/kb/faq/cpu-pb2) is a performance-maximizing technology available will work with the Ryzen 5000 or newer AMD processors improving your PC's performance by raising clockspeeds, which makes the processor and your applications run faster. This technology will not be applied retroactively to previous-gen models, like Ryzen 3000 chips. You'll need either a 500-series or 400-series motherboard and a new BIOS based on version 1.1.8.0 AGESA. 
 
* **[AMD FidelityFX Super Resolution (FSR)](https://www.amd.com/en/technologies/radeon-software-fidelityfx)** is an open source, high-quality solution for producing high resolution frames from lower resolution inputs. FSR enables “practical performance” for costly render operations, such as hardware ray tracing for the AMD RDNA™ and AMD RDNA™ 2 architectures.

* **[AMD FidelityFX Super Resolution (FSR) 2.0](https://github.com/GPUOpen-Effects/FidelityFX-FSR2)** is an open source, high-quality solution for producing high resolution frames from lower resolution inputs. It uses temporal data and optimized anti-aliasing to boost framerates in supported games while delivering similar or better image quality than native resolution.

* **[FidelityFX Super Resolution 3 (FSR 3)](https://www.amd.com/en/technologies/fidelityfx-super-resolution)**, is the latest version of the company’s upscaling tech. AMD claims it’ll provide 2x times increase in frame rate over FSR 2, boosted by the new AMD Fluid Motion Frames technology.

* **[AMD Open Source Driver for Vulkan®](https://github.com/GPUOpen-Drivers/AMDVLK)** is an open-source Vulkan driver for Radeon™ graphics adapters on Linux®. It is built on top of AMD's Platform Abstraction Library (PAL), a shared component that is designed to encapsulate certain hardware and OS-specific programming details for many of AMD's 3D and compute drivers. 

* **[Vulkan® Memory Allocator (VMA)](https://gpuopen.com/vulkan-memory-allocator/)** is a library provides a simple and easy to integrate API to help you allocate memory for Vulkan® buffer and image storage. 

* **[Radeon™ Raytracing Analyzer (RRA)](https://gpuopen.com/radeon-raytracing-analyzer/)** is a tool that investigates the performance of your raytracing applications and highlight potential bottlenecks.

* **[Radeon™ GPU Profiler](https://gpuopen.com/rgp/)** is a low-level optimization tool that provides detailed information on Radeon™ GPUs.

* **[Radeon™ GPU Analyzer](https://gpuopen.com/rga/)** is an offline compiler and performance analysis tool for DirectX®, Vulkan®, SPIR-V™, OpenGL®, and OpenCL™. It can be used together with [RGP](https://gpuopen.com/rgp/), [RMV](https://gpuopen.com/rmv/), and [RDP](https://gpuopen.com/rdp/).

 * **[Radeon™ Developer Panel (RDP)](https://gpuopen.com/rdp/)** is an essential part of the Radeon™ Developer Tool Suite. It provides the communication channel that delivers requests to, and receives data from, the AMD Radeon™ driver.

* **[Radeon™ Memory Visualizer (RMV)](https://gpuopen.com/learn/radeon-memory-visualizer-on-linux/)** is a powerful tool that allows users to analyze video memory usage on AMD Radeon GPUs.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/190555167-e1293b98-eaf1-4df0-815c-88569b8dfe23.png">
  <br />
  Radeon™ Memory Visualizer (RMV)
</p>

[Hydra 1.2]() is a AMD Ryzen tuning and overclocking utility which adds support for Zen 4 CPUs & also allows GPU tuning as an additional component to the suite. It's developed and maintained by [Yuri Bubliy](https://twitter.com/1usmus) aka 1usmus. To get [early access Hydra 1.2 and Hydra Pro 1.2](https://www.patreon.com/1usmus). 
  
   * Complete redesign of all features.
   * New Curve Optimizer diagnostics (and for Zen 4).
   * More flexibility for AMD PBO2 and HYBRID OC.
   * Automatic problem solving (assistant).
   * Auto GPU tuning.
   * Unlimited GPU profiling.
   * Powerful new monitoring.
    
<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/208854746-193adc55-c153-43ca-a3b8-7b5d2b3b993a.png">
</p>

[Radeon Software Slimmer](https://github.com/GSDragoon/RadeonSoftwareSlimmer) is a utility to trim down the bloat with Radeon Software for AMD GPUs on Microsoft Windows.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/158469181-d31fabff-c75c-4e4e-92c8-e0a5ea37cbac.png">
  <br />
  Radeon Software Slimmer UI
</p>

### Intel ARC
[Back to the Top](#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/190093904-20680f0b-a387-4a48-9c43-de8d5f0b5d2e.png">
  <br />
</p>

[Intel® Arc™ Control](https://www.intel.com/content/www/us/en/products/docs/arc-discrete-graphics/software/arc-control.html) is a utility that puts you in full command of your graphics experience. Tune your graphics performance to perfection, manage driver updates.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/200110729-defad8c3-2b55-4c5d-8f74-d9a8093564fc.png">
  <br />
  Intel ARC Control Driver settings
</p>

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/200110732-2900b64e-3852-4236-8885-b93a2274fbf8.png">
  <br />
  Intel ARC Control Studio settings
</p>

[Intel® Graphics Driver 31.0.101.3430 for Intel® Arc™ A-Series Graphics.](https://www.intel.com/content/www/us/en/download/726609/intel-arc-graphics-windows-dch-driver.html)
   
   * [Intel® Arc™ A770M Graphics](https://www.intel.com/content/www/us/en/products/sku/228341/intel-arc-a770m-graphics/downloads.html)
   * [Intel® Arc™ A550M Graphics](https://www.intel.com/content/www/us/en/products/sku/228343/intel-arc-a550m-graphics/downloads.html)
   * [Intel® Arc™ A380 Graphics](https://www.intel.com/content/www/us/en/products/sku/227959/intel-arc-a380-graphics/downloads.html)
   * [Intel® Arc™ A730M Graphics](https://www.intel.com/content/www/us/en/products/sku/228340/intel-arc-a730m-graphics/downloads.html)
   * [Intel® Arc™ A370M Graphics](https://www.intel.com/content/www/us/en/products/sku/228342/intel-arc-a370m-graphics/downloads.html)
   * [Intel® Arc™ A350M Graphics](https://www.intel.com/content/www/us/en/products/sku/228338/intel-arc-a350m-graphics/downloads.html)
   * [Intel® Core™ i7-11700 Processor (16M Cache, up to 4.90 GHz)](https://www.intel.com/content/www/us/en/products/sku/212279/intel-core-i7-11700-processor-16m-cache-up-to-4-90-ghz/downloads.html)
   * [Intel® Core™ i9-11900 Processor (16M Cache, up to 5.20 GHz)](https://www.intel.com/content/www/us/en/products/sku/212252/intel-core-i9-11900-processor-16m-cache-up-to-5-20-ghz/downloads.html)
   * [Intel® Core™ i9-11900T Processor (16M Cache, up to 4.90 GHz)](https://www.intel.com/content/www/us/en/products/sku/212256/intel-core-i9-11900t-processor-16m-cache-up-to-4-90-ghz/downloads.html)
   * [Intel® Core™ i9-11900K Processor (16M Cache, up to 5.30 GHz)](https://www.intel.com/content/www/us/en/products/sku/212325/intel-core-i9-11900k-processor-16m-cache-up-to-5-30-ghz/downloads.html)
   * [Intel® Core™ i9-12950HX Processor (30M Cache, up to 5.00 GHz)](https://www.intel.com/content/www/us/en/products/sku/228439/intel-core-i9-12950hx-processor-30m-cache-up-to-5-00-ghz/downloads.html)
   * [Intel® Core™ i9-12900HX Processor (30M Cache, up to 5.00 GHz)](https://www.intel.com/content/www/us/en/products/sku/228441/intel-core-i9-12900hx-processor-30m-cache-up-to-5-00-ghz/downloads.html)
   * [Intel® Core™ i7-12650HX Processor (24M Cache, up to 4.70 GHz)](https://www.intel.com/content/www/us/en/products/sku/228795/intel-core-i7-12650hx-processor-24m-cache-up-to-4-70-ghz/downloads.html)
   * [Intel® Core™ i7-12800HX Processor (25M Cache, up to 4.80 GHz)](https://www.intel.com/content/www/us/en/products/sku/226058/intel-core-i7-12800hx-processor-25m-cache-up-to-4-80-ghz/downloads.html)
   * [Intel® Core™ i7-12850HX Processor (25M Cache, up to 4.80 GHz)](https://www.intel.com/content/www/us/en/products/sku/228442/intel-core-i7-12850hx-processor-25m-cache-up-to-4-80-ghz/downloads.html)
   * [Intel® Core™ i5-12450HX Processor (12M Cache, up to 4.40 GHz)](https://www.intel.com/content/www/us/en/products/sku/228794/intel-core-i5-12450hx-processor-12m-cache-up-to-4-40-ghz/downloads.html)
   * [Intel® Core™ i5-12600HX Processor (18M Cache, up to 4.60 GHz)](https://www.intel.com/content/www/us/en/products/sku/228438/intel-core-i5-12600hx-processor-18m-cache-up-to-4-60-ghz/downloads.html)
   * [Intel® Core™ i5-12450H Processor (12M Cache, up to 4.40 GHz)](https://www.intel.com/content/www/us/en/products/sku/132222/intel-core-i5-12450h-processor-12m-cache-up-to-4-40-ghz/downloads.html)
   * [Intel® Core™ i5-12500H Processor (18M Cache, up to 4.50 GHz)](https://www.intel.com/content/www/us/en/products/sku/96141/intel-core-i5-12500h-processor-18m-cache-up-to-4-50-ghz/downloads.html)
   * [Intel® Core™ i5-12600H Processor (18M Cache, up to 4.50 GHz)](https://www.intel.com/content/www/us/en/products/sku/96156/intel-core-i5-12600h-processor-18m-cache-up-to-4-50-ghz/downloads.html)
   * [Intel® Core™ i7-12700H Processor (24M Cache, up to 4.70 GHz)](https://www.intel.com/content/www/us/en/products/sku/132228/intel-core-i7-12700h-processor-24m-cache-up-to-4-70-ghz/downloads.html)
   * [Intel® Core™ i7-12800H Processor (24M Cache, up to 4.80 GHz)](https://www.intel.com/content/www/us/en/products/sku/226059/intel-core-i7-12800h-processor-24m-cache-up-to-4-80-ghz/downloads.html)
   * [Intel® Core™ i7-12650H Processor (24M Cache, up to 4.70 GHz)](https://www.intel.com/content/www/us/en/products/sku/226066/intel-core-i7-12650h-processor-24m-cache-up-to-4-70-ghz/downloads.html)
   * [Intel® Core™ i9-12900H Processor (24M Cache, up to 5.00 GHz)](https://www.intel.com/content/www/us/en/products/sku/132214/intel-core-i9-12900h-processor-24m-cache-up-to-5-00-ghz/downloads.html)
   * [Intel® Core™ i9-12900HK Processor (24M Cache, up to 5.00 GHz)](https://www.intel.com/content/www/us/en/products/sku/132215/intel-core-i9-12900hk-processor-24m-cache-up-to-5-00-ghz/downloads.html)
   * [Intel® Core™ i5-1240P Processor (12M Cache, up to 4.40 GHz)](https://www.intel.com/content/www/us/en/products/sku/132221/intel-core-i5-1240p-processor-12m-cache-up-to-4-40-ghz/downloads.html)
   * [Intel® Core™ i5-1250P Processor (12M Cache, up to 4.40 GHz)](https://www.intel.com/content/www/us/en/products/sku/226256/intel-core-i5-1250p-processor-12m-cache-up-to-4-40-ghz/downloads.html)
   * [Intel® Core™ i7-1280P Processor (24M Cache, up to 4.80 GHz)](https://www.intel.com/content/www/us/en/products/sku/226253/intel-core-i7-1280p-processor-24m-cache-up-to-4-80-ghz/downloads.html)
   * [Intel® Core™ i7-1260P Processor (18M Cache, up to 4.70 GHz)](https://www.intel.com/content/www/us/en/products/sku/226254/intel-core-i7-1260p-processor-18m-cache-up-to-4-70-ghz/downloads.html)
   * [Intel® Core™ i7-1270P Processor (18M Cache, up to 4.80 GHz)](https://www.intel.com/content/www/us/en/products/sku/226255/intel-core-i7-1270p-processor-18m-cache-up-to-4-80-ghz/downloads.html)
   
   
[Intel® Arc™ Pro Graphics Windows* DCH Driver](https://www.intel.com/content/www/us/en/download/741626/intel-arc-pro-graphics-windows-dch-driver.html?wapkw=intel%20arc)
   
   * [Intel® Arc™ Pro A50 Graphics](https://www.intel.com/content/www/us/en/products/sku/230316/intel-arc-pro-a50-graphics/downloads.html)
   * [Intel® Arc™ Pro A40 Graphics](https://www.intel.com/content/www/us/en/products/sku/230317/intel-arc-pro-a40-graphics/downloads.html)
   * [Intel® Arc™ Pro A30M Graphics](https://www.intel.com/content/www/us/en/products/sku/216962/intel-arc-pro-a30m-graphics/downloads.html)
    
[Intel Xe Super Sampling (XeSS)](https://www.intel.com/content/www/us/en/products/docs/arc-discrete-graphics/xess.html) is a temporal image upscaling AI rendering technology that increases graphics performance similar to [NVIDIA's DLSS (Deep Learning Super Sampling)](https://developer.nvidia.com/dlss). 
The ARC GPUs have Xe Matrix eXtenstions matrix (XMX) engines for hardware-accelerated AI processing. XeSS will be able to run on devices without XMX, including integrated graphics, though, the performance of XeSS will be lower on non-Intel graphics cards because it will be powered by [DP4a instruction](https://www.intel.com/content/dam/www/public/us/en/documents/reference-guides/11th-gen-quick-reference-guide.pdf).

* [Intel XeSS ML Upscaling | The Digital Foundry Tech Review | XeSS vs DLSS vs Native](https://www.youtube.com/watch?v=rfLwZy650s0)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/190093928-ca15e58b-f830-47f5-b66b-19219d160178.png">
  <br />
</p>

Intel ARC GPUs Overview. Credit: [Intel](https://www.intel.com/content/www/us/en/products/details/discrete-gpus/arc.html)

### Setting up DXVK on Windows

[Back to the Top](#table-of-contents)

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/209427193-05969dfa-0a84-4107-80d7-68c21435034d.png">
</p>

### Important Note

Online multi-player games

Manipulation of Direct3D libraries in multi-player games may be considered cheating and can get your account banned. This may also apply to single-player games with an embedded or dedicated multiplayer portion. **Use at your own risk.**

#### What is DXVK?

[DXVK](https://github.com/doitsujin/dxvk) is a set of software libraries that translates DirectX API calls to Vulkan API calls. It supports **DirectX versions 9, 10 and 11**. Vulkan and APIs similar to it **(DirectX12, Metal)** are a a lot better at making use of multi-core/multi-threaded CPUs to batch up work that needs to be done by the GPU thereby making better use of both CPU and GPU. This can lead to significant performance boosts in some games.

**First, do these steps:**

  * 1. Download the [latest release of DXVK](https://github.com/doitsujin/dxvk/releases) from GitHub.

  * 2. Use 7-Zip to unzip the ```dxvk-x.x.x folder``` (where ```x.x.x``` is the version number).
  
 **Do these steps for each game:**

**Important information you need to know about the game you want use DXVK with:**

   * The version of DirectX it uses.

   * Whether it's using 32-bit or 64-bit.

In most cases, you can find out both of these from a game's API section section on [PCGamingWiki](https://www.pcgamingwiki.com/wiki/Home). There may be some clues in the file/folder names your game's folder about it being 32-bit or 64-bit. If there's a ```steam_api64.dll``` there then it's probably **64-bit** or if there's a ```binkw32.dll``` it's likely to be **32-bit**.

 * Open the folder where your game's executable is (.exe file).

 * Open the folder where you extracted DXVK and go the appropriate folder for your game's bitness, x32 for 32-bit, x64 for 64-bit.

 * Copy the following files to the folder where the game's executable is depending on the game's DirectX version:

|DirectX version | Files to copy|
|------------|-----------|
|9	| d3d9.dll|
|10	| d3d10.dll, d3d10_1.dll, d3d10core.dll, d3d11.dll and dxgi.dll|
|11	| d3d11.dll and dxgi.dll|

**If your game supports multiple DirectX versions copy all the applicable DLLs.**

**That's it!** Now run the game.

**Unfortunately, DXVK isn't going to work in all situations. So far I've been unsuccessful in getting it to work in the following scenarios:**

   * Xbox Game Pass (and likely Microsoft Store) games.
   * Steam In-Home Streaming with exclusive fullscreen games.

## Improving Game Performance & Load Times

### DirectStorage

[Back to the Top](#table-of-contents)

[DirectStorage](https://learn.microsoft.com/en-us/gaming/gdk/_content/gc/system/overviews/directstorage/directstorage-overview) is a feature intended to allow games to make full use of high-speed storage (such as NVMe SSDs) that can can deliver multiple gigabytes a second of small (eg 64kb) data reads with minimal CPU overhead. Although it is possible to saturate a drive using traditional ReadFile-based IO the CPU overhead of increases non-linearly as the size of individual reads decreases. Additionally, most games choose to store their assets compressed on disk in order to reduce the install footprint, with these assets being decompressed on the fly as load time. The CPU overhead of this becomes increasingly expensive as bandwidth increases.

 * [Microsoft DirectStorage GitHub](https://github.com/microsoft/DirectStorage)
 * [DirectStorage on Windows Samples](https://github.com/microsoft/DirectStorage/blob/main/README.md)
 * [DirectStorage API Downloads](https://devblogs.microsoft.com/directx/directstorage-api-downloads/)
 
 New features for DirectStorage 1.1:
 
 * GPU decompression and GDeflate now available.
 * Added EnqueueSetEvent to use Win32 event objects for completion notification.
 * [Performance improvements and bug fixes.](https://devblogs.microsoft.com/directx/directstorage-api-downloads/)
    
**GPU decompression** is supported on all DirectX 12 + Shader Model 6.0 GPUs. However, one of the benefits of DirectStorage 1.1 is that GPU hardware vendors can provide additional optimizations for their hardware, called metacommands. 

 * **AMD:** https://gpuopen.com/amd-support-for-microsoft-directstorage-1-1

 * **Intel:** https://www.intel.com/content/www/us/en/developer/articles/news/directstorage-on-intel-gpus.html

 * **NVIDIA:** https://developer.nvidia.com/blog/accelerating-load-times-for-directx-games-and-apps-with-gdeflate-for-directstorage/
 
 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/206659588-6d0cb0a1-7d7f-4198-b2fd-c5a612ec3189.png">
  </br>

</p>
 
 Data flow for decompressing to a GPU resource. Image Credit: [Microsoft](https://devblogs.microsoft.com/directx/directstorage-1-1-now-available/)
 
 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/206659590-fa102043-e3c6-46db-b3a4-9122234948c4.png">
  </br>

</p>
 
 PIX timing capture showing DirectStorage reading and decompressing 1.4GiB of data. Image Credit: [Microsoft](https://devblogs.microsoft.com/directx/directstorage-1-1-now-available/)
 
### NVIDIA RTX IO

[Back to the Top](#table-of-contents)
 
[NVIDIA RTX IO](https://developer.nvidia.com/rtx-io) is a suite of technologies that enables rapid GPU-based loading and asset decompression. NVIDIA RTX™ IO lets compressed data be delivered to GPU memory with minimal staging in system memory. The GPU is utilized for decompression using GDeflate at high throughput. The CPU is freed to perform other auxiliary tasks. The GDeflate compression format will be open source, enabling developers to create ports and tools.

 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/206842250-423927e2-d529-42d9-91b2-5b1140c2d036.png">
  </br>

</p>

NVIDIA RTX IO. Image Credit: [NVIDIA](https://developer.nvidia.com/rtx-io)

### AMD StoreMI

[Back to the Top](#table-of-contents)

[AMD StoreMI](https://www.amd.com/en/technologies/store-mi) is a powerful tool for PC enthusiasts that want to improve load times, boot times, file management, or system responsiveness. A StoreMI configuration simply mirrors your most-used files to an SSD of your choosing, leaving the original copy intact. The software seamlessly redirects Windows® and your applications to use the faster mirrored copy. Removing or disabling the SSD cache leaves all of your files on the hard drive, right where they started. Available on **AMD X570, PRO 565, B550, A520, 400 Series, X399, TRX40 or WRX80 motherboard.**

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/206895460-3b4782fd-7716-46be-833c-af395b5010c0.png">
  </br>

</p>

AMD StoreMI. Image Credit: [AMD](https://www.amd.com/en/technologies/store-mi)

  **Features:**

    * Supports up to four StoreMI Cache Drives simultaneously
    * SSD partition can be used as cache 
    * Supports HDD/SSD combos of any capacity
    * Caching system mirrors your data to SSD for speedup
    * All-new UI makes setup, monitoring, reversal a snap
    * “Read only” algorithm enhances data integrity
    * Automatically prioritizes most-used data to the SSD cache
    * Ideal for accelerating apps and games on a large HDD
    
### Intel® RST

[Back to the Top](#table-of-contents)

[Intel® Rapid Storage Technology (Intel® RST)](https://www.intel.com/content/www/us/en/download/15667/intel-rapid-storage-technology-intel-rst-user-interface-and-driver.html) is a Windows-based application that provides improved performance, reliability, and lower power consumption for supported systems equipped with Serial ATA (SATA) devices, Serial Attached SCSI (SAS) devices, and/or solid state drives (SSDs) to enable an optimal storage solution for desktop, mobile, and server platforms.

**Intel RST Features:**

   * System acceleration with Intel® Optane™ memory
   * Configuration and maintenance of RAID 0/1/5/10   
   
<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/207818674-4512e8cf-8c3a-45cd-ae96-f882e30c289a.png">
  </br>
 
</p>

## Setting up OBS Studio

[Back to the Top](#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/185703842-0926e10a-467a-471c-b5f6-b74df4e460d9.png">
  <br />
</p>

[OBS (Open Broadcaster Software)](https://obsproject.com/) is free and open source software for video recording and live streaming. Stream to Twitch, YouTube and many other providers or record your own videos with high quality H264 / AAC encoding. Starting with [OBS Studio version 28](https://projectobs.com/en/news/obs-studio-28-0/) it will feature 10-bit and HDR video encode support for [AV1](https://aomedia.org/av1-features/) and [HEVC](https://apps.apple.com/us/app/hevc/id768692338), improved AMD encoding on Windows, [NVIDIA RTX software](https://blogs.nvidia.com/blog/2022/08/31/in-the-nvidia-studio-august-31/) integration, a new default theme, and many other changes.
 
 <p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/185704748-217443ac-57e3-4ab3-ba74-6d09c2fe62fb.png">
  <br />
  OBS Studio
</p>
 
 ### Useful OBS Studio 3rd party plugins and themes.
 
  * **[OBS Studio Themes](https://obsproject.com/forum/resources/categories/themes.10/)**
 
  * **[touch portal icon packs](https://www.touch-portal.com/assetsdb/show-all.php?cat=i)**
 
  * **[Streamlink](https://streamlink.github.io/)** is a CLI utility which pipes video streams from various services into a video player, such as VLC.  

  * **[Advanced Scene Switcher](https://github.com/WarmUpTill/SceneSwitcher)** plugin; an automated scene switcher.
  * **[Audio Pan](https://github.com/norihiro/obs-audio-pan-filter)** plugin; control stereo pan of audio source.
  * **[Browser](https://github.com/obsproject/obs-browser)** plugin; CEF-based OBS Studio browser plugin.
  * **[Directory Watch Media](https://github.com/exeldro/obs-dir-watch-media)** plugin; filter you can add to media source to load the oldest or newest file in a directory.
  * **[Downstream Keyer](https://github.com/exeldro/obs-downstream-keyer)** plugin; add a Downstream Keyer dock.
  * **[Dynamic Delay](https://github.com/exeldro/obs-dynamic-delay)** plugin; filter for dynamic delaying a video source.
  * **[Freeze Filter](https://github.com/exeldro/obs-freeze-filter)** plugin; freeze a source using a filter.
  * **[Gradient Source](https://github.com/exeldro/obs-gradient-source)** plugin; adding gradients as a Soource.
  * **[GStreamer](https://github.com/fzwoch/obs-gstreamer)** plugins; feed GStreamer launch pipelines into OBS Studio and use GStreamer encoder elements.
  * **[Move Transition](https://github.com/exeldro/obs-move-transition)** plugin; move source to a new position during scene transition.
  * **[Multi Source Effect](https://github.com/norihiro/obs-multisource-effect)** plugin; provides a custom effect to render multiple sources.
  * **[NDI](https://github.com/Palakis/obs-ndi)** plugin; Network A/V via NewTek's NDI.
  * **[NvFBC](https://gitlab.com/fzwoch/obs-nvfbc)** plugin; screen capture via NVIDIA FBC API. Requires [NvFBC patches for Nvidia drivers](https://github.com/keylase/nvidia-patch) for consumer grade GPUs.
  * **[Soundboard](https://github.com/cg2121/obs-soundboard)** plugin; adds a soundboard dock.
  * **[Source Copy](https://github.com/exeldro/obs-source-copy)** plugin; adds copy and paste options to the tools menu.
  * **[Source Dock](https://github.com/exeldro/obs-source-dock)** plugin; create a Dock for a source, which lets you see audio levels, change volume and control media. 
  * **[Recursion Effect](https://github.com/exeldro/obs-recursion-effect)** plugin; recursion effect filter.
  * **[Replay Source](https://github.com/exeldro/obs-replay-source)** plugin; slow motion replay async sources from memory.
  * **[RGB Levels](https://github.com/petrifiedpenguin/obs-rgb-levels-filter)** plugin; simple filter to adjust RGB levels.
  * **[RTSPServer](https://github.com/iamscottxu/obs-rtspserver/)** plugin; encode and publish to a RTSP stream.
  * **[Scale to Sound](https://github.com/Qufyy/obs-scale-to-sound)** plugin; adds a filter which makes a source scale based on the audio levels of any audio source you choose
  * **[Scene Collection Manager](https://github.com/exeldro/obs-scene-collection-manager)** plugin; filter, backup and restore Scene Collections.
  * **[Scene Notes Dock](https://github.com/exeldro/obs-scene-notes-dock)** plugin; create a Dock for showing and editing notes for the current active scene.
  * **[Source Record](https://github.com/exeldro/obs-source-record)** plugin; make sources available to record via a filter.
  * **[Source Switcher](https://github.com/exeldro/obs-source-switcher)** plugin; to switch between a list of sources.
  * **[Spectralizer](https://github.com/univrsal/spectralizer)** plugin; audio visualization using fftw.
  * **[StreamFX](https://github.com/Xaymar/obs-StreamFX)** plugin; collection modern effects filters and transitions.
  * **[Teleport](https://github.com/fzwoch/obs-teleport)** plugin; open NDI-like replacement.
  * **[Text Pango](https://github.com/kkartaltepe/obs-text-pango)** plugin; Provides a text source rendered using Pango with multi-language support, emoji support, vertical rendering and RTL support.
  * **[Text PThread](https://github.com/norihiro/obs-text-pthread)** plugin; Rich text source plugin with many advanced features.
  * **[Time Warp Scan](https://github.com/exeldro/obs-time-warp-scan)** plugin; a time warp scan filter.
  * **[Transition Table](https://github.com/exeldro/obs-transition-table)** plugin; customize scene transitions.
  * **[Virtual Cam Filter](https://github.com/exeldro/obs-virtual-cam-filter)** plugin; make sources available to the virtual camera via a filter
  * **[VNC Source](https://github.com/norihiro/obs-vnc)** plugin; VNC viewer that works as a source.
  * **[Websockets](https://github.com/Palakis/obs-websocket)** plugin; remote-control OBS Studio through WebSockets, compatible with [StreamControl](https://play.google.com/store/apps/details?id=dev.t4ils.obs_remote&hl=en).
  
## Discord

[Back to the Top](#table-of-contents)

[Discord](https://discord.com/) is an application with modern voice & text chat app. It provides clear voice, multiple server and channel support, mobile apps, and more. It's available on Linux, macOS, Windows, iOS, Android, and your web browser.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/203752975-d489f776-2039-474d-82ce-1cdd3dcdeff7.png">
</p>

## Twitch

[Back to the Top](#table-of-contents)

[Twitch Studio Beta](https://www.twitch.tv/broadcast/studio) is a free streaming software designed for new streamers to create content and share it with a community.

[Twitch](https://www.microsoft.com/en-us/p/twitch/9pfjp1q9r4fk#activetab=pivot:overviewtab) is an application where thousands of communities come together for our favorite streamers join millions enjoying live games, music, sports, esports, podcasts, cooking shows, IRL streams, etc..

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/203753175-0aaea65d-013e-4a4e-b67d-19a6ca52ff56.png">
</p>

## Game Stores & Launchers

### Steam
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

[Get Steam](https://store.steampowered.com/about/)

 <img src="https://user-images.githubusercontent.com/45159366/106686402-13100100-657f-11eb-9012-6bdac264a808.png">

[Steam Link app](https://store.steampowered.com/steamlink/about) is available free of charge, streaming your Steam PC games to phones, tablets, and TV.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/112692999-14ea9800-8e3d-11eb-964a-6bee4e665900.png">
</p>

### Playnite

[Back to the Top](#table-of-contents)

[Playnite](https://playnite.link/) is an open source video game library manager and launcher with support for 3rd party libraries like Steam, GOG, Origin, Battle.net and Ubisoft Connect. Includes game emulation support, providing one unified interface for your games.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208235743-4521f909-f26c-4eb1-b259-0b06e9e1d380.png">
</p>

### Launchbox

[Back to the Top](#table-of-contents)

[Launchbox](https://www.launchbox-app.com/) is a video game library manager and launcher that lets you Emulate, Organize, and Beautify Your Game Collection.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208235744-614ff162-2de6-404e-9981-bca2c26976a0.jpg">
</p>

### Razor Cortex

[Back to the Top](#table-of-contents)

[Razer Cortex](https://www.razer.com/cortex/launcher) is a video game library manager and launcher that lets you all your games across different platforms, including Steam, Origin, GOG Galaxy, and Ubisoft Connect.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/208235752-47600055-722b-437f-b465-b23ae09fbf71.png">
</p>

### Epic Games Store
[Back to the Top](#table-of-contents)

[Heroic Game Launcher](https://heroicgameslauncher.com/) is an Open Source Game Launcher for Linux, Windows and MacOS (for both Native and Windows Games using Crossover). It supports launching games from the Epic Games Store using Legendary, a CLI alternative to the Epic Games Launcher. 

[Epic Games Store](https://www.epicgames.com/store/) is a digital video game storefront for Microsoft Windows and macOS, operated by Epic Games.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/111918016-3fed7a00-8a40-11eb-964e-930c801c1c72.png">
</p>

### Blizzard Battle.net 

[Back to the Top](#table-of-contents)

[Blizzard Battle.net](https://www.blizzard.com/apps/battle.net/desktop) is an internet-based online gaming, digital distribution, and digital rights management platform developed by Activision and Blizzard Entertainment. Battle.net is the launcher for World of Warcraft, Diablo III, StarCraft II, Hearthstone, Heroes of the Storm, Overwatch and Call of Duty.

<img src="https://user-images.githubusercontent.com/45159366/189614458-d51a15cb-d02d-4b1f-9e77-e712dcdb1d73.png">

### Origin 

[Back to the Top](#table-of-contents)
 
[Origin](https://www.ea.com/games/library/pc-download) is an online gaming, digital distribution and digital rights management (DRM) platform developed by Electronic Arts that allows users to purchase games on the internet for PC and mobile platforms, and download them with the Origin client (formerly EA Download Manager, EA Downloader and EA Link).

<img src="https://user-images.githubusercontent.com/45159366/189614468-49c4a05c-d6ca-4988-b3e6-10f0c71463d6.png">

### EA Play 

[Back to the Top](#table-of-contents)

[EA Play](https://www.ea.com/ea-play) is a subscription-based video game service from Electronic Arts for the Xbox One, Xbox Series X/S, PlayStation 4, PlayStation 5 and Microsoft Windows platforms, offering access to selected games published by Electronic Arts along with additional incentives.

* **Note:** you will need to install [Origin](https://www.ea.com/games/library/pc-download) to access all EA game titles for EA Play even if you use **EA Play on Steam**.

<img src="https://user-images.githubusercontent.com/45159366/189614466-476e0c4e-bab9-44bd-86c4-8aeadd739b63.png">

### Ubisoft Connect 

[Back to the Top](#table-of-contents)

[Ubisoft Connect](https://ubisoftconnect.com/) is a digital distribution, digital rights management, multiplayer and communications service created by Ubisoft to provide an experience similar to the achievements/trophies offered by various other game companies.

<img src="https://user-images.githubusercontent.com/45159366/189614471-422cbad8-1ae7-4f06-ad81-7f3b68550569.png">

### Rockstar Games

[Back to the Top](#table-of-contents)

[Rockstar Games Launcher](https://socialclub.rockstargames.com/rockstar-games-launcher) is a game launcher for downloading and playing the latest Rockstar Games PC titles.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/209026675-1073e542-b0b2-4370-b446-61954599578d.png">
</p>

### GOG Galaxy

[Back to the Top](#table-of-contents)

[GOG Galaxy](https://www.gog.com/galaxy) is an application that lets you combine multiple game libraries into one place and connect with your friends across all gaming platforms, consoles included.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/200258282-da3cd773-c1c9-46d9-af12-aa54428be4ec.png">
</p>

### Itch.io Store

[Back to the Top](#table-of-contents)

[Itch.io Store](https://itch.io/app) is an app that lets you effortlessly download and run games and software from itch.io. All of your downloads are kept in a single place and are automatically updated.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/199429576-278a8604-7f76-4a41-abeb-84d03865daeb.png">
</p>

### Prism

[Back to the Top](#table-of-contents)

[Prism Launcher for Minecraft](https://prismlauncher.org/) is an Open Source Minecraft launcher with the ability to manage multiple instances, accounts and mods. 

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/209223630-4ae7df57-9561-411c-9be8-ea7cd76f266a.png">
</p>

## Game Streaming
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

### Cloud Game Streaming

[Back to the Top](#table-of-contents)

[Xbox Cloud Gaming](https://www.xbox.com/en-US/xbox-game-pass/cloud-gaming) is Microsoft's cloud-based Xbox game-streaming technology **(currently in Beta)**. **Play games like Forza Horizon 4, Halo 5: Guardians, Gears of War 4, Sea of Thieves, Cuphead, Red Dead Redemption 2, and 100+ other games on your mobile device or Chrome web browser**. Xbox Cloud Gaming does require an **[Xbox Game Pass Ultimate](https://www.xbox.com/en-US/xbox-game-pass/cloud-gaming)** subscription.

<img src="https://user-images.githubusercontent.com/45159366/108111388-74d56e00-7049-11eb-8aeb-3e5d65f9e832.png">

[Geforce NOW](https://www.nvidia.com/en-us/geforce-now/download/) is NVIDIA's Cloud Gaming Service.

<img src="https://user-images.githubusercontent.com/45159366/106686391-0f7c7a00-657f-11eb-9d0b-1ebb4d385883.jpeg">

[Amazon Luna](https://www.amazon.com/luna/landing-page) is Amazon's Cloud Gaming Service. Amazon Luna is Compatible/Supported on a vartiey of [Devices and Browsers](https://www.amazon.com/gp/help/customer/display.html?nodeId=GUFHUSX8X324T4XE).

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/112693072-364b8400-8e3d-11eb-9df0-d58af7ac9c9c.png">
</p>

[Shadow](https://shadow.tech/) is a fully-featured, cloud-based, high-end computer. It is the only remote service that offers performance capable of competing with a local PC. Available on Windows, macOS, Linux, Android/AndroidTV, and iOS/tvOS.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/200110962-dd631248-7a13-48bb-9b5a-acbbf8550e16.png">
</p>

### Local Game Streaming

[Back to the Top](#table-of-contents)

[Steam Remote Play Together](https://store.steampowered.com/remoteplay/#together) is a steam service that let's you share your Steam local multi-player games with friends over the internet, for free. Using Remote Play Together, one player owns and runs the game, then up to four players can join.

[Steam Link app](https://store.steampowered.com/steamlink/about) is available free of charge, streaming your Steam PC games to phones, tablets, and TV.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/112692999-14ea9800-8e3d-11eb-964a-6bee4e665900.png">
</p>


[PlayStation Remote Play](https://www.playstation.com/en-us/support/games/playstation-remote-play-on-pc-and-mac/) is a feature available on all PS4 and PS5 consoles that let's you control your PlayStation® console remotely wherever you have a high-speed internet connection. 

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/172946885-27f83bdf-ab1a-4eaa-ad33-0e108f92a981.png">
</p>


[Chiaki](https://git.sr.ht/~thestr4ng3r/chiaki) is a Free and Open Source Software Client for **PlayStation 4 and PlayStation 5 Remote Play** for Linux, FreeBSD, OpenBSD, Android, macOS, Windows, Nintendo Switch and potentially even more platforms. 

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/208854787-3442b9df-60bc-4ed2-87e3-efaa159a6b7f.png">
</p>

[Parsec](https://parsec.app/cloud-gaming) is a video game streaming platform, which offers a wide variety of games and genres to choose from and provides a high-quality and smooth gameplay. SParsec is developed in order to provide a high-quality smooth gameplay, same time to be free of all ads and in-game purchases.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/166166858-e70ca081-8931-46f3-9dc3-fe9c719d76f8.png">
</p>

[Moonlight Game Streaming](https://moonlight-stream.org/) is a program that let you stream from your PC games over the Internet with no configuration required. Stream from almost any device, whether you're in another room or miles away from your gaming rig. [Sunshine](https://github.com/LizardByte/Sunshine) is a **Game stream host for Moonlight** that is a self-hosted, low latency, cloud gaming solution with support for AMD, Intel, and NVIDIA GPUs.

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/106686398-11463d80-657f-11eb-841a-d534829ccc3d.png">
</p>

## Game Emulators
[Back to the Top](#table-of-contents)

**Also checkout these subreddits for more great Game Emulators recommendations**
  
   - [r/emulation](https://www.reddit.com/r/emulation/)
   - [r/emulations](https://www.reddit.com/r/emulators/)
   - [r/RetroArch](https://www.reddit.com/r/RetroArch/)
   - [r/DolphinEmulator](https://www.reddit.com/r/DolphinEmulator/)
   - [r/Citra](https://www.reddit.com/r/Citra/)
   - [r/cemu](https://www.reddit.com/r/cemu/)
   - [r/yuzu](https://www.reddit.com/r/yuzu/)
   - [r/OpenEmu](https://www.reddit.com/r/OpenEmu/)
   - [r/MAME](https://www.reddit.com/r/MAME/)
   - [r/EmuDev](https://www.reddit.com/r/EmuDev/)
   - [r/Roms](https://www.reddit.com/r/Roms/)

### Frontends

[EmulationStation Desktop Edition (ES-DE)](https://www.es-de.org/) is a frontend application for browsing and launching games from your multi-platform game collection. It's  available for Unix/Linux, macOS(M1 & Intel) and Windows.

[RetroArch](https://www.retroarch.com/) is a frontend for emulators, game engines and media players. It enables you to run classic games on a wide range of computers and consoles through its slick graphical interface. Settings are also unified so configuration is done once and for all.

[Pegasus](https://pegasus-frontend.org/) is a cross platform, customizable graphical frontend for launching emulators and managing your game library (especially retro games) and launching them from one place. It's focused on customizability, cross platform support (including embedded devices) and high performance.

[Mednaffe](https://github.com/AmatCoder/mednaffe) is a front-end (GUI) for mednafen emulator which is a portable argument(command-line)-driven multi-system emulator. *

**The following systems are supported:**

  * Atari Lynx
  * Neo Geo Pocket (Color)
  * WonderSwan
  * GameBoy (Color)
  * GameBoy Advance
  * Nintendo Entertainment System
  * Super Nintendo Entertainment System/Super Famicom
  * Virtual Boy
  * PC Engine/TurboGrafx 16 (CD)
  * SuperGrafx
  * PC-FX
  * Sega Game Gear
  * Sega Genesis/Megadrive
  * Sega Master System
  * Sega Saturn (experimental, x86_64 only)
  * Sony PlayStation

[Cartridge](https://github.com/unclebacon-live/cartridge) is a self-hosted game library made with Laravel + Vue.js.

Cartridge Features

- Scan for ROM files and match with IGDB game information
- Serve ROM download links alongside game details
- Manage access to library with user creation and permissions (WIP)
- Allow users to request games (Planned)
- Play select ROMs in-browser using JS emulators (Planned)
- Track played and favorite games (even ones that aren't available for download) (Planned)

<p align="center">
  <img src="https://user-images.githubusercontent.com/45159366/172274231-d691a850-1879-44fb-8fa0-08e549d7bb29.png">
    <br />
      Cartridge UI
</p>

### Nintendo GameCube & Wii

[Dolphin](https://dolphin-emu.org) is an emulator for two recent Nintendo video game consoles: the GameCube and the Wii. It allows PC gamers to enjoy games for these two consoles in full HD (1080p) with several enhancements: compatibility with all PC controllers, turbo speed, networked multiplayer, and even more.

### Nintendo Switch 

[Ryujinx](https://ryujinx.org/) is an open-source Nintendo Switch emulator created by gdkchan and written in C#. This emulator aims at providing excellent accuracy and performance, a user-friendly interface, and consistent builds. 

[yuzu](https://yuzu-emu.org) is an experimental open-source emulator for the Nintendo Switch from the creators of Citra. 

### Nintendo 64

[m64p](https://m64p.github.io/) is a Nintendo 64 Emulator. It uses mupen64plus-gui, a brand new mupen64plus frontend written in Qt5. It supports all of the things you’d expect from a frontend (savestate management, pausing, screenshots). 

[simple64](https://github.com/simple64/simple64) is an emulator based on a heavily modified version of mupen64plus-core, and ParaLLEl RSP/RDP. It includes a GUI, netplay, controller configuration, and  more. *

Nintendo 3DS

[Citra](https://citra-emu.org/) is an open-source emulator for the Nintendo 3DS capable of playing many of your favorite games.

### Nintendo DS

[DeSmuME](https://desmume.org/) is a Nintendo DS emulator.

[melonDS](https://github.com/melonDS-emu/melonDS) is a tool that aims at providing fast and accurate Nintendo DS emulation. While it is still a work in progress, it has a pretty solid set of features.

**Features:**

    * Nearly complete core (CPU, video, audio, etc...)
    * OpenGL renderer, 3D upscaling
    * RTC, microphone, lid close/open
    * Joystick support
    * Savestates
    * Various display position/sizing/rotations modes
    * Work-in-progress Wi-Fi emulation for online connectivity and local multiplayer
    * Experimental emulation of the Nintendo DSi

### Super Nintendo Entertainment System (SNES)

[Snes9x](https://www.snes9x.com/) is a portable, freeware Super Nintendo Entertainment System (SNES) emulator. 

[bsnes](https://github.com/bsnes-emu/bsnes) is a Super Nintendo (SNES) emulator focused on performance, features, and ease of use.

### Nintendo Entertainment System  

[Nestopia](https://github.com/0ldsk00l/nestopia) is a portable NES/Famicom emulator written in C++. *

### Game Boy Advance

[mGBA](https://mgba.io/) is a new emulator for running Game Boy Advance games. It aims to be faster and more accurate than many existing Game Boy Advance emulators, as well as adding features that other emulators lack.

### DOS 

[DOSBox](https://www.dosbox.com/) is an open-source DOS emulator which primarily focuses on running DOS Games.

[DOSBox Staging](https://github.com/dosbox-staging/dosbox-staging) is a full x86 CPU emulator (independent of host architecture), capable of running DOS programs that require real or protected mode.

### Atari

[Stella](https://stella-emu.github.io/) is a multi-platform Atari 2600 VCS emulator released under the GNU General Public License (GPL). Stella is available on Windows MacOS, Linux, and FreeBSD.

[Hatari](https://hatari.tuxfamily.org/) is an Atari ST/STE/TT/Falcon emulator for Linux, BSD, MacOS, Windows and other systems which are supported by the SDL library. The Atari ST was a 16/32 bit computer system which was first released by Atari in 1985. 

### Sega Dreamcast

[Flycast](https://github.com/flyinghead/flycast) is a multi-platform Sega Dreamcast, Naomi and Atomiswave emulator derived from reicast.

### PlayStation Portable

[PPSSPP](https://www.ppsspp.org/) is a PSP emulator that can run games in full HD resolution. It can even upscale textures that would otherwise be too blurry as they were made for the small screen of the original PSP.

### PlayStation 1

[DuckStation](https://www.duckstation.org/) is an simulator/emulator of the Sony PlayStation 1 console, focusing on playability, speed, and long-term maintainability.

### PlayStation 2

[PCSX2](https://pcsx2.net/) is a Playstation 2 'emulator', a free program that tries to replicate the Playstation 2 console to enable you to play PS2 games on your PC.

[Play!](https://github.com/jpd002/Play-) is a PlayStation2 emulator for Windows, macOS, UNIX, Android, iOS and web browser platforms.

### PlayStation 3

[RPCS3](https://rpcs3.net/) is an experimental open-source Sony PlayStation 3 emulator and debugger written in C++ for Windows and Linux. RPCS3 started development in May of 2011 by its founders DH and Hykem. The emulator is currently capable of running over 1800 commercial titles powered by Vulkan and OpenGL.

### Xbox

[xemu](https://xemu.app/) is an original Xbox emulator.

[Xenia](https://github.com/xenia-project/xenia) is an Xbox 360 Emulator.

### MAME

[MAME](https://www.mamedev.org/) is a Arcade Machine Emulator.

## Performance Benchmarks
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

[Geekbench 5](https://www.geekbench.com/download/) is a cross-platform benchmark that measures your system's performance with the press of a button.

[Phoronix Test Suite](https://www.phoronix-test-suite.com/)

[UNIGINE Superposition](https://benchmark.unigine.com/superposition) is an extreme performance and stability test for PC hardware: video card, power supply, cooling system.

<img src="https://user-images.githubusercontent.com/45159366/107092007-8f8d2480-67b7-11eb-9c3f-a0cb02e6dfcd.png">

## Windows Subsystem for Android (WSA)

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[Windows Subsystem for Android (WSA)](https://docs.microsoft.com/en-us/windows/android/wsa/) is a tool that allows your device to run Android apps natively in Windows 11. This article explains how to set up WSA in Windows 11 to Run Android Apps. WSA runs as a virtual machine using [Hyper-V](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/) and is based on [AOSP](https://source.android.com/) version 11. 

As of now, WSA has some specific requirements. With time, some pre-requisites like Region would be eased. See the following requirements below:

   - Your Device must be running Build 22000 or later meeting the requirements for Windows 11, including supported processors.

   - The Computer must support virtualization and be enabled in BIOS/UEFI and Optional Features.

   - The device must have at least 8GB of RAM and SSD as a Storage device. For WSA, a Hard drive is not supported.

   - The Store version must be 22110.1402.6.0 or higher. Go to Store Library to update.

   - The PC's Region and Amazon account you plan to use must be US-based.

   - Your PC must be in Windows Insider Program Beta Channel.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/167318108-d9cbaae2-d247-4fe5-ba8f-86b288afe151.png">
</p>

   
### Getting started with Windows Subsystem for Android

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

   - Open the Amazon App store from this [link](http://aka.ms/AmazonAppstore).

   - Click Install. It would download Amazon AppStore and Windows subsystem for Android.

   - When done, you would see the Windows subsystem for Android on your app list, together with Amazon AppStore.

  -  Open the Amazon AppStore, and sign in with your US-based Amazon Account on the screen that shows.

   - Locate your App in the catalogue and click Install.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/167318107-f68ac6d8-7aa2-468c-8dca-70683e2f6e78.png">
</p>

### Windows Subsystem for Android Settings

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

There are also a bunch of Android Settings you can customize as well, which are as under.

 - Files show the files which Apps download to the Device.

 - Subsystem Screen reader helps accessibility wise, like screen reading on in Android apps you plan to run.

 - Developer mode helps you to sideload an APK file manually using ADB.Checkout this [YouTube video](https://www.youtube.com/watch?v=2_LxsWa7JIg).
 
 - If the Subsystem is selected As needed, no resources are used in the Background, so as a result, apps open slowly. If a continuous option is selected, resources continue to be used in the Background, and Apps open quickly.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/167318112-3b53ebce-5fa4-421c-9df6-d2fe35ec38fe.png">
</p>

### WSA Toolbox
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[WSA Toolbox](https://github.com/voletro/wsa-toolbox) is a Windows 11 application to easily install and use the Windows Subsystem For Android™ package on your computer. 

These tools include:

   - Installation of any APK file in one click.
   - Access to the ADB Shell.
   - Installation of Windows Subsystem For Android™ in unsupported regions.
   - Installation of the Aurora Store as an alternative to the Google Play Store.
   - Installation of a simple app launcher for easy access to other apps.
   - Installation of any APK file by just double clicking on it.

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/172274651-7a96a450-edf1-4f8d-86ba-574456962c6d.png">
</p>

# Windows Subsystem for Linux (WSL)

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/146082215-7d80b8b7-4da6-4280-900d-4ce4cd30df7e.png">
</p>

<img src="https://user-images.githubusercontent.com/45159366/107585931-e6c63700-6bb3-11eb-8f25-f07f8ff05688.png">


## WSL Learning Resources
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[WSL 2 Linux Kernel on GitHub](https://github.com/microsoft/WSL2-Linux-Kernel) is the source for the Linux kernel used in Windows Subsystem for Linux 2 (WSL2).

[WSLConf](https://www.youtube.com/playlist?list=PLwFSk464RMxnZkvZ1HKrlNyj-s6Zq4fWe) is a community-initiated event on all things Windows Subsystem for Linux and WSL-related.

[What is the Windows Subsystem for Linux?](https://docs.microsoft.com/en-us/windows/wsl/about)

[Pro Windows Subsystem for Linux (WSL): Powerful Tools and Practices for Cross-Platform Development and Collaboration Book](https://www.amazon.com/Windows-Subsystem-Linux-Cross-Platform-Collaboration/dp/1484268725/ref=sr_1_1?dchild=1&keywords=Pro+Windows+Subsystem+for+Linux+%28WSL%29&qid=1614379171&s=digital-text&sr=1-1-catcorr)

[Windows Subsystem for Linux 2 (WSL 2) Tips, Tricks, and Techniques Book](https://www.amazon.com/Windows-Subsystem-Linux-Tricks-Techniques-ebook/dp/B08K98C7DB/ref=sr_1_1?dchild=1&keywords=WSL+book&qid=1614379053&s=digital-text&sr=1-1)

[Comparing WSL 2 and WSL 1 ](https://docs.microsoft.com/en-us/windows/wsl/compare-versions)

[GPU accelerated machine learning training in the Windows Subsystem for Linux](https://docs.microsoft.com/en-us/windows/wsl/tutorials/gpu-compute)

[CUDA on Windows Subsystem for Linux(WSL) 2](https://developer.nvidia.com/blog/announcing-cuda-on-windows-subsystem-for-linux-2/)

[Developing in Windows Subsystem for Linux (WSL)](https://code.visualstudio.com/docs/remote/wsl)

[Using WSL 2 with Visual Studio Code](https://code.visualstudio.com/blogs/2019/09/03/wsl2)

[WSLG: X11 and Wayland Applications in WSL](https://linuxplumbersconf.org/event/9/contributions/611/attachments/702/1298/XDC2020_-_X11_and_Wayland_applications_in_WSL.pdf)

[How to run Podman on Windows with WSL 2](https://www.redhat.com/sysadmin/podman-windows-wsl2)

[Create a development container in Visual Studio Code](https://code.visualstudio.com/docs/remote/create-dev-container)

[Getting started with MySQL, MongoDB, PostgreSQL, SQLite, Microsoft SQL Server, or Redis to set up a database on WSL](https://docs.microsoft.com/en-us/windows/wsl/tutorials/wsl-database)

[Setting up SAP HANA, express edition into WSL 2 (Windows Subsystem for Linux)](https://blogs.sap.com/2020/09/30/installing-sap-hana-express-edition-into-wsl2-windows-subsystem-for-linux/)

[Set up your Node.js development environment with WSL 2](https://docs.microsoft.com/en-us/windows/nodejs/setup-on-wsl2)

[Getting started mounting a Linux disk in WSL 2](https://docs.microsoft.com/en-us/windows/nodejs/setup-on-wsl2)

[Using Fedora with Microsoft's WSL 2](https://fedoramagazine.org/wsl-fedora-33/)

## WSL Tools & Projects
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[wslu](https://github.com/wslutilities/wslu) is a collection of utilities for Windows 10 Linux Subsystem, such as retrieving Windows 10 environment variables or creating your favorite Linux GUI application shortcuts on Windows 10 Desktop.

[Ubuntu on WSL](https://wiki.ubuntu.com/WSL) is a wiki guide on getting started with the latest version of Ubuntu installed and setup on WSL for Windows 10.

[Ubuntu on Windows Community Preview](https://www.microsoft.com/en-us/p/ubuntu-on-windows-community-preview/9p9q5zh1hrr0) is a special build of Ubuntu for WSL as a sandbox for testing new features and getting community feedback. This build is intended for early adopters in the WSL community.

[Ubuntu Pro for Azure](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/canonical.0001-com-ubuntu-pro-focal?tab=Overview) is a premium image designed by Canonical optimized for production environments running on Azure. It includes security and compliance services, enabled by default, in a form suitable for small to large-scale Linux enterprise operations — with no contract needed.

[Azure CLI](https://docs.microsoft.com/en-us/cli/azure/?view=azure-cli-latest) is a set of commands used to create and manage Azure resources. The Azure CLI is available across Azure services and is designed to get you working quickly with Azure, with an emphasis on automation.

[Visual Studio Code Remote - WSL extension](https://code.visualstudio.com/docs/remote/wsl) lets you use the Windows Subsystem for Linux (WSL) as your full-time development environment right from VS Code. You can develop in a Linux-based environment, use Linux-specific toolchains and utilities, and run and debug your Linux-based applications all from the comfort of Windows. The extension runs commands and other extensions directly in WSL so you can edit files located in WSL or the mounted Windows filesystem (for example /mnt/c) without worrying about pathing issues, binary compatibility, or other cross-OS challenges.

[Visual Studio Code Remote Development and GitHub Codespaces](https://github.com/Microsoft/vscode-dev-containers) is a  repository of development container definitions for the VS Code Remote - Containers extension and GitHub Codespaces. A development container is a running [Docker](https://www.docker.com/) container with a well-defined tool/runtime stack and its prerequisites. The [VS Code Remote Containers](https://aka.ms/vscode-remote/download/containers) extension allows you to clone a repository or open any folder mounted into (or already inside) a dev container and take advantage of VS Code's full development feature set. [GitHub Codespaces](https://github.com/features/codespaces) both use this same concept to quickly create customized, cloud-based development environments accessible from VS Code or the web.

[Windows Terminal](https://github.com/microsoft/terminal) is a new, modern, feature-rich, productive terminal application for command-line users. It includes many of the features most frequently requested by the Windows command-line community including support for tabs, rich text, globalization, configurability, theming & styling, and more.

[PowerShell Core](https://github.com/PowerShell/PowerShell) is a cross-platform (Windows, Linux, and macOS) automation and configuration tool/framework that works well with your existing tools and is optimized for dealing with structured data (e.g. JSON, CSV, XML, etc.), REST APIs, and object models. It includes a command-line shell, an associated scripting language and a framework for processing cmdlets.

[Docker Desktop WSL 2 backend](https://docs.docker.com/docker-for-windows/wsl/) creates an  architectural change that gvies a full Linux kernel built by Microsoft, allowing Linux containers to run natively without emulation. With Docker Desktop running on WSL 2, users can leverage Linux workspaces and avoid having to maintain both Linux and Windows build scripts. In addition, WSL 2 provides improvements to file system sharing, boot time, and allows access to some cool new features for Docker Desktop users.

[Dxgkrnl](https://devblogs.microsoft.com/directx/directx-heart-linux/) is a brand-new kernel driver for Linux that exposes the /dev/dxg device to user mode Linux. /dev/dxg exposes a set of IOCTL that closely mimic the native WDDM D3DKMT kernel service layer on Windows. Dxgkrnl inside of the Linux kernel connects over the VM Bus to its big brother on the Windows host and uses this VM bus connection to communicate with the physical GPU.

[Ansible-WSL](https://github.com/Wintus/Ansible-WSL) is an open source program that makes it easier to provision your Windows from inside of WSL by Ansible.

[WSL-DistroLauncher](https://github.com/Microsoft/WSL-DistroLauncher) is a sample/reference launcher app for WSL distro Microsoft Store packages.

[Pengwin](https://github.com/WhitewaterFoundry/Pengwin) is a Linux distro optimized for WSL based on Debian.

[Pengwin Enterprise](https://github.com/WhitewaterFoundry/Pengwin-Enterprise) is an enterprise Linux solution for Windows Subsystem for Linux (WSL) that is compatible with mainstream enterprise Linux distributions.


## Setting up WSL Linux Distributions
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

**Requirements**

Before you install any of the Linux Distributions make sure to install/enable the Windows Subsystem for Linux on your Windows 10 machine. Following the instructions below:

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/110054829-ad936980-7d10-11eb-80bd-bc5e96d31d27.png">
<br />
Installing Windows Subsystem Linux
</p>

**OR**

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/109565559-7fefbb80-7a97-11eb-8502-4d8f2eeb4842.png">
 </p>

**For more technical users you run this command in Powershell:**

```sh
Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux
```

[Ubuntu 20.04 LTS](https://www.microsoft.com/en-us/p/ubuntu-2004-lts/9n6svws3rx71?activetab=pivot:overviewtab)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563752-0eaf0900-7a95-11eb-9fd7-9be123b57cc1.png">
</p>


[Debian](https://www.microsoft.com/en-us/p/debian/9msvkqc78pk6?activetab=pivot:overviewtab)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563781-14a4ea00-7a95-11eb-8008-61867e38cf1e.png">
</p>

[Fedora for WSL](https://fedoramagazine.org/wsl-fedora-33/)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563789-15d61700-7a95-11eb-9c99-c1e68ead8388.png">
</p>

[SUSE Linux Enterprise Server 15 SP1](https://www.microsoft.com/en-us/p/suse-linux-enterprise-server-15-sp1/9pn498vpmf3z?activetab=pivot:overviewtab)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563809-1bcbf800-7a95-11eb-8be7-e94b2feb74a7.png">
</p>


[openSUSE Leap 15.2](https://www.microsoft.com/en-us/p/opensuse-leap-152/9mzd0n9z4m4h?activetab=pivot:overviewtab)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563802-1a9acb00-7a95-11eb-9c6a-14bbcde765dd.png">
</p>

[Kali Linux](https://www.microsoft.com/en-us/p/kali-linux/9pkr34tncv07?activetab=pivot:overviewtab)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563822-1ec6e880-7a95-11eb-8d4b-a051178da3e2.png">
</p>

[Pengwin](https://www.microsoft.com/en-us/p/pengwin/9nv1gv1pxz6p?activetab=pivot:overviewtab)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563833-225a6f80-7a95-11eb-93e8-f40799469bcc.png">
</p>


[Fedora Remix for WSL](https://www.microsoft.com/en-us/p/fedora-remix-for-wsl/9n6gdm4k2hnc?activetab=pivot:overviewtab)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563839-238b9c80-7a95-11eb-8a41-fc9775c810bb.png">
</p>


[GWSL](https://www.microsoft.com/en-us/p/gwsl/9nl6kd1h33v3?activetab=pivot:overviewtab) is an XServer that lets you easily run graphical Linux apps on Windows 10.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/109563870-2e463180-7a95-11eb-93b1-77c1ff0ef39d.png">
</p>

# Windows Terminal

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/143783124-dd11fd52-acd5-4e43-9f0e-e456e2efc303.png">
  <br />
</p>

[Windows Terminal](https://github.com/microsoft/terminal) is a new, modern, feature-rich, productive terminal application for command-line users. It includes many of the features most frequently requested by the Windows command-line community including support for tabs, rich text, globalization, configurability, theming & styling, and more. Take a look at the [Windows Terminal GitHub](https://github.com/Microsoft/Terminal).

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/143783143-265c9c5c-bc33-4742-99a5-655ed2a07150.png">
  <br />
  Windows Terminal
</p>

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/143783144-72ce368a-5c46-48a7-b57b-60e0f7d26a0b.png">
  <br />
  Terminal Architecture
</p>

[Git for Windows](https://gitforwindows.org) is a distributed version control system tool that focuses on offering a lightweight, native set of tools that bring the full feature set of the Git SCM to Windows while providing appropriate user interfaces for experienced Git users and novices alike.

[Windows UI Library (WinUI)](https://docs.microsoft.com/en-us/windows/apps/winui/) is a native user experience (UX) framework for both Windows desktop and UWP applications. Take a look at the [Windows UI Library Roadmap](https://github.com/microsoft/microsoft-ui-xaml/blob/main/docs/roadmap.md).

[Windows UI Library (WinUI) 2](https://docs.microsoft.com/en-us/windows/apps/winui/winui2/) is tightly integrated with [Windows 10 and later SDKs](https://developer.microsoft.com/windows/downloads/windows-10-sdk/) and provides official native Windows UI controls and other user interface elements for UWP applications (and desktop applications using [XAML Islands](https://docs.microsoft.com/en-us/windows/apps/desktop/modernize/xaml-islands)).

[XAML Islands](https://docs.microsoft.com/en-us/windows/apps/desktop/modernize/xaml-islands)) is a feature that enables you to enhance the look, feel, and functionality of your existing WPF, Windows Forms, and C++ desktop (Win32) applications with the latest Windows 10 UI features that are only available via WinRT XAML controls. This means that you can use UWP features such as [Windows Ink](https://docs.microsoft.com/en-us/windows/uwp/design/input/pen-and-stylus-interactions) and controls that support the [Fluent Design System](https://docs.microsoft.com/en-us/windows/uwp/design/fluent-design-system/index) in your existing WPF, Windows Forms, and C++ desktop applications.

[Windows Community Toolkit](https://docs.microsoft.com/en-us/windows/communitytoolkit/) is a collection of helper functions, custom controls, and app services. It simplifies and demonstrates common developer tasks building UWP apps for Windows 10. The toolkit can be used to build apps for any Windows 10 device, including PC, Mobile, Xbox, IoT and HoloLens. You can also use the toolkit with an existing desktop app converted to UWP using the Desktop Bridge.

[Windows Pseudo Console (ConPTY)](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) is an API that provides a mechanism that is similar to the POSIX PTY model, but in a Windows-relevant manner VT Interactivity. Where it receives incoming UTF-8 encoded text, converts each displayable text character into the corresponding INPUT_RECORD, and stores them in the Input Buffer.

[Comparison of WinUI 3 and WinUI 2](https://docs.microsoft.com/en-us/windows/apps/winui/#comparison-of-winui-3-and-winui-2)

[Introducing Windows Terminal](https://devblogs.microsoft.com/commandline/introducing-windows-terminal/)

[An overview on Windows Terminal | Microsoft Docs](https://docs.microsoft.com/en-us/windows/terminal/)

[Windows Terminal Actions | Microsoft Docs](https://docs.microsoft.com/en-us/windows/terminal/customize-settings/actions)

[Windows Terminal command line arguments | Microsoft Docs](https://docs.microsoft.com/en-us/windows/terminal/command-line-arguments)

[Windows Terminal SSH | Microsoft Docs](https://docs.microsoft.com/en-us/windows/terminal/tutorials/ssh)

[Windows Terminal Themes](https://windowsterminalthemes.dev)

[Top Windows Command Line Courses Online | Udemy](https://www.udemy.com/topic/windows-command-line/)

[Learning Windows Terminal Online Class | LinkedIn Learning](https://www.linkedin.com/learning/learning-windows-terminal)

[Learning the Command Line with Online Courses | edX](https://www.edx.org/learn/command-line)

# Visual Studio and VSCode 
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/171919431-729ff449-fe7c-499d-8a21-d722a42eb7e5.png">
<br />
</p>

[Visual Studio](https://visualstudio.microsoft.com/) is an integrated development environment (IDE) from Microsoft; which is a feature-rich application that can be used for many aspects of software development. Visual Studio makes it easy to edit, debug, build, and publish your app. By using Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, and Windows Store.

[VSExtensibility](https://github.com/microsoft/VSExtensibility) is a repo for upcoming changes to extensibility in Visual Studio, the new extensibility model, and [Language Server Protocol(LSP)](https://github.com/microsoft/VSExtensibility/blob/main/docs/lsp/lsp-extensions-specifications.md). 

[Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/windows/)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/171919459-9e437c54-0d1e-4e85-bae1-efd8fc21859c.png">
<br />
Visual Studio
</p>

[Visual Studio Marketplace](https://marketplace.visualstudio.com) is a marketplace for all extensions for Visual Studio, Azure DevOps Services, Azure DevOps Server and Visual Studio Code.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/171919464-2e0c6a3c-70a5-493e-9aec-2e66c7b73498.png">
<br />
Visual Studio Marketplace
</p>

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/140833078-77973dcf-d3a6-421f-b6a7-b6e63fb1e97c.png">
  <br />
</p>

[Visual Studio Code](https://code.visualstudio.com) is a lightweight but powerful source code editor which runs on your desktop and is available for Windows, macOS and Linux. It comes with built-in support for JavaScript, TypeScript and Node.js and has a rich ecosystem of extensions for other languages (such as C++, C#, Java, Python, PHP, Go) and runtimes (such as .NET and Unity).

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/140832435-49e53589-e9e1-47fe-a1bd-d9800cfc1274.png">
<br />
VS Code
</p>

[Visual Studio Code Marketplace](https://marketplace.visualstudio.com/VSCode) is a marketplace for all extensions for Visual Studio, Azure DevOps Services, Azure DevOps Server and Visual Studio Code.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/140832440-0247a088-4eeb-4c57-ae7d-90894d56d629.png">
<br />
VS Code Marketplace
</p>

[VS Code Documentation](https://code.visualstudio.com/docs)

[Working with GitHub in VS Code](https://code.visualstudio.com/docs/editor/github)

[Code Server](https://coder.com/) is a tool that allows you to run [VS Code](https://code.visualstudio.com/) on any machine anywhere and access it in the browser.

[GitHub Codespaces](https://docs.github.com/en/free-pro-team@latest/github/developing-online-with-codespaces) is an integrated development environment(IDE) on GitHub. That allows developers to develop entirely in the cloud using Visual Studio and Visual Studio Code. Also, from any repo or pull request on GitHub you can simply press the period (.) key on your keyboard to bring up the browser-based VS Code environment with the source code file ready for editing. That dot (.) press to bring up the web-based VS Code editor takes you to https://github.dev/.

[Language Server Protocol (LSP)](https://microsoft.github.io/language-server-protocol/) is a tool that defines the protocol used between an editor or IDE and a language server that provides language features like auto complete, go to definition, find all references.

### Visual Studio Extensions for Developer Productivity
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

**Note:**  [Visual Studio IntelliCode](https://visualstudio.microsoft.com/services/intellicode/) is installed by default with any workload that supports C#, C++, TypeScript/JavaScript, or XAML in Visual Studio 2022.
  
 [Visual Assist](https://marketplace.visualstudio.com/items?itemName=WholeTomatoSoftware.VisualAssist) is a productivity tool for C/C++ and C# that improves IDE features related to navigation, refactoring, code generation, and coding assistance along with specific tooling for UE4/UE5.
  
 [Resharper](https://marketplace.visualstudio.com/items?itemName=JetBrains.ReSharper) is a popular developer productivity extension for Microsoft Visual Studio. It automates most of what can be automated in your coding routines. It finds compiler errors, runtime errors, redundancies, and code smells right as you type, suggesting intelligent corrections for them.
    
 [Visual Studio Live Share](https://visualstudio.microsoft.com/services/live-share/) is an extension that provides a collection of extensions that enable real-time collaborative development with VS Live Share.
    
 [Visual Studio Spell Checker](https://marketplace.visualstudio.com/items?itemName=EWoodruff.VisualStudioSpellCheckerVS2022andLater) is an editor extension that checks the spelling of comments, strings, and plain text as you type or interactively with a tool window. It can also spell check an entire solution, project, or selected items. 
    
 [GitHub Extensions for Visual Studio](https://marketplace.visualstudio.com/items?itemName=GitHub.GitHubExtensionforVisualStudio) is a Visual Studio Extension that brings the GitHub Flow into Visual Studio.
    
 [REST API Client Code Generator](https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ApiClientCodeGenerator) is a collection of Visual Studio C# custom tool code generators for Swagger / OpenAPI specification files.
    
 [Code Maid](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaid) is an open source Visual Studio extension to cleanup and simplify our C#, C++, F#, VB, PHP, PowerShell, R, JSON, XAML, XML, ASP, HTML, CSS, LESS, SCSS, JavaScript and TypeScript coding.
    
 [VS Color Output](https://marketplace.visualstudio.com/items?itemName=MikeWard-AnnArbor.VSColorOutput)  is an extension for Visual Studio. This extension is a color output for build and debug windows.
    
 [Visual Studio Theme Pack](https://marketplace.visualstudio.com/items?itemName=idex.vsthemepack) is a collection of popular themes, now available for Visual Studio.
    
 [Markdown Editor](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor2) is afull featured Markdown editor with live preview and syntax highlighting. Supports GitHub flavored Markdown.
    
 [SQLite and SQL Server Compact Toolbox](https://marketplace.visualstudio.com/items?itemName=ErikEJ.SQLServerCompactSQLiteToolbox) is an extension for Visual Studio. This extension adds several features to help your embedded database development efforts: Scripting of tables and data, import from SQL Server and CSV files and much, much more.
 
 [NuGet Package Manager](https://marketplace.visualstudio.com/items?itemName=NuGetTeam.NuGetPackageManager) collection of tools to automate the process of downloading, installing, upgrading, configuring, and removing packages from a VS Project.
    
 [SlowCheetah](https://marketplace.visualstudio.com/items?itemName=vscps.SlowCheetah-XMLTransforms) is a package allows you to automatically transform your app.config (or any file) when you press F5 in Visual Studio. You can have different transformations based on the build configuration. This will enable you to easily have different app settings, connection strings, etc for Debug versus Release. 
    
 [Roslynator](https://marketplace.visualstudio.com/items?itemName=josefpihrt.Roslynator2022) is a collection of 500+ analyzers, refactorings and fixes for C#, powered by Roslyn.
    
 [Trailing Whitespace Visualizer](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.TrailingWhitespaceVisualizer) is an  extension will highlight and remove any trailing whitespace on any line in any editor in Visual Studio. This makes it really easy to get rid of those annoying invisible characters.
    
 [Magical C# Debugging—OzCode](https://marketplace.visualstudio.com/items?itemName=CodeValueLtd.OzCode) is a must have Visual Studio Extension which cuts down on debugging time and increases productivity by detecting and isolating bugs, making them easy to fix.
    
 [File Icons](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.FileIcons) is an extension that adds file icons to Solution Explorer for files that Visual Studio doesn't provide icons for.
 
 [Image Optimizer](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.ImageOptimizer) is an extension that uses industry standard tools to optimize any JPEG, PNG and Gifs - including animated Gifs. It can do both lossy and lossless optimization.
 
 [File Nesting](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.FileNesting) is an extension that automatically nest files based on file name and enables developers to nest and unnest any file manually.
      
 [NCrunch for Visual Studio](https://marketplace.visualstudio.com/items?itemName=NCrunch.NCrunchforVisualStudio) is an automated parallel continuous testing tool for Visual Studio .NET. It intelligently takes responsibility for running automated tests so that you don't have to, and it gives you a huge amount of useful information about your tests (such as code coverage and performance metrics) inline in your IDE while you work.
    
 [SideWaffle Template Pack](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.SideWaffleTemplatePack) is an extension that contains both item and project templates suitable for building websites, Windows apps, Windows Phone apps, WPF, Visual Studio extensibilty project and a lot more.  
 
 [PostSharp](https://marketplace.visualstudio.com/items?itemName=PostSharpTechnologies.PostSharp) is the #1 pattern-aware extension to C# and VB. It allows developers to eradicate boilerplate. Implements some of the most common patterns and gives you the tools to build your own.
    

### VS Code Extensions for Developer Productivity

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

[Visual Studio Live Share](https://visualstudio.microsoft.com/services/live-share/) is a service/ extension that enables you to collaboratively edit and debug with others in real time, regardless of the programming languages you're using or app types you're building. You can instantly and securely share your current project, start a joint debugging session, share terminal instances, forward localhost web apps, have voice calls, and more.

[GistPad](https://marketplace.visualstudio.com/items?itemName=vsls-contrib.gistfs) is a Visual Studio Code extension that allows you to edit GitHub Gists and repositories from the comfort of your favorite editor. You can open, create, delete, fork and star gists and repositories, and then seamlessly begin editing files as if they were local, without ever cloning, pushing or pulling anything.

[Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer) is an extension for Visual Studio Code that launches a development local Server with live reload feature for static & dynamic pages.

[GitHub Pull Requests and Issues](https://marketplace.visualstudio.com/items?itemName=GitHub.vscode-pull-request-github) is an extension for Visual Studio Code that allows you to review and manage GitHub pull requests and issues in Visual Studio Code.

[Terminal](https://marketplace.visualstudio.com/items?itemName=formulahendry.terminal) is an extension for Visual Studio Code that lets you run terminal command directly in the Editor.

[Profile Switcher](https://marketplace.visualstudio.com/items?itemName=aaronpowell.vscode-profile-switcher) is an extension for Visual Studio Code that allows you to switch between different profiles you have created.

[Material Icon Theme](https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme) is an extension for Visual Studio Code that gets the Material Design icons into your VS Code.

[One Dark Pro](https://marketplace.visualstudio.com/items?itemName=zhuangtongfa.Material-theme) is an extension for Visual Studio Code that adds Atom's iconic One Dark theme, which is one of the most installed themes for VS Code.

[VSCode Icons](https://marketplace.visualstudio.com/items?itemName=vscode-icons-team.vscode-icons) is an extension for Visual Studio Code that brings icons to your Visual Studio Code setup.

[GitLens](https://marketplace.visualstudio.com/items?itemName=eamodio.gitlens) is an extension for Visual Studio Code that helps you visualize code authorship at a glance via Git blame annotations and code lens, seamlessly navigate and explore Git repositories, gain valuable insights via powerful comparison commands, and so much more.

[Import Cost](https://marketplace.visualstudio.com/items?itemName=wix.vscode-import-cost) is an extension for Visual Studio Code that will display inline in the editor the size of the imported/required package. The extension utilizes webpack with babili-webpack-plugin in order to detect the imported size.

[Markdown All in One](https://marketplace.visualstudio.com/items?itemName=yzhang.markdown-all-in-one) is an extension for Visual Studio Code that gives you everything you need to write Markdown (keyboard shortcuts, table of contents, auto preview and more).

[Bracket Pair Colorizer](https://marketplace.visualstudio.com/items?itemName=CoenraadS.bracket-pair-colorizer) is an extension for Visual Studio Code that allows matching brackets to be identified with colours. The user can define which characters to match, and which colours to use.

[Auto Rename Tag](https://marketplace.visualstudio.com/items?itemName=formulahendry.auto-rename-tag) is an extension for Visual Studio Code that automatically add HTML/XML close tag, same as Visual Studio IDE or Sublime Text.

[Auto-Close Tag](https://marketplace.visualstudio.com/items?itemName=formulahendry.auto-close-tag) is an extension for Visual Studio Code that automatically add HTML/XML close tag, same as Visual Studio IDE or Sublime Text does.

[Settings Sync](https://marketplace.visualstudio.com/items?itemName=Shan.code-settings-sync) is an extension for Visual Studio Code that synchronizes Settings, Snippets, Themes, File Icons, Launch, Keybindings, Workspaces and Extensions Across Multiple Machines Using GitHub Gist.

[Bookmarks](https://marketplace.visualstudio.com/items?itemName=alefragnani.Bookmarks) is an extension for Visual Studio Code that lets you mark lines of code and jump to them.

[Better Comments](https://marketplace.visualstudio.com/items?itemName=aaron-bond.better-comments) is an extension for Visual Studio Code that improves your code commenting by annotating with alert, informational, TODOs, and more.

[Code Spell Checker](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker) is an extension for Visual Studio Code that works as a spelling checker for source code.

[CSS Peak](https://marketplace.visualstudio.com/items?itemName=pranaygp.vscode-css-peek) is an extension for Visual Studio Code that allows peeking to css ID and class strings as definitions from html files to respective CSS. It also allows peek and goto definition.

[Tailwind CSS IntelliSense](https://marketplace.visualstudio.com/items?itemName=bradlc.vscode-tailwindcss) is an extension for Visual Studio Code that enhances the Tailwind development experience by providing Visual Studio Code users with advanced features such as autocomplete, syntax highlighting, and linting.

[Prettier](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode) is an extension for Visual Studio Code that is an opinionated code formatter. It enforces a consistent style by parsing your code and re-printing it with its own rules that take the maximum line length into account, wrapping code when necessary.

[NPM Intellisense](https://marketplace.visualstudio.com/items?itemName=christian-kohler.npm-intellisense) is an extension for Visual Studio Code that autocompletes npm modules in import statements.

[Path Intellisense](https://marketplace.visualstudio.com/items?itemName=christian-kohler.path-intellisense) is an extension for Visual Studio Code that autocompletes filenames.

[Relative Path](https://marketplace.visualstudio.com/items?itemName=jakob101.RelativePath) is an extension for Visual Studio Code that gets the relative url paths from files in the current workspace.

[Path Autocomplete](https://marketplace.visualstudio.com/items?itemName=ionutvmi.path-autocomplete) is an extension for Visual Studio Code that provides path completion for visual studio code.

[Discord Presence](https://marketplace.visualstudio.com/items?itemName=icrawl.discord-vscode) is an extension for Visual Studio Code that updates your discord status with a rich presence.

[Code Runner](https://marketplace.visualstudio.com/items?itemName=formulahendry.code-runner) is an extension for Visual Studio Code that runs code snippets or code files for multiple languages: C/C++, Java, JavaScript, PHP, Python, Perl, Ruby, Go, Lua, Groovy, PowerShell, BASH/SH, C#, F#, .NET Core, TypeScript, CoffeeScript, Scala, Swift, Julia, OCaml, R, Elixir, Clojure, Haxe, Objective-C, Rust, Racket, Scheme, Kotlin, Dart, Haskell, Nim, D, CUDA, and custom command.

[Kite](https://marketplace.visualstudio.com/items?itemName=kiteco.kite) is an extension for Visual Studio Code that provides an AI-powered programming assistant that helps you write code faster inside Visual Studio Code. Kite works for all major programming languages: Python, Java, Go, PHP, C/C#/C++, Javascript, HTML/CSS, Typescript, React, Ruby, Scala, Kotlin, Bash, Vue and React.

[Tabnine](https://marketplace.visualstudio.com/items?itemName=TabNine.tabnine-vscode) is an extension for Visual Studio Code that provides an AI code completion tool trusted by millions of developers to code faster with fewer errors. Whether you are a new dev or a seasoned pro, working solo or part of a team, Tabnine will help push your productivity to new heights while cutting your QA time in your favorite IDE.


# Game Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<h1 align="center">
 <img src="https://user-images.githubusercontent.com/45159366/97361059-45151700-185c-11eb-9d12-dae51c79eb8a.png">
  <br />
</h1>


## Game Engines

[Unity](https://unity.com) is a cross-platform game development platform. Use Unity to build high-quality 3D and 2D games, deploy them across mobile, desktop, VR/AR, consoles or the Web, and connect with loyal and enthusiastic players and customers.

<img src="https://user-images.githubusercontent.com/45159366/104788113-3432be00-5746-11eb-99b1-49360669f327.png">


[Unreal Engine 5](https://www.unrealengine.com) is a game engine developed by Epic Games with the world's most open and advanced real-time 3D creation tool. Continuously evolving to serve not only its original purpose as a state-of-the-art game engine, today it gives creators across industries the freedom and control to deliver cutting-edge content, interactive experiences, and immersive virtual worlds.

<img src="https://user-images.githubusercontent.com/45159366/104788122-37c64500-5746-11eb-8f61-48a69b94582d.png">


[Godot Engine](https://godotengine.org) is a feature-packed, cross-platform game engine to create 2D and 3D games from a unified interface. It provides a comprehensive set of common tools, so that users can focus on making games without having to reinvent the wheel. Games can be exported in one click to a number of platforms, including the major desktop platforms (Linux, Mac OSX, Windows) as well as mobile (Android, iOS) and web-based (HTML5) platforms.

[If you would like to Donate to the Godot Project](https://www.patreon.com/godotengine)

<img src="https://user-images.githubusercontent.com/45159366/104788134-3f85e980-5746-11eb-94c4-d97165ee888b.jpeg">


[Blender](https://www.blender.org) is the free and open source 3D creation suite. It supports the entirety of the 3D pipeline—modeling, rigging, animation, simulation, rendering, compositing and motion tracking, video editing and 2D animation pipeline.

[If you would like to Donate to the Blender Project](https://fund.blender.org/)

<img src="https://user-images.githubusercontent.com/45159366/110990485-3ec59a00-8328-11eb-8eb1-5502eb2eb74e.png">


[Unigine](https://unigine.com) is a cross-platform game engine designed for development teams (C++/C# programmers, 3D artists) working on interactive 3D apps.

<img src="https://user-images.githubusercontent.com/45159366/110881512-530c8700-8295-11eb-9959-131415eb4b3f.png">


[GameMaker Studio 2](https://www.yoyogames.com/gamemaker) is the latest and greatest incarnation of GameMaker. It has everything you need to take your idea from concept to finished game. With no barriers to entry and powerful functionality, GameMaker Studio 2 is the ultimate 2D development environment.


<img src="https://user-images.githubusercontent.com/45159366/104788147-44e33400-5746-11eb-879a-bc6239c98ce4.jpg">


## Tools

[Panda3D](https://www.panda3d.org/) is a game engine, a framework for 3D rendering and game development for Python and C++ programs, developed by Disney and CMU. Panda3D is open-source and free for any purpose, including commercial ventures.

[Source 2](https://developer.valvesoftware.com/wiki/Source_2) is a 3D video game engine in development by Valve as a successor to Source. It is used in Dota 2, Artifact, Dota Underlords, parts of The Lab, SteamVR Home, and Half-Life: Alyx.

[AutoDesk 3ds Max](https://www.autodesk.com/products/3ds-max/overview) is a professional software program for 3D modeling, animation, rendering, and visualization. 3ds Max allows you to create stunning game environments, design visualizations, and virtual reality experiences.

[Houdini](https://www.sidefx.com/) is a 3D procedural software for modeling, rigging, animation, VFX, look development, lighting and rendering in film, TV, advertising and video game pipelines.

[Open Graphics Library(OpenGL)](https://www.opengl.org/) is an API used acrossed mulitple  programming languages and platforms for hardware-accelerated rendering of 2D/3D vector graphics currently developed by the [Khronos Group](https://www.khronos.org/).

[Open Computing Language (OpenCL)](https://www.khronos.org/opencl/) is an open standard for [parallel programming](https://www.coursera.org/lecture/parprog1/introduction-to-parallel-computing-zNrIS) of heterogeneous platforms consisting of CPUs, GPUs, and other hardware accelerators found in supercomputers, cloud servers, personal computers, mobile devices and embedded platforms.

[OpenGL Shading Language(GLSL)](https://www.khronos.org/opengl/wiki/Core_Language_(GLSL)) is a High Level Shading Language based on the C-style language, so it covers most of the features a user would expect with such a language.  Such as control structures (for-loops, if-else statements, etc) exist in GLSL, including the switch statement.

[High Level Shading Language(HLSL)](https://docs.microsoft.com/en-us/windows/win32/direct3dhlsl/dx-graphics-hlsl) is the High Level Shading Language for DirectX. Using HLSL, the user can create C-like programmable shaders for the Direct3D pipeline. HLSL was first created with DirectX 9 to set up the programmable 3D pipeline.

[DirectX 12 Ultimate](https://github.com/Microsoft/DirectX-Graphics-Samples) is an API(for high performance 2D & 3D graphics) from Microsoft. DirectX 12 Ultimate brings support for ray tracing, mesh shaders, variable rate shading, and sampler feedback. Available in Windows 2004 version(May 2020 Update).

[Vulkan](https://www.khronos.org/vulkan/) is a modern cross-platform graphics and compute API that provides high-efficiency, cross-platform access to modern GPUs used in a wide variety of devices from PCs and consoles to mobile phones and embedded platforms. Vulkan is currently in development by the Khronos consortium.

[MoltenVK](https://moltengl.com/moltenvk) is an implementation of Vulkan running on iOS and macOS using Apple's [Metal](https://developer.apple.com/metal/) graphics framework.

[MoltenGL](https://moltengl.com) is an implementation of the OpenGL ES 2.0 API that runs on Apple's [Metal](https://developer.apple.com/metal/) graphics framework.

[AMD Radeon ProRender](https://www.amd.com/en/technologies/radeon-prorender) is a powerful physically-based rendering engine that enables creative professionals to produce stunningly photorealistic images on virtually any GPU, any CPU, and any OS in over a dozen leading digital content creation and CAD applications.

[NVIDIA Omniverse](https://developer.nvidia.com/nvidia-omniverse-platform) is a powerful, multi-GPU, real-time simulation and collaboration platform for 3D production pipelines based on Pixar's Universal Scene Description and NVIDIA RTX.

[LibGDX](https://github.com/libgdx/libgdx) is a cross-platform Java game development framework based on OpenGL (ES) that works on Windows, Linux, Mac OS X, Android, your WebGL enabled browser and iOS.

[cocos2d-x](https://github.com/cocos2d/cocos2d-x) is a multi-platform framework for building 2d games, interactive books, demos and other graphical applications. It is based on cocos2d-iphone, but instead of using Objective-C, it uses C++. It works on iOS, Android, macOS, Windows and Linux.

[MonoGame](https://github.com/MonoGame/MonoGame) is a framework for creating powerful cross-platform games. The spiritual successor to XNA with thousands of titles shipped across desktop, mobile, and console platforms. MonoGame is a fully managed .NET open source game framework without any black boxes.

[HGIG](https://www.hgig.org/) is a volunteer group of companies from the game and TV display industries that meet to specify and make available for the public guidelines to improve consumer gaming experiences in HDR.

[Three.js](https://threejs.org) is a cross-browser JavaScript library and application programming interface used to create and display animated 3D computer graphics in a web browser using WebGL.

[Superpowers](http://superpowers-html5.com/) is a downloadable HTML5 app for real-time collaborative projects . You can use it solo like a regular offline game maker, or setup a password and let friends join in on your project through their Web browser.

## Augmented Reality (AR) & Virtual Reality (VR)

[SteamVR](https://store.steampowered.com/steamvr) is the ultimate tool for experiencing VR content on the hardware of your choice. SteamVR supports the Valve Index, HTC Vive, Oculus Rift, Windows Mixed Reality headsets, and others.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/110881514-543db400-8295-11eb-9543-fd5d385ddb05.png">
<br />
SteamVR Home
</p>

[OpenVR](https://github.com/ValveSoftware/openvr) is an API and runtime that allows access to VR hardware(Steam Index, HTC Vive, and Oculus Rift) from multiple vendors without requiring that applications have specific knowledge of the hardware they are targeting.

[OpenVR Benchmark on Steam](https://store.steampowered.com/app/955610/OpenVR_Benchmark/) is the first benchmark tool for reproducibly testing your real VR performance, rendering inside of your VR headset.

[OpenHMD](http://www.openhmd.net/) is open source API and drivers that supports a wide range of HMD(head-mounted display) devices such as Oculus Rift, HTC Vive, Sony PSVR, and others.

[openXR](https://www.khronos.org/OpenXR/) is a free, open standard that provides high-performance access to Augmented Reality (AR) and Virtual Reality (VR) collectively known as XR—platforms and devices.

[Monado](https://monado.dev/) is the first OpenXR™ runtime for GNU/Linux. Monado aims to jump-start development of an open source XR ecosystem and provide the fundamental building blocks for device vendors to target the GNU/Linux platform.

[Libsurvive](https://github.com/cntools/libsurvive) is a set of tools and libraries that enable 6 dof tracking on lighthouse and vive based systems that is completely open source and can run on any device. It currently supports both SteamVR 1.0 and SteamVR 2.0 generation of devices and should support any tracked object commercially available.

[Simula](https://github.com/SimulaVR/Simula) is a VR window manager for Linux that runs on top of Godot. It takes less than 1 minute to install. Simula is officially compatible with SteamVR headsets equipped with Linux drivers (e.g. HTC Vive, HTC Vive Pro, & Valve Index). We have also added experimental support to OpenXR headsets that have Monado drivers (e.g. North Star, OSVR HDK, and PSVR). Some people have gotten the Oculus Rift S to run Simula via OpenHMD ([see here](https://github.com/OpenHMD/OpenHMD/issues/225#issuecomment-638454156)).

[ARCore](https://developers.google.com/ar/) is a software development kit developed by Google that allows for augmented reality applications in the real world. These tools include environmental understanding, which allows devices to detect horizontal and vertical surfaces and planes. It also includes motion tracking, which lets phones understand and track their positions relative to the world. Also ARCore’s Light Estimation API lets your digital objects appear realistically as if they’re actually part of the physical world.

## Game Development Learning Resources

[Unreal Online Learning](https://www.unrealengine.com/en-US/onlinelearning-courses) is a free learning platform that offers hands-on video courses and guided learning paths.

[Unreal Engine Authorized Training Program](https://www.unrealengine.com/en-US/training-partners)

[Unreal Engine for education](https://www.unrealengine.com/en-US/education/)

[Unreal Engine Training & Simulation](https://www.unrealengine.com/en-US/industry/training-simulation)

[Unity Certifications](https://unity.com/products/unity-certifications)

[Getting Started with Vulkan](https://www.khronos.org/vulkan/)

[Autodesk for Games](https://www.autodesk.com/campaigns/autodesk-for-games)

[Getting Started with DirectX 12 Ultimate](https://devblogs.microsoft.com/directx/directx-12-ultimate-getting-started-guide/)

[Game Design Online Courses from Udemy](https://www.udemy.com/courses/Design/Game-Design/)

[Game Design Online Courses from Skillshare](https://www.skillshare.com/browse/game-design)

[Learn Game Design with Online Courses and Classes from edX](https://www.edx.org/learn/game-design)

[Game Design Courses from Coursera](https://www.coursera.org/courses?query=game%20design)

[Game Design and Development Specialization Course from Coursera](https://www.coursera.org/specializations/game-development)


# Setting up a macOS workspace

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

### Docker OSX

[Docker OSX](https://github.com/sickcodes/Docker-OSX) is a tool that lets you run macOS VM in a Docker container atnear native OSX-KVM in Docker with X11 Forwarding. This project is developed and mantained by [sickcodes](https://github.com/sickcodes).

 * [Docker-OSX on Docker Hub](https://hub.docker.com/r/sickcodes/docker-osx)

**MacOS Ventura**

```
docker run -it \
    --device /dev/kvm \
    -p 50922:10022 \
    -v /tmp/.X11-unix:/tmp/.X11-unix \
    -e "DISPLAY=${DISPLAY:-:0.0}" \
    -e GENERATE_UNIQUE=true \
    -e MASTER_PLIST_URL='https://raw.githubusercontent.com/sickcodes/osx-serial-generator/master/config-custom.plist' \
    sickcodes/docker-osx:ventura

# docker build -t docker-osx --build-arg SHORTNAME=ventura .
```

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/205603964-f8c6c954-6215-4573-a028-bd8f1d1e5c8d.png">
  </br>
  MacOS Ventura
</p>


### OpenCore for macOS

**REQUIREMENTS**

   - A modern Linux distribution
   - QEMU > 2.11.1
   - A CPU with Intel VT-x / AMD SVM support is required
   - A CPU with SSE4.1 support is required for >= macOS Sierra
   - A CPU with AVX2 support is required for >= macOS Mojave
   - Internet access for the installation process

[OpenCore for macOS](https://dortania.github.io/OpenCore-Install-Guide/)

 <img src="https://user-images.githubusercontent.com/45159366/107092246-15a96b00-67b8-11eb-91fb-27494c7f1d4f.jpg">


# Android Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

[Android Studio](https://developer.android.com/studio/) is the development suite for Google's Android Operating System(OS). It's built on [JetBrains IntelliJ IDEA](https://www.jetbrains.com/idea/) software and designed specifically for Android development. It is available for download on Windows, macOS and Linux.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/108637349-29530380-743f-11eb-8c61-549064b7d80b.png">
</p>

[Android Virtual Device (AVD)](https://developer.android.com/studio/run/managing-avds) is a configuration in [Android Studio](https://developer.android.com/studio/intro) that defines the characteristics of an Android phone, tablet, Wear OS, Android TV, or Automotive OS device that you want to simulate in the Android Emulator. The [Android Emulator](https://developer.android.com/studio/run/emulator) simulates Android devices on your computer so that you can test your application on a variety of devices and Android API levels without needing to have each physical device.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/108637365-2c4df400-743f-11eb-8265-c07faab3523f.png">
</p>

[Genymotion](https://www.genymotion.com/) is a very fast Android emulator. The program itself is based on VirtualBox and is known for its effectively fast speed and is usefulness for running Android apps on a Windows, Mac and Linux desktop.

**Desktop**

Local virtual devices with high performances.

 - Emulate a wide range of virtual device configurations (Android versions, screen size, hardware capacities, etc.)
 - Simulate multiple scenarios thanks to our full set of hardware sensors (GPS, network, multitouch, etc.)
 - Cross-platform: Windows, Mac and Linux
 - Manipulate easily with ADB
 - $412 per year for employees in a company (BUSINESS). All features, advanced support.
 - $136 per year for freelancers (INDIE). All features, best effort support.
 - [Free](https://www.genymotion.com/download/) for personal use only (learning & entertainment). Limited features, no support.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/108637388-37a11f80-743f-11eb-9f37-6e22e1172f2d.png">
</p>

[Scrcpy](https://github.com/Genymobile/scrcpy) is an application by Genymotion that provides display and control of Android devices connected on USB (or over TCP/IP). It does not require any root access and works on GNU/Linux, Windows and macOS. The Android device requires at least API 21 (Android 5.0).

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/108637389-396ae300-743f-11eb-971a-f5b554033552.jpg">
</p>

# Professional Audio & Video Editing

[Back to the Top](https://github.com/mikeroyal/Windows-10-Guide/blob/main/README.md#table-of-contents)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/108773208-dba7cb00-7512-11eb-8fd0-2d009dbfc729.png">
</p>


[H.264(AVC)](https://en.wikipedia.org/wiki/H.264/MPEG-4_AVC) is a video compression standard based on block-oriented and motion-compensated integer-DCT coding that defines multiple profiles (tools) and levels (max bitrates and resolutions) with support up to 8K.

[H.265(HEVC)](https://en.wikipedia.org/wiki/High_Efficiency_Video_Coding) is a video compression standard that is the successor to H.264(AVC). It offers a 25% to 50% better data compression at the same level of video quality, or improved video quality at the same bit-rate.

[FFmpeg](https://ffmpeg.org) is a leading multimedia framework that can decode, encode, transcode, mux, demux, stream, filter and play pretty much anything that humans and machines have created. It supports the most obscure ancient formats up to the cutting edge ones on multiple platforms such as Windows, macOS, and Linux.

[HandBrake](https://handbrake.fr/) is a tool for transcoding video from almost any format with a selection of widely supported codecs. It is supported on Window, macOS, and Linux.

[Dynamic Adaptive Streaming over HTTP (DASH)](https://developer.mozilla.org/en-US/docs/Web/HTML/DASH_Adaptive_Streaming_for_HTML_5_Video) is an adaptive streaming protocol that allows for a video stream to switch between bit rates on the basis of network performance, in order to keep a video playing.

[OpenMAX™](https://www.khronos.org/openmax/) is a cross-platform API that provides comprehensive streaming media codec and application portability by enabling accelerated multimedia components to be developed, integrated and programmed across multiple operating systems and silicon platforms.

[Premiere Pro](https://www.adobe.com/products/premiere.html) is the industry-leading video editing software for film, TV, and the web. Creative tools, integration with other apps and services, and the power of Adobe Sensei help you craft footage into polished films and videos. With [Premiere Rush](https://www.adobe.com/products/premiere-rush.html) you can create and edit new projects from any device.

[DaVinci Resolve](https://www.blackmagicdesign.com/products/davinciresolve/) is the world’s only solution that combines professional 8K editing, color correction, visual effects and audio post production all in one software tool! You can instantly move between editing, color, effects, and audio with a single click. DaVinci Resolve Studio is also the only solution designed for multi user collaboration so editors, assistants, colorists, VFX artists and sound designers can all work live on the same project at the same time.

[Blender](https://www.blender.org/features/video-editing/) comes with a built-in video sequence editor allows you to perform basic actions like video cuts and splicing, as well as more complex tasks like video masking or color grading. The Video Editor includes: Live preview, luma waveform, chroma vectorscope and histogram displays. Audio mixing, syncing, scrubbing and waveform visualization.

[Kdenlive](https://kdenlive.org/en/) is an open source video editing tool that supports unlimited multimedia files. It's based on the MLT Framework, KDE and Qt. People who are looking for a very versatile video editing tool that comes packed with features. The latest 20.08 release is out with nifty features like Interface Layouts, Multiple Audio Stream support, Cached data management and Zoombars in the Clip Monitor and Effects Panel but one may argue that the highlights of this release are stability and interface improvements.

[OpenShot](https://www.openshot.org/) is an open-source video editing tool that's designed for users new in the editing environment. It has simple features such as a simple drag-and-drop function, it provides an easy-to-use and quick-to-learn user interface. The powerful video editor offers tons of efficient ways to cut and trim down your videos. You can freely utilize the unlimited tracks, video effects engine, title editor, 3D animations, slow motion, and time effects. It supports commonly used video codecs that are supported by FFmpeg like WebM (VP9), AVCHD (libx264), HEVC (libx265) and audio codecs like mp3 (libmp3lame) and aac (libfaac). The program can render MPEG4, ogv, Blu-ray and DVD video, and Full HD videos for uploading to the internet video websites like YouTube.

[Lightworks](https://www.lwks.com/) is a non-linear video editing appluication for editing and mastering digital video used by the film industry. Its professional edition has been used for box office hits, such as Shutter Island, Pulp Fiction, and Mission Impossible. Intimidating user interface. Like professional video editors, such as Adobe Premiere Pro, Lightworks is rather complicated to use for new users.

[Shotcut](https://www.shotcut.org/) is an open source multi-platform video editor. You can perform various actions such as video editing (including 4K video quality), add effects, create new movies, import most image files formats, export to almost any file format and much more.

[Olive](https://www.olivevideoeditor.org) is a free non-linear video editor aiming to provide a fully-featured alternative to high-end professional video editing software.

[Natron](https://natrongithub.github.io/) is a powerful Digital Compositor that can handle all of your 2D/2.5D needs. Its robust OIIO file formats and OpenFX architecture is what make Natron the most flexible open source compositor for the visual effects community. Its interface and functionally are the same across all platforms such as MacOS, Linux and Windows.

[OBS (Open Broadcaster Software)](https://obsproject.com/) is free and open source software for video recording and live streaming. Stream to Twitch, YouTube and many other providers or record your own videos with high quality H264 / AAC encoding.

[REAPER](https://www.reaper.fm/) is a complete digital audio production application for computers, offering a full multitrack audio and MIDI recording, editing, processing, mixing and mastering toolset.REAPER supports a vast range of hardware, digital formats and plugins, and can be comprehensively extended, scripted and modified.

[JACK Audio Connection Kit AKA JACK](https://jackaudio.org/) is a professional sound server daemon that provides real-time, low-latency connections for both audio and MIDI data between applications that implement its API. JACK can be configured to send audio data over a network to a "master" machine, which then outputs the audio to a physical device. This can be useful to mix audio from a number of "slave" computers without requiring additional cables or hardware mixers, and keeping the audio path digital for as long as possible.

[Bitwig Studio](https://www.bitwig.com) is a digital audio workstation that has linear and non-linear workflows for sound design, recording, live performance, and more. Along with 90+ instruments, effects, and other creative tools. It is supported Windows, macOS, and Linux.

[PipeWire](https://pipewire.org) is a server and user space API to deal with multimedia pipelines.It provides a low-latency, graph based processing engine on top of audio and video devices that can be used to support the use cases currently handled by both pulseaudio and JACK. PipeWire was designed with a powerful security model that makes interacting with audio and video devices from containerized applications easy. Nodes in the graph can be implemented as separate processes, communicating with sockets and exchanging multimedia content using fd passing.

[Sonobus](https://sonobus.net) is an easy to use application for streaming high-quality, low-latency peer-to-peer audio between devices over the internet or a local network.

[Avid Pro Tools](https://www.avid.com/pro-tools) is an industry standard audio-production software for songwriters, musicians, producers, and engineers.

[LMMS](https://lmms.io/) is an open source digital audio workstation application program. When LMMS is pairedr with appropriate computer hardware, it allows music to be produced by arranging samples, synthesizing sounds, playing on a MIDI keyboard, and combining the features of trackers and sequencers. Developed by Paul Giblock and Tobias Junghans, this program stands for "Linux MultiMedia Studio" and supports handy plugins that enables it to work on different operating systems.

[Ardour](http://ardour.org/) is an open source, collaborative effort of a worldwide team including musicians, programmers, and professional recording engineers. Development is transparent — anyone can watch our work as it happens. Like a good piece of vintage hardware, you can open the box and look inside.

[Audacity](https://www.audacityteam.org/) is an easy-to-use, multi-track audio editor and recorder for Windows, Mac OS X, GNU/Linux and other operating systems. Developed by a group of volunteers as open source and offered free of charge. Amazing support community.

[Glimpse](https://glimpse-editor.github.io/) is a cross-platform raster graphics editor based on the GNU Image Manipulation Program available for Linux, MacOS, and Windows. A great tool for making YouTube video thumbnails.

# 3D Graphics and Design

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/97116104-27a74800-16b8-11eb-9556-bdb90ba45ce7.png">
  <br />
</p>


## Learning Resources

[Introduction to Pixar's Universal Scene Description (USD)](https://graphics.pixar.com/usd/docs/index.html)

[Intro to using Universal Scene Description with NVIDIA](https://developer.nvidia.com/usd)

[First steps with Universal Scene Description in Blender](https://code.blender.org/2019/07/first-steps-with-universal-scene-description/)

[Adobe Creative Cloud Training Courses](https://www.adobe.com/products/captivateprime/content-catalog/creative-cloud.html)

[Adobe Creative Cloud Certifications](https://learning.adobe.com/certification.html)

[Blender Foundation](https://www.blender.org/foundation/)

[Blender Foundation Certification Training](https://www.blender.org/certification/)

[Blender Cloud Courses](https://cloud.blender.org/courses)

[Blender Institute](https://www.blender.org/institute/)

[Blender Education](https://www.blender.org/get-involved/)

[Blender Network](https://www.blendernetwork.org/)

[Blender Courses from Udemy](https://www.udemy.com/topic/blender/)

[AutoDesk Learning, Training & Certification](https://www.autodesk.com/training)

[AutoDesk Design Academy](https://academy.autodesk.com)

[AutoDesk Courses and Specializations from Coursera](https://www.coursera.org/autodesk)

[Cinema 4D Quick Tips](https://www.cineversity.com/vidplaylist/cinema_4d_quick_tips)

[Getting Started with Cinema 4D](https://www.cineversity.com/vidplaylist/getting_started_with_cinema_4d_r20)

[AMD Radeon ProRender Developer Suite](https://gpuopen.com/radeon-prorender-suite/)

[Graphic Design Masterclass(Photoshop, Illustrator, InDesign) from Udemy](https://www.udemy.com/course/graphic-design-masterclass-everything-you-need-to-know/)

[Vectr: Beginner's Guide To Graphic Design from udemy](https://www.udemy.com/course/vectr-beginners-guide-to-graphic-design/)

[Canva MasterClass: Design For EveryDay Use from Udemy](https://www.udemy.com/course/canva-masterclass-design-for-everyday-use/)


## Tools

[Adobe Creative Cloud](https://www.adobe.com/creativecloud.html) is a collection of 20+ desktop and mobile apps(Lightroom, Photoshop, Illustrator, InDesign, Rush, Etc.) and services for photography, design, video, web, UX, and more.

[AutoDesk](https://www.autodesk.com/) is a collection of professional software products and services used in 3D design, architecture, engineering, manufacturing, and high production entertainment companies.

[AutoDesk Maya](https://www.autodesk.com/products/maya/overview) is a professional 3D computer animation software with powerful modeling, rendering, simulation, texturing, and animation tools for artists, modelers, and animators.

[AutoDesk 3ds Max](https://www.autodesk.com/products/3ds-max/overview) is a professional software program for 3D modeling, animation, rendering, and visualization. 3ds Max allows you to create stunning game environments, design visualizations, and virtual reality experiences.

[Blender](https://www.blender.org) is a professional, free and open-source 3D computer graphics software toolset used for creating animated films, visual effects, art, 3D printed models, interactive 3D applications and video games.

[Cinema 4D](https://www.maxon.net/en-us/products/cinema-4d/overview/) is a professional 3D and VFX software suite that is capable of doing procedural and polygonal modeling, animation, lighting, texturing, motion graphic and rendering.

[Houdini](https://www.sidefx.com/) is a 3D procedural software for modeling, rigging, animation, VFX, look development, lighting and rendering in film, TV, advertising and video game pipelines.

[Open Graphics Library(OpenGL)](https://www.opengl.org/) is an API used acrossed mulitple  programming languages and platforms for hardware-accelerated rendering of 2D/3D vector graphics currently developed by the [Khronos Group](https://www.khronos.org/).

[Open Computing Language (OpenCL)](https://www.khronos.org/opencl/) is an open standard for [parallel programming](https://www.coursera.org/lecture/parprog1/introduction-to-parallel-computing-zNrIS) of heterogeneous platforms consisting of CPUs, GPUs, and other hardware accelerators found in supercomputers, cloud servers, personal computers, mobile devices and embedded platforms.

[Vulkan](https://www.khronos.org/vulkan/) is a modern cross-platform graphics and compute API that provides high-efficiency, cross-platform access to modern GPUs used in a wide variety of devices from PCs and consoles to mobile phones and embedded platforms. Vulkan is currently in development by the Khronos consortium.

[Metal](https://developer.apple.com/metal/) is a low-level GPU programming framework used for rendering 2D and 3D graphics on Apple platforms such as iOS, iPadOS, macOS, watchOS and tvOS.

[MoltenVK](https://moltengl.com/moltenvk) is an implementation of Vulkan running on iOS and macOS using Apple's [Metal](https://developer.apple.com/metal/) graphics framework.

[MoltenGL](https://moltengl.com) is an implementation of the OpenGL ES 2.0 API that runs on Apple's [Metal](https://developer.apple.com/metal/) graphics framework.

[AMD Radeon ProRender](https://www.amd.com/en/technologies/radeon-prorender) is a powerful physically-based rendering engine that enables creative professionals to produce stunningly photorealistic images on virtually any GPU, any CPU, and any OS in over a dozen leading digital content creation and CAD applications.

[NVIDIA Omniverse](https://developer.nvidia.com/nvidia-omniverse-platform) is a powerful, multi-GPU, real-time simulation and collaboration platform for 3D production pipelines based on Pixar's Universal Scene Description and NVIDIA RTX.

[Universal Scene Description](https://github.com/PixarAnimationStudios/USD) is an efficient, scalable system for authoring, reading, and streaming time-sampled scene description for interchange between graphics applications.

[OpenTimelineIO](https://github.com/PixarAnimationStudios/OpenTimelineIO) is an interchange format and API for editorial cut information. OTIO is not a container format for media, rather it contains information about the order and length of cuts and references to external media. OTIO includes both a file format and an API for manipulating that format. It also includes a plugin architecture for writing adapters to convert from/to existing editorial timeline formats. It also implements a dependency- less library for dealing strictly with time, opentime.

[OpenSubdiv](https://github.com/PixarAnimationStudios/OpenSubdiv) is a set of open source libraries that implement high performance subdivision surface (subdiv) evaluation on massively parallel CPU and GPU architectures. This codepath is optimized for drawing deforming subdivs with static topology at interactive framerates. The resulting limit surface matches Pixar's Renderman to numerical precision.

[Affinity Designer](https://affinity.serif.com/en-gb/designer/) is a professional vector graphics editor used by many industry leading illustrators, designers, and other creatives looking to create high-quality concept art.

[Sketch](https://www.sketch.com) is a professional vector graphics app with a beautiful UI and powerful toolset.

[Krita](https://krita.org/) is an open source professional painting program for digital painting and 2D animation.

[Vectr](https://vectr.com/) is a free graphics software used to create vector graphics easily and intuitively.

[Glimpse](https://glimpse-editor.github.io/) is a cross-platform raster graphics editor based on the GNU Image Manipulation Program available for Linux, macOS, and Windows. A great tool for making YouTube video thumbnails.

[GNU Image Manipulation Program(GIMP)](https://www.gimp.org/) is a cross-platform raster graphics editor based on the GNU Image Manipulation Program(GIMP) available for Linux, macOS, and Windows. A great free alternative for Photoshop.

[PhotoGIMP](https://github.com/Diolinux/PhotoGIMP) is a simple Patch for [GIMP 2.10+](https://www.gimp.org/) to help all Adobe Photoshop Users feel at home.

[Photopea](https://www.photopea.com/) is an advanced online photo editor supporting Adobe Photoshop(PSD), GIMP(XCF), Sketch App(Sketch), Adobe XD(XD) and CorelDRAW(CDR) formats.

[Inkscape](https://inkscape.org/) is an open-source vector graphics editor; it can be used to create or edit vector graphics such as illustrations, diagrams, line arts, charts, logos and complex paintings.

[Gthree](https://github.com/alexlarsson/gthree) is a GObject/Gtk+ port of three.js.

[FreeCAD](https://www.freecadweb.org/) is a free and open-source general-purpose parametric 3D CAD modeler and a building information modeling software with finite-element-method support.

[Ultimaker Cura](https://ultimaker.com/software/ultimaker-cura) is the world’s most popular 3D printing software. Prepare prints with a few clicks, integrate with CAD software for an easier workflow, or dive into custom settings for in-depth control.

[Dust3D](https://dust3d.org/) is a cross-platform open-source modeling software. It helps you create a 3D watertight model in seconds. Use it to speed up your character modeling in game making, 3D printing, and so on.

[Goxel](https://github.com/guillaumechereau/goxel) is a free and Open Source 3D Voxel Editor.

[Sketchfab](https://sketchfab.com/tags/open-source) gives you open-source 3D models ready to view, buy, and download for free.


# Kubernetes

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/95383873-a884d800-08a0-11eb-8eaf-57af5b119f56.png">
</p>

[Kubernetes (K8s)](https://kubernetes.io/) is an open-source system for automating deployment, scaling, and management of containerized applications.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/105645195-db9ea780-5e4e-11eb-8357-fb38b2f06d74.png">

**Building Highly-Availability(HA) Clusters with kubeadm. Source: [Kubernetes.io](https://kubernetes.io/docs/setup/production-environment/tools/kubeadm/high-availability/), 2020**
</p>

[Google Kubernetes Engine (GKE)](https://cloud.google.com/kubernetes-engine/) is a managed, production-ready environment for running containerized applications.

[Azure Kubernetes Service (AKS)](https://azure.microsoft.com/en-us/services/kubernetes-service/) is serverless Kubernetes, with a integrated continuous integration and continuous delivery (CI/CD) experience, and enterprise-grade security and governance. Unite your development and operations teams on a single platform to rapidly build, deliver, and scale applications with confidence.

[Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/what-is-eks.html) is a tool that runs Kubernetes control plane instances across multiple Availability Zones to ensure high availability.

[AWS Controllers for Kubernetes (ACK)](https://aws.amazon.com/blogs/containers/aws-controllers-for-kubernetes-ack/) is a new tool that lets you directly manage AWS services from Kubernetes. ACK makes it simple to build scalable and highly-available Kubernetes applications that utilize AWS services.

[Container Engine for Kubernetes (OKE)](https://www.oracle.com/cloud-native/container-engine-kubernetes/) is an Oracle-managed container orchestration service that can reduce the time and cost to build modern cloud native applications. Unlike most other vendors, Oracle Cloud Infrastructure provides Container Engine for Kubernetes as a free service that runs on higher-performance, lower-cost compute.

[Anthos](https://cloud.google.com/anthos/docs/concepts/overview) is a modern application management platform that provides a consistent development and operations experience for cloud and on-premises environments.

[Red Hat Openshift](https://www.openshift.com/) is a fully managed Kubernetes platform that provides a foundation for on-premises, hybrid, and multicloud deployments.

[OKD](https://okd.io/) is a community distribution of Kubernetes optimized for continuous application development and multi-tenant deployment. OKD adds developer and operations-centric tools on top of Kubernetes to enable rapid application development, easy deployment and scaling, and long-term lifecycle maintenance for small and large teams.

[Odo](https://odo.dev/) is a fast, iterative, and straightforward CLI tool for developers who write, build, and deploy applications on Kubernetes and OpenShift.

[Kata Operator](https://github.com/openshift/kata-operator) is an operator to perform lifecycle management (install/upgrade/uninstall) of [Kata Runtime](https://katacontainers.io/) on Openshift as well as Kubernetes cluster.

[Thanos](https://thanos.io/) is a set of components that can be composed into a highly available metric system with unlimited storage capacity, which can be added seamlessly on top of existing Prometheus deployments.

[OpenShift Hive](https://github.com/openshift/hive) is an operator which runs as a service on top of Kubernetes/OpenShift. The Hive service can be used to provision and perform initial configuration of OpenShift 4 clusters.

[Rook](https://rook.io/) is a tool that turns distributed storage systems into self-managing, self-scaling, self-healing storage services. It automates the tasks of a storage administrator: deployment, bootstrapping, configuration, provisioning, scaling, upgrading, migration, disaster recovery, monitoring, and resource management.

[VMware Tanzu](https://tanzu.vmware.com/tanzu) is a centralized management platform for consistently operating and securing your Kubernetes infrastructure and modern applications across multiple teams and private/public clouds.

[Kubespray](https://kubespray.io/) is a tool that combines Kubernetes and Ansible to easily install Kubernetes clusters that can be deployed on [AWS](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/aws.md), GCE, [Azure](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/azure.md), [OpenStack](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/openstack.md), [vSphere](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/vsphere.md), [Packet](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/packet.md) (bare metal), Oracle Cloud Infrastructure (Experimental), or Baremetal.

[KubeInit](https://github.com/kubeinit/kubeinit) provides Ansible playbooks and roles for the deployment and configuration of multiple Kubernetes distributions.

[Rancher](https://rancher.com/) is a complete software stack for teams adopting containers. It addresses the operational and security challenges of managing multiple Kubernetes clusters, while providing DevOps teams with integrated tools for running containerized workloads.

[K3s](https://github.com/rancher/k3s) is a highly available, certified Kubernetes distribution designed for production workloads in unattended, resource-constrained, remote locations or inside IoT appliances.

[Helm](https://helm.sh/) is a Kubernetes Package Manager tool that makes it easier to install and manage Kubernetes applications.

[Knative](https://knative.dev/) is a Kubernetes-based platform to build, deploy, and manage modern serverless workloads. Knative takes care of the operational overhead details of networking, autoscaling (even to zero), and revision tracking.

[KubeFlow](https://www.kubeflow.org/) is a tool dedicated to making deployments of machine learning (ML) workflows on Kubernetes simple, portable and scalable.

[Etcd](https://etcd.io/) is a distributed key-value store that provides a reliable way to store data that needs to be accessed by a distributed system or cluster of machines. Etcd is used as the backend for service discovery and stores cluster state and configuration for Kubernetes.

[OpenEBS](https://openebs.io/) is a Kubernetes-based tool to create stateful applications using Container Attached Storage.

[Container Storage Interface (CSI)](https://www.architecting.it/blog/container-storage-interface/) is an API that lets container orchestration platforms like Kubernetes seamlessly communicate with stored data via a plug-in.

[MicroK8s](https://microk8s.io/) is a tool that delivers the full Kubernetes experience. In a Fully containerized deployment with compressed over-the-air updates for ultra-reliable operations. It is supported on Linux, Windows, and MacOS.

[Charmed Kubernetes](https://ubuntu.com/kubernetes/features) is a well integrated, turn-key, conformant Kubernetes platform, optimized for your multi-cloud environments developed by Canonical.

[Grafana Kubernetes App](https://grafana.com/grafana/plugins/grafana-kubernetes-app) is a toll that allows you to monitor your Kubernetes cluster's performance. It includes 4 dashboards, Cluster, Node, Pod/Container and Deployment. It allows for the automatic deployment of the required Prometheus exporters and a default scrape config to use with your in cluster Prometheus deployment.

[KubeEdge](https://kubeedge.io/en/) is an open source system for extending native containerized application orchestration capabilities to hosts at Edge.It is built upon kubernetes and provides fundamental infrastructure support for network, app. deployment and metadata synchronization between cloud and edge.

[Lens](https://k8slens.dev/)  is the most powerful IDE for people who need to deal with Kubernetes clusters on a daily basis. It has support for MacOS, Windows and Linux operating systems.

[kind](https://kind.sigs.k8s.io/) is a tool for running local Kubernetes clusters using Docker container “nodes”. It was primarily designed for testing Kubernetes itself, but may be used for local development or CI.

[Flux CD](https://fluxcd.io/) is a tool that automatically ensures that the state of your Kubernetes cluster matches the configuration you've supplied in Git. It uses an operator in the cluster to trigger deployments inside Kubernetes, which means that you don't need a separate continuous delivery tool.

## Kubernetes Learning Resources

[Getting Kubernetes Certifications](https://training.linuxfoundation.org/certification/catalog/?_sft_technology=kubernetes)

[Getting started with Kubernetes on AWS](https://aws.amazon.com/kubernetes/)

[Kubernetes on Microsoft Azure](https://azure.microsoft.com/en-us/topic/what-is-kubernetes/)

[Intro to Azure Kubernetes Service](https://docs.microsoft.com/en-us/azure/aks/kubernetes-dashboard)

[Getting started with Google Cloud](https://cloud.google.com/learn/what-is-kubernetes)

[Getting started with Kubernetes on Red Hat](https://www.redhat.com/en/topics/containers/what-is-kubernetes)

[Getting started with Kubernetes on IBM](https://www.ibm.com/cloud/learn/kubernetes)

[YAML basics in Kubernetes](https://developer.ibm.com/technologies/containers/tutorials/yaml-basics-and-usage-in-kubernetes/)

[Elastic Cloud on Kubernetes](https://www.elastic.co/elastic-cloud-kubernetes)

[Docker and Kubernetes](https://www.docker.com/products/kubernetes)

[Deploy a model to an Azure Kubernetes Service cluster](https://docs.microsoft.com/en-us/azure/machine-learning/how-to-deploy-azure-kubernetes-service?tabs=python)

[Simplify Machine Learning Inference on Kubernetes with Amazon SageMaker Operators](https://aws.amazon.com/blogs/machine-learning/simplify-machine-learning-inference-on-kubernetes-with-amazon-sagemaker-operators/)

[Running Apache Spark on Kubernetes](http://spark.apache.org/docs/latest/running-on-kubernetes.html)

[Kubernetes Across VMware vRealize Automation](https://blogs.vmware.com/management/2019/06/kubernetes-across-vmware-cloud-automation-services.html)

[VMware Tanzu Kubernetes Grid](https://tanzu.vmware.com/kubernetes-grid)

[All the Ways VMware Tanzu Works with AWS](https://tanzu.vmware.com/content/blog/all-the-ways-vmware-tanzutm-works-with-aws)

[VMware Tanzu Education](https://tanzu.vmware.com/education)

[Using Ansible in a Cloud-Native Kubernetes Environment](https://www.ansible.com/blog/how-useful-is-ansible-in-a-cloud-native-kubernetes-environment)

[Managing Kubernetes (K8s) objects with Ansible](https://docs.ansible.com/ansible/latest/collections/community/kubernetes/k8s_module.html)

[Setting up a Kubernetes cluster using Vagrant and Ansible](https://kubernetes.io/blog/2019/03/15/kubernetes-setup-using-ansible-and-vagrant/)

[Running MongoDB with Kubernetes](https://www.mongodb.com/kubernetes)

[Kubernetes Fluentd](https://docs.fluentd.org/v/0.12/articles/kubernetes-fluentd)

[Understanding the new GitLab Kubernetes Agent](https://about.gitlab.com/blog/2020/09/22/introducing-the-gitlab-kubernetes-agent/)

[Kubernetes Contributors](https://www.kubernetes.dev/)

[KubeAcademy from VMware](https://kube.academy/)


# Machine Learning

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<img src="https://user-images.githubusercontent.com/45159366/108111395-756e0480-7049-11eb-85ca-b87315e9d3ef.jpeg">

## ML frameworks & applications

[TensorFlow](https://www.tensorflow.org) is an end-to-end open source platform for machine learning. It has a comprehensive, flexible ecosystem of tools, libraries and community resources that lets researchers push the state-of-the-art in ML and developers easily build and deploy ML powered applications.

[Tensorman](https://github.com/pop-os/tensorman) is a utility for easy management of Tensorflow containers by developed by [System76]( https://system76.com).Tensorman allows Tensorflow to operate in an isolated environment that is contained from the rest of the system. This virtual environment can operate independent of the base system, allowing you to use any version of Tensorflow on any version of a Linux distribution that supports the Docker runtime.

[Keras](https://keras.io) is a high-level neural networks API, written in Python and capable of running on top of TensorFlow, CNTK, or Theano.It was developed with a focus on enabling fast experimentation. It is capable of running on top of TensorFlow, Microsoft Cognitive Toolkit, R, Theano, or PlaidML.

[PyTorch](https://pytorch.org) is a library for deep learning on irregular input data such as graphs, point clouds, and manifolds. Primarily developed by Facebook's AI Research lab.

[Amazon SageMaker](https://aws.amazon.com/sagemaker/) is a fully managed service that provides every developer and data scientist with the ability to build, train, and deploy machine learning (ML) models quickly. SageMaker removes the heavy lifting from each step of the machine learning process to make it easier to develop high quality models.

[Azure Databricks](https://azure.microsoft.com/en-us/services/databricks/) is a fast and collaborative Apache Spark-based big data analytics service designed for data science and data engineering. Azure Databricks, sets up your Apache Spark environment in minutes, autoscale, and collaborate on shared projects in an interactive workspace. Azure Databricks supports Python, Scala, R, Java, and SQL, as well as data science frameworks and libraries including TensorFlow, PyTorch, and scikit-learn.

[Microsoft Cognitive Toolkit (CNTK)](https://docs.microsoft.com/en-us/cognitive-toolkit/) is an open-source toolkit for commercial-grade distributed deep learning. It describes neural networks as a series of computational steps via a directed graph. CNTK allows the user to easily realize and combine popular model types such as feed-forward DNNs, convolutional neural networks (CNNs) and recurrent neural networks (RNNs/LSTMs). CNTK implements stochastic gradient descent (SGD, error backpropagation) learning with automatic differentiation and parallelization across multiple GPUs and servers.

[Apache Airflow](https://airflow.apache.org) is an open-source workflow management platform created by the community to programmatically author, schedule and monitor workflows. Install. Principles. Scalable. Airflow has a modular architecture and uses a message queue to orchestrate an arbitrary number of workers. Airflow is ready to scale to infinity.

[Open Neural Network Exchange(ONNX)](https://github.com/onnx) is an open ecosystem that empowers AI developers to choose the right tools as their project evolves. ONNX provides an open source format for AI models, both deep learning and traditional ML. It defines an extensible computation graph model, as well as definitions of built-in operators and standard data types.

[Apache MXNet](https://mxnet.apache.org/) is a deep learning framework designed for both efficiency and flexibility. It allows you to mix symbolic and imperative programming to maximize efficiency and productivity. At its core, MXNet contains a dynamic dependency scheduler that automatically parallelizes both symbolic and imperative operations on the fly. A graph optimization layer on top of that makes symbolic execution fast and memory efficient. MXNet is portable and lightweight, scaling effectively to multiple GPUs and multiple machines. Support for Python, R, Julia, Scala, Go, Javascript and more.

[AutoGluon](https://autogluon.mxnet.io/index.html) is toolkit for Deep learning that automates machine learning tasks enabling you to easily achieve strong predictive performance in your applications. With just a few lines of code, you can train and deploy high-accuracy deep learning models on tabular, image, and text data.

[Anaconda](https://www.anaconda.com/) is a very popular Data Science platform for machine learning and deep learning that enables users to develop models, train them, and deploy them.

[PlaidML](https://github.com/plaidml/plaidml) is an advanced and portable tensor compiler for enabling deep learning on laptops, embedded devices, or other devices where the available computing hardware is not well supported or the available software stack contains unpalatable license restrictions.

[OpenCV](https://opencv.org) is a highly optimized library with focus on real-time computer vision applications. The C++, Python, and Java interfaces support Linux, MacOS, Windows, iOS, and Android.

[Scikit-Learn](https://scikit-learn.org/stable/index.html) is a Python module for machine learning built on top of SciPy, NumPy, and matplotlib, making it easier to apply robust and simple implementations of many popular machine learning algorithms.

[Weka](https://www.cs.waikato.ac.nz/ml/weka/) is an open source machine learning software that can be accessed through a graphical user interface, standard terminal applications, or a Java API. It is widely used for teaching, research, and industrial applications, contains a plethora of built-in tools for standard machine learning tasks, and additionally gives transparent access to well-known toolboxes such as scikit-learn, R, and Deeplearning4j.

[Caffe](https://github.com/BVLC/caffe) is a deep learning framework made with expression, speed, and modularity in mind. It is developed by Berkeley AI Research (BAIR)/The Berkeley Vision and Learning Center (BVLC) and community contributors.

[Theano](https://github.com/Theano/Theano) is a Python library that allows you to define, optimize, and evaluate mathematical expressions involving multi-dimensional arrays efficiently including tight integration with NumPy.

[nGraph](https://github.com/NervanaSystems/ngraph) is an open source C++ library, compiler and runtime for Deep Learning. The nGraph Compiler aims to accelerate developing AI workloads using any deep learning framework and deploying to a variety of hardware targets.It provides the freedom, performance, and ease-of-use to AI developers.

[NVIDIA cuDNN](https://developer.nvidia.com/cudnn) is a GPU-accelerated library of primitives for [deep neural networks](https://developer.nvidia.com/deep-learning). cuDNN provides highly tuned implementations for standard routines such as forward and backward convolution, pooling, normalization, and activation layers. cuDNN accelerates widely used deep learning frameworks, including [Caffe2](https://caffe2.ai/), [Chainer](https://chainer.org/), [Keras](https://keras.io/), [MATLAB](https://www.mathworks.com/solutions/deep-learning.html), [MxNet](https://mxnet.incubator.apache.org/), [PyTorch](https://pytorch.org/), and [TensorFlow](https://www.tensorflow.org/).

[Jupyter Notebook](https://jupyter.org/) is an open-source web application that allows you to create and share documents that contain live code, equations, visualizations and narrative text. Jupyter is used widely in industries that do data cleaning and transformation, numerical simulation, statistical modeling, data visualization, data science, and machine learning.

[Apache Spark](https://spark.apache.org/) is a unified analytics engine for large-scale data processing. It provides high-level APIs in Scala, Java, Python, and R, and an optimized engine that supports general computation graphs for data analysis. It also supports a rich set of higher-level tools including Spark SQL for SQL and DataFrames, MLlib for machine learning, GraphX for graph processing, and Structured Streaming for stream processing.

[Apache Spark Connector for SQL Server and Azure SQL](https://github.com/microsoft/sql-spark-connector) is a high-performance connector that enables you to use transactional data in big data analytics and persists results for ad-hoc queries or reporting. The connector allows you to use any SQL database, on-premises or in the cloud, as an input data source or output data sink for Spark jobs.

[Apache PredictionIO](https://predictionio.apache.org/) is an open source machine learning framework for developers, data scientists, and end users. It supports event collection, deployment of algorithms, evaluation, querying predictive results via REST APIs. It is based on scalable open source services like Hadoop, HBase (and other DBs), Elasticsearch, Spark and implements what is called a Lambda Architecture.

[Cluster Manager for Apache Kafka(CMAK)](https://github.com/yahoo/CMAK) is a tool for managing [Apache Kafka](https://kafka.apache.org/) clusters.

[BigDL](https://bigdl-project.github.io/) is a distributed deep learning library for Apache Spark. With BigDL, users can write their deep learning applications as standard Spark programs, which can directly run on top of existing Spark or Hadoop clusters.

[Koalas](https://pypi.org/project/koalas/) is project makes data scientists more productive when interacting with big data, by implementing the pandas DataFrame API on top of Apache Spark.

[Apache Spark™ MLflow](https://mlflow.org/) is an open source platform to manage the ML lifecycle, including experimentation, reproducibility, deployment, and a central model registry. MLflow currently offers four components:

**[MLflow Tracking](https://mlflow.org/docs/latest/tracking.html)**: Record and query experiments: code, data, config, and results.

**[MLflow Projects](https://mlflow.org/docs/latest/projects.html)**: Package data science code in a format to reproduce runs on any platform.

**[MLflow Models](https://mlflow.org/docs/latest/models.html)**: Deploy machine learning models in diverse serving environments.

**[Model Registry](https://mlflow.org/docs/latest/model-registry.html)**: Store, annotate, discover, and manage models in a central repository.

[Eclipse Deeplearning4J (DL4J)](https://deeplearning4j.konduit.ai/) is a set of projects intended to support all the needs of a JVM-based(Scala, Kotlin, Clojure, and Groovy) deep learning application. This means starting with the raw data, loading and preprocessing it from wherever and whatever format it is in to building and tuning a wide variety of simple and complex deep learning networks.

[Numba](https://github.com/numba/numba) is an open source, NumPy-aware optimizing compiler for Python sponsored by Anaconda, Inc. It uses the LLVM compiler project to generate machine code from Python syntax. Numba can compile a large subset of numerically-focused Python, including many NumPy functions. Additionally, Numba has support for automatic parallelization of loops, generation of GPU-accelerated code, and creation of ufuncs and C callbacks.

[Chainer](https://chainer.org/) is a Python-based deep learning framework aiming at flexibility. It provides automatic differentiation APIs based on the define-by-run approach (dynamic computational graphs) as well as object-oriented high-level APIs to build and train neural networks. It also supports CUDA/cuDNN using [CuPy](https://github.com/cupy/cupy) for high performance training and inference.

[cuML](https://github.com/rapidsai/cuml) is a suite of libraries that implement machine learning algorithms and mathematical primitives functions that share compatible APIs with other RAPIDS projects. cuML enables data scientists, researchers, and software engineers to run traditional tabular ML tasks on GPUs without going into the details of CUDA programming. In most cases, cuML's Python API matches the API from scikit-learn.

## Online ML Learning Resources

[Machine Learning by Stanford University from Coursera](https://www.coursera.org/learn/machine-learning)

[Machine Learning Courses Online from Coursera](https://www.coursera.org/courses?query=machine%20learning&)

[Machine Learning Courses Online from Udemy](https://www.udemy.com/topic/machine-learning/)

[Learn Machine Learning with Online Courses and Classes from edX](https://www.edx.org/learn/machine-learning)

# Robotics

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/96352533-b55fb380-1078-11eb-874c-f165cbcce899.png">
</p>

## Tools for Robotics

[ROS](https://www.ros.org/) is robotics middleware. Although ROS is not an operating system, it provides services designed for a heterogeneous computer cluster such as hardware abstraction, low-level device control, implementation of commonly used functionality, message-passing between processes, and package management.

[ROS2](https://index.ros.org/doc/ros2/) is a set of [software libraries and tools](https://github.com/ros2) that help you build robot applications. From drivers to state-of-the-art algorithms, and with powerful developer tools, ROS has what you need for your next robotics project. And it’s all open source.

[Robot Framework](https://robotframework.org/) is a generic open source automation framework. It can be used for test automation and robotic process automation. It has easy syntax, utilizing human-readable keywords. Its capabilities can be extended by libraries implemented with Python or Java.

[The Robotics Library (RL)](https://github.com/roboticslibrary/rl) is a self-contained C++ library for robot kinematics, motion planning and control. It covers mathematics, kinematics and dynamics, hardware abstraction, motion planning, collision detection, and visualization.RL runs on many different systems, including Linux, macOS, and Windows. It uses CMake as a build system and can be compiled with Clang, GCC, and Visual Studio.

[MoveIt](https://moveit.ros.org/) is the most widely used software for manipulation and has been used on over 100 robots. It provides an easy-to-use robotics platform for developing advanced applications, evaluating new designs and building integrated products for industrial, commercial, R&D, and other domains.

[AutoGluon](https://autogluon.mxnet.io/index.html) is toolkit for [Deep learning](https://gitlab.com/maos20008/intro-to-machine-learning) that automates machine learning tasks enabling you to easily achieve strong predictive performance in your applications. With just a few lines of code, you can train and deploy high-accuracy deep learning models on tabular, image, and text data.

[Gazebo](http://gazebosim.org/) accurately and efficiently simulates indoor and outdoor robots. You get a robust physics engine, high-quality graphics, and programmatic and graphical interfaces.

[Robotics System Toolbox](https://www.mathworks.com/products/robotics.html) provides tools and algorithms for designing, simulating, and testing manipulators, mobile robots, and humanoid robots. For manipulators and humanoid robots, the toolbox includes algorithms for collision checking, trajectory generation, forward and inverse kinematics, and dynamics using a rigid body tree representation.
For mobile robots, it includes algorithms for mapping, localization, path planning, path following, and motion control. The toolbox provides reference examples of common industrial robot applications. It also includes a library of
commercially available industrial robot models that you can import, visualize, and simulate.

[Intel Robot DevKit](https://github.com/intel/robot_devkit) is the tool to generate Robotics Software Development Kit (RDK) designed for autonomous devices, including the ROS2 core and capacibilities packages like perception, planning, control driver etc. It provides flexible build/runtime configurations to meet different autonomous requirement on top of diversity hardware choices, for example use different hareware engine CPU/GPU/VPU to accelerate AI related features.

[Arduino](https://www.arduino.cc/) is an open-source platform used for building electronics projects. Arduino consists of both a physical programmable circuit board (often referred to as a microcontroller) and a piece of software, or IDE (Integrated Development Environment) that runs on your computer, used to write and upload computer code to the physical board.

[ArduPilot](https://ardupilot.org/ardupilot/index.html) enables the creation and use of trusted, autonomous, unmanned vehicle systems for the peaceful benefit of all. ArduPilot provides a comprehensive suite of tools suitable for almost any vehicle and application.

[AirSim](https://github.com/Microsoft/AirSim) is a simulator for drones, cars and more, built on Unreal Engine (we now also have an experimental Unity release). It is open-source, cross platform, and supports hardware-in-loop with popular flight controllers such as PX4 for physically and visually realistic simulations.

[F´ (F Prime)](https://github.com/nasa/fprime) is a component-driven framework that enables rapid development and deployment of spaceflight and other embedded software applications. Originally developed at the Jet Propulsion Laboratory, F´ has been successfully deployed on several space applications.

[The JPL Open Source Rover](https://github.com/nasa-jpl/open-source-rover) is an open source, build it yourself, scaled down version of the 6 wheel rover design that JPL uses to explore the surface of Mars. The Open Source Rover is designed almost entirely out of consumer off the shelf (COTS) parts. This project is intended to be a teaching and learning experience for those who want to get involved in mechanical engineering, software, electronics, or robotics.

[Light Detection and Ranging(LiDAR)](https://en.wikipedia.org/wiki/Lidar) is a remote sensing method that uses light in the form of a pulsed laser at an object, and uses the time and wavelength of the reflected beam of light to estimate the distance and in some applications ([Laser Imaging](https://en.wikipedia.org/wiki/Laser_scanning)), to create a 3D representation of the object and its surface characteristics. This technology is commonly used in aircraft and self-driving vehicles.

[AliceVision](https://github.com/alicevision/AliceVision) is a Photogrammetric Computer Vision Framework which provides a 3D Reconstruction and Camera Tracking algorithms. AliceVision aims to provide strong software basis with state-of-the-art computer vision algorithms that can be tested, analyzed and reused. The project is a result of collaboration between academia and industry to provide cutting-edge algorithms with the robustness and the quality required for production usage.

[CARLA](https://github.com/carla-simulator/carla) is an open-source simulator for autonomous driving research. CARLA has been developed from the ground up to support development, training, and validation of autonomous driving systems. In addition to open-source code and protocols, CARLA provides open digital assets (urban layouts, buildings, vehicles) that were created for this purpose and can be used freely. The simulation platform supports flexible specification of sensor suites and environmental conditions.

[ROS bridge](https://github.com/carla-simulator/ros-bridge) is a package to bridge ROS for CARLA Simulator.

[ROS-Industrial](https://rosindustrial.org/) is an open source project that extends the advanced capabilities of ROS software to manufacturing.

[AWS RoboMaker](https://aws.amazon.com/robomaker/) is the most complete cloud solution for robotic developers to simulate, test and securely deploy robotic applications at scale. RoboMaker provides a fully-managed, scalable infrastructure for simulation that customers use for multi-robot simulation and CI/CD integration with regression testing in simulation.

[Microsoft Robotics Developer Studio](https://www.microsoft.com/en-us/download/details.aspx?id=29081)  is a free .NET-based programming environment for building robotics applications.

[Visual Studio Code Extension for ROS](https://github.com/ms-iot/vscode-ros) is an extension provides support for Robot Operating System (ROS) development.

[Azure Kinect ROS Driver](https://github.com/microsoft/azure_kinect_ros_driver) is a node which publishes sensor data from the [Azure Kinect Developer Kit](https://azure.microsoft.com/en-us/services/kinect-dk/) to the [Robot Operating System (ROS)](http://www.ros.org/). Developers working with ROS can use this node to connect an Azure Kinect Developer Kit to an existing ROS installation.

[Azure IoT Hub for ROS](https://github.com/microsoft/ros_azure_iothub) is a ROS package works with the Microsoft Azure IoT Hub service to relay telemetry messages from the Robot to Azure IoT Hub or reflect properties from the Digital Twin to the robot using dynamic reconfigure.

[ROS 2 with ONNX Runtime](https://github.com/ms-iot/ros_msft_onnx) is a program that uses ROS 2 to run on different hardware platforms using their respective AI acceleration libraries for optimized execution of the ONNX model.

[Azure Cognitive Services LUIS ROS Node](https://github.com/ms-iot/ros_msft_luis) is a ROS node that bridges between ROS and the Azure Language Understanding Service. it can be configured to process audio directly from a microphone, or can subscribe to a ROS audio topic, then processes speech and generates "intent" ROS messages which can be processed by another ROS node to generate ROS commands.

## Robotics Learning Resources

[Robotics courses from Coursera](https://www.edx.org/learn/robotics)

[Learn Robotics with Online Courses and Classes from edX](https://www.edx.org/learn/robotics)

[Top Robotics Courses Online from Udemy](https://www.udemy.com/topic/robotics/)

[Free Online AI & Robotics Courses](https://www.futurelearn.com/subjects/it-and-computer-science-courses/ai-and-robotics)

[REC Foundation Robotics Industry Certification](https://www.roboticseducation.org/industry-certifications/)

[Carnegie Mellon Robotics Academy](https://www.cmu.edu/roboticsacademy/Training/Certifications.html)

[RIA Robotic Integrator Certification Program](https://www.robotics.org/robotics/integrator-certification)

[AWS RoboMaker – Develop, Test, Deploy, and Manage Intelligent Robotics Apps](https://aws.amazon.com/blogs/aws/aws-robomaker-develop-test-deploy-and-manage-intelligent-robotics-apps/)

[Microsoft AI School](https://aischool.microsoft.com/en-us/home)

[Language Understanding (LUIS) for Azure Cognitive Services](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/what-is-luis)

[Azure VM templates to bootstrap ROS and ROS 2 environments](https://ms-iot.github.io/ROSOnWindows/ROSAtMS/AzureVM.html)

[Google Robotics Research](https://research.google/teams/brain/robotics/)

# Open Source Security

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/96352529-af69d280-1078-11eb-9e87-8a73f48af246.png">
</p>

[Open Source Security Foundation (OpenSSF)](https://openssf.org/) is a cross-industry collaboration that brings together leaders to improve the security of open source software by building a broader community, targeted initiatives, and best practices. The OpenSSF brings together open source security initiatives under one foundation to accelerate work through cross-industry support. Along with the Core Infrastructure Initiative and the Open Source Security Coalition, and will include new working groups that address vulnerability disclosures, security tooling and more.

## Security Standards, Frameworks and Benchmarks

[STIGs Benchmarks - Security Technical Implementation Guides](https://public.cyber.mil/stigs/)

[CIS Benchmarks - CIS Center for Internet Security](https://www.cisecurity.org/cis-benchmarks/)

[NIST - Current FIPS](https://www.nist.gov/itl/current-fips)

[ISO Standards Catalogue](https://www.iso.org/standards.html)

[Common Criteria for Information Technology Security Evaluation (CC)](https://www.commoncriteriaportal.org/cc/) is an international standard (ISO / IEC 15408) for computer security. It allows an objective evaluation to validate that a particular product satisfies a defined set of security requirements.

[ISO 22301](https://www.iso.org/en/contents/data/standard/07/51/75106.html) is the international standard that provides a best-practice framework for implementing an optimised BCMS (business continuity management system).

[ISO27001](https://www.iso.org/isoiec-27001-information-security.html) is the international standard that describes the requirements for an ISMS (information security management system). The framework is designed to help organizations manage their security practices in one place, consistently and cost-effectively.

[ISO 27701](https://www.iso.org/en/contents/data/standard/07/16/71670.html) specifies the requirements for a PIMS (privacy information management system) based on the requirements of ISO 27001.
It is extended by a set of privacy-specific requirements, control objectives and controls. Companies that have implemented ISO 27001 will be able to use ISO 27701 to extend their security efforts to cover privacy management.

[EU GDPR (General Data Protection Regulation)](https://gdpr.eu/) is a privacy and data protection law that supersedes existing national data protection laws across the EU, bringing uniformity by introducing just one main data protection law for companies/organizations to comply with.

[CCPA (California Consumer Privacy Act)](https://www.oag.ca.gov/privacy/ccpa) is a data privacy law that took effect on January 1, 2020 in the State of California. It applies to businesses that collect California residents’ personal information, and its privacy requirements are similar to those of the EU’s GDPR (General Data Protection Regulation).

[Payment Card Industry (PCI) Data Security Standards (DSS)](https://docs.microsoft.com/en-us/microsoft-365/compliance/offering-pci-dss) is a global information security standard designed to prevent fraud through increased control of credit card data.

[SOC 2](https://www.aicpa.org/interestareas/frc/assuranceadvisoryservices/aicpasoc2report.html) is an auditing procedure that ensures your service providers securely manage your data to protect the interests of your comapny/organization and the privacy of their clients.

[NIST CSF](https://www.nist.gov/national-security-standards) is a voluntary framework primarily intended for critical infrastructure organizations to manage and mitigate cybersecurity risk based on existing best practice.

## Security Tools

[SELinux](https://github.com/SELinuxProject/selinux) is a security enhancement to Linux which allows users and administrators more control over access control. Access can be constrained on such variables as which users and applications can access which resources. These resources may take the form of files. Standard Linux access controls, such as file modes (-rwxr-xr-x) are modifiable by the user and the applications which the user runs. Conversely, SELinux access controls are determined by a policy loaded on the system which may not be changed by careless users or misbehaving applications.

[Control Groups(Cgroups)](https://www.redhat.com/sysadmin/cgroups-part-one) is a Linux kernel feature that allows you to allocate resources such as CPU time, system memory, network bandwidth, or any combination of these resources for user-defined groups of tasks (processes) running on a system.

[EarlyOOM](https://github.com/rfjakob/earlyoom) is a daemon for Linux that enables users to more quickly recover and regain control over their system in low-memory situations with heavy swap usage.

[Libgcrypt](https://www.gnupg.org/related_software/libgcrypt/) is a general purpose cryptographic library originally based on code from GnuPG.

[Kali Linux](https://www.kali.org/)  is an open source project that is maintained and funded by Offensive Security, a provider of world-class information security training and penetration testing services.

[Pi-hole](https://pi-hole.net/) is a [DNS sinkhole](https://en.wikipedia.org/wiki/DNS_Sinkhole) that protects your devices from unwanted content, without installing any client-side software, intended for use on a private network. It is designed for use on embedded devices with network capability, such as the Raspberry Pi, but it can be used on other machines running Linux and cloud implementations.

[Aircrack-ng](https://www.aircrack-ng.org/) is a network software suite consisting of a detector, packet sniffer, WEP and WPA/WPA2-PSK cracker and analysis tool for 802.11 wireless LANs. It works with any wireless network interface controller whose driver supports raw monitoring mode and can sniff 802.11a, 802.11b and 802.11g traffic.

[Burp Suite](https://portswigger.net/burp) is a leading range of cybersecurity tools.

[KernelCI](https://foundation.kernelci.org/) is a community-based open source distributed test automation system focused on upstream kernel development. The primary goal of KernelCI is to use an open testing philosophy to ensure the quality, stability and long-term maintenance of the Linux kernel.

[Continuous Kernel Integration project](https://github.com/cki-project) helps find bugs in kernel patches before they are commited to an upstram kernel tree. We are team of kernel developers, kernel testers, and automation engineers.

[eBPF](https://ebpf.io) is a revolutionary technology that can run sandboxed programs in the Linux kernel without changing kernel source code or loading kernel modules. By making the Linux kernel programmable, infrastructure software can leverage existing layers, making them more intelligent and feature-rich without continuing to add additional layers of complexity to the system.

[Cilium](https://cilium.io/) uses eBPF to accelerate getting data in and out of L7 proxies such as Envoy, enabling efficient visibility into API protocols like HTTP, gRPC, and Kafka.

[Hubble](https://github.com/cilium/hubble) is a Network, Service & Security Observability for Kubernetes using eBPF.

[Istio](https://istio.io/) is an open platform to connect, manage, and secure microservices. Istio's control plane provides an abstraction layer over the underlying cluster management platform, such as Kubernetes and Mesos.

[Certgen](https://github.com/cilium/certgen) is a convenience tool to generate and store certificates for Hubble Relay mTLS.

[Scapy](https://scapy.net/) is a python-based interactive packet manipulation program & library.

[syzkaller](https://github.com/google/syzkaller) is an unsupervised, coverage-guided kernel fuzzer.

[SchedViz](https://github.com/google/schedviz) is a tool for gathering and visualizing kernel scheduling traces on Linux machines.

[oss-fuzz](https://google.github.io/oss-fuzz/) aims to make common open source software more secure and stable by combining modern fuzzing techniques with scalable, distributed execution.

[OSSEC](https://www.ossec.net/) is a free, open-source host-based intrusion detection system. It performs log analysis, integrity checking, Windows registry monitoring, rootkit detection, time-based alerting, and active response.

[Metasploit Project](https://www.metasploit.com/) is a computer security project that provides information about security vulnerabilities and aids in penetration testing and IDS signature development.

[Wfuzz](https://github.com/xmendez/wfuzz) was created to facilitate the task in web applications assessments and it is based on a simple concept: it replaces any reference to the FUZZ keyword by the value of a given payload.

[Nmap](https://nmap.org/) is a security scanner used to discover hosts and services on a computer network, thus building a "map" of the network.

[Patchwork](https://github.com/getpatchwork/patchwork) is a web-based patch tracking system designed to facilitate the contribution and management of contributions to an open-source project.

[pfSense](https://www.pfsense.org/) is a free and open source firewall and router that also features unified threat management, load balancing, multi WAN, and more.

[Snowpatch](https://github.com/ruscur/snowpatch) is a continuous integration tool for projects using a patch-based, mailing-list-centric git workflow. This workflow is used by a number of well-known open source projects such as the Linux kernel.

[Snort](https://www.snort.org/) is an open-source, free and lightweight network intrusion detection system (NIDS) software for Linux and Windows to detect emerging threats.

[Wireshark](https://www.wireshark.org/) is a free and open-source packet analyzer. It is used for network troubleshooting, analysis, software and communications protocol development, and education.

[OpenSCAP](https://www.open-scap.org/) is U.S. standard maintained by [National Institute of Standards and Technology (NIST)](https://www.nist.gov/). It provides multiple tools to assist administrators and auditors with assessment, measurement, and enforcement of security baselines. OpenSCAP maintains great flexibility and interoperability by reducing the costs of performing security audits. Whether you want to evaluate DISA STIGs, NIST‘s USGCB, or Red Hat’s Security Response Team’s content, all are supported by OpenSCAP.

[Tink](https://github.com/google/tink) is a multi-language, cross-platform, open source library that provides cryptographic APIs that are secure, easy to use correctly, and harder to misuse.

[OWASP](https://www.owasp.org/index.php/Main_Page) is an online community, produces freely-available articles, methodologies, documentation, tools, and technologies in the field of web application security.

[Open Vulnerability and Assessment Language](https://oval.mitre.org/) is a community effort to standardize how to assess and report upon the machine state of computer systems. OVAL includes a language to encode system details, and community repositories of content. Tools and services that use OVAL provide enterprises with accurate, consistent, and actionable information to improve their security.

[ClamAV](https://www.clamav.net/) is an open source antivirus engine for detecting trojans, viruses, malware & other malicious threats.

## Open Source Security Learning Resources

[Microsoft Open Source Software Security](https://www.microsoft.com/en-us/securityengineering/opensource)

[Cloudflare Open Source Security](https://cloudflare.github.io)

[The Seven Properties of Highly Secure Devices](https://www.microsoft.com/en-us/research/publication/seven-properties-highly-secure-devices/)

[How Layer 7 of the Internet Works](https://www.cloudflare.com/learning/ddos/what-is-layer-7/)

[The 7 Kinds of Security](https://www.veracode.com/sites/default/files/Resources/eBooks/7-kinds-of-security.pdf)

[The Libgcrypt Reference Manual](https://www.gnupg.org/documentation/manuals/gcrypt/)

[The Open Web Application Security Project(OWASP) Foundation Top 10](https://owasp.org/www-project-top-ten/)

[Best Practices for Using Open Source Code from The Linux Foundation](https://www.linuxfoundation.org/blog/2017/11/best-practices-using-open-source-code/)

[AWS Certified Security - Specialty Certification](https://aws.amazon.com/certification/certified-security-specialty/)

[Microsoft Certified: Azure Security Engineer Associate](https://docs.microsoft.com/en-us/learn/certifications/azure-security-engineer)

[Google Cloud Certified Professional Cloud Security Engineer](https://cloud.google.com/certification/cloud-security-engineer)

[Cisco Security Certifications](https://www.cisco.com/c/en/us/training-events/training-certifications/certifications/security.html)

[The Red Hat Certified Specialist in Security: Linux](https://www.redhat.com/en/services/training/ex415-red-hat-certified-specialist-security-linux-exam)

[Linux Professional Institute LPIC-3 Enterprise Security Certification](https://www.lpi.org/our-certifications/lpic-3-303-overview)

[Cybersecurity Training and Courses from IBM Skills](https://www.ibm.com/skills/topics/cybersecurity/)

[Cybersecurity Courses and Certifications by Offensive Security](https://www.offensive-security.com/courses-and-certifications/)

[RSA Certification Program](https://community.rsa.com/community/training/certification)

[Check Point Certified Security Expert(CCSE) Certification](https://training-certifications.checkpoint.com/#/courses/Check%20Point%20Certified%20Expert%20(CCSE)%20R80.x)

[Check Point Certified Security Administrator(CCSA) Certification](https://training-certifications.checkpoint.com/#/courses/Check%20Point%20Certified%20Admin%20(CCSA)%20R80.x)

[Check Point Certified Security Master (CCSM) Certification](https://training-certifications.checkpoint.com/#/courses/Check%20Point%20Certified%20Master%20(CCSM)%20R80.x)

[Certified Cloud Security Professional(CCSP) Certification](https://www.isc2.org/Certifications/CCSP)

[Certified Information Systems Security Professional (CISSP) Certification](https://www.isc2.org/Certifications/CISSP)

[CCNP Routing and Switching](https://learningnetwork.cisco.com/s/ccnp-enterprise)

[Certified Information Security Manager(CISM)](https://www.isaca.org/credentialing/cism)

[Wireshark Certified Network Analyst (WCNA)](https://www.wiresharktraining.com/certification.html)

[Juniper Networks Certification Program Enterprise (JNCP)](https://www.juniper.net/us/en/training/certification/)

[Security Training Certifications and Courses from Udemy](https://www.udemy.com/courses/search/?src=ukw&q=secuirty)

[Security Training Certifications and Courses from Coursera](https://www.coursera.org/search?query=security&)

[Security Certifications Training from Pluarlsight](https://www.pluralsight.com/browse/information-cyber-security/security-certifications)

# Differential Privacy

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/103486336-fd59c100-4db1-11eb-9780-a0b90bd5db1f.png">
  <br />

</p>


[Differential Privacy](https://www.microsoft.com/en-us/ai/ai-lab-differential-privacy) is a system that simultaneously enables researchers and analysts to extract useful insights from datasets containing personal information and offers stronger privacy protections. This is achieved by introducing "statistical noise".

[Statistical Noise](https://news.microsoft.com/on-the-issues/2020/08/27/statistical-noise-data-differential-privacy/) is a process that small aletrations to masked datasets. The statistical noise hides identifiable characteristics of individuals, ensuring that the privacy of personal information is protected, but it's small enough to not materially impact the accuracy of the answers extracted by analysts and researchers.

[Laplacian Noise](https://en.wikipedia.org/wiki/Laplace_distribution) is a mechanism that adds Laplacian-distributed noise to a function.

<p align="center">
<img src="https://user-images.githubusercontent.com/45159366/103486337-ff238480-4db1-11eb-9895-f7f49cc5715a.png">
  <br />
  Above is a simple diagram of how Differential Privacy-Preserving Data Sharing and Data Mining protects a User's Data
</p>

## Tools

[PySyft](https://github.com/OpenMined/PySyft) is a Python library for secure and private Deep Learning. PySyft decouples private data from model training, using [Federated Learning](https://ai.googleblog.com/2017/04/federated-learning-collaborative.html), [Differential Privacy](https://www.microsoft.com/en-us/ai/ai-lab-differential-privacy), and Encrypted Computation (like [Multi-Party Computation (MPC)](https://multiparty.org) and [Homomorphic Encryption (HE)](https://www.microsoft.com/en-us/research/project/homomorphic-encryption/) within the main Deep Learning frameworks like [PyTorch](https://pytorch.org/) and [TensorFlow](https://www.tensorflow.org/).

[TensorFlow Privacy](https://github.com/tensorflow/privacy) is a  Python library that includes implementations of TensorFlow optimizers for training machine learning models with differential privacy. The library comes with tutorials and analysis tools for computing the privacy guarantees provided.

[TensorFlow Federated (TFF)](https://github.com/tensorflow/federated) is an open-source framework for machine learning and other computations on decentralized data. TFF has been developed to facilitate open research and experimentation with [Federated Learning (FL)](https://ai.googleblog.com/2017/04/federated-learning-collaborative.html), an approach to machine learning where a shared global model is trained across many participating clients that keep their training data locally.

[Privacy on Beam](https://github.com/google/differential-privacy/tree/main/privacy-on-beam) is an end-to-end differential privacy solution built on [Apache Beam](https://beam.apache.org/documentation/). It is intended to be usable by all developers, regardless of their differential privacy expertise.

[PyDP](https://github.com/OpenMined/PyDP) is a Python wrapper for Google's Differential Privacy project.

[PennyLane](https://pennylane.ai) is a cross-platform Python library for [differentiable programming](https://en.wikipedia.org/wiki/Differentiable_programming) of quantum computers. By training a quantum computer the same way as a neural network.

[BoTorch](https://botorch.org) is a library for Bayesian Optimization built on PyTorch.

[PyTorch Geometric (PyG)](https://github.com/rusty1s/pytorch_geometric) is a geometric deep learning extension library for [PyTorch](https://pytorch.org/).

[Skorch](https://github.com/skorch-dev/skorch) is a scikit-learn compatible neural network library that wraps PyTorch.

[Diffprivlib](https://github.com/IBM/differential-privacy-library) is the IBM Differential Privacy Library for experimenting with, investigating and developing applications in, differential privacy.

[Opacus](https://opacus.ai/) is a library that enables training PyTorch models with differential privacy. It supports training with minimal code changes required on the client, has little impact on training performance and allows the client to online track the privacy budget expended at any given moment.

[Smart Noise](https://github.com/opendifferentialprivacy/smartnoise-sdk) is a toolkit that uses state-of-the-art differential privacy (DP) techniques to inject noise into data, to prevent disclosure of sensitive information and manage exposure risk.


## Privacy Learning Resources

[Differential Privacy Blog Series by the National Institute of Standards and Technology(NIST)](https://www.nist.gov/itl/applied-cybersecurity/privacy-engineering/collaboration-space/focus-areas/de-id/dp-blog)

[Apple's Differential Privacy Overview](https://www.apple.com/privacy/docs/Differential_Privacy_Overview.pdf)

[Learning with Privacy at Scale with Apple Machine Learning](https://machinelearning.apple.com/research/learning-with-privacy-at-scale)

[Microsoft Research Differential Privacy Overview](https://www.microsoft.com/en-us/research/publication/differential-privacy/)

[Responsible Machine Learning with Microsoft Azure](https://azure.microsoft.com/en-us/services/machine-learning/responsibleml/)

[Responsible AI Resources with Microsoft AI](https://www.microsoft.com/en-us/ai/responsible-ai-resources)

[Preserve data privacy by using differential privacy and the SmartNoise package](https://docs.microsoft.com/en-us/azure/machine-learning/concept-differential-privacy)

[Open Differential Privacy(OpenDP) Initiative by Microsoft and Harvard](https://projects.iq.harvard.edu/opendp)

[Google's Differential Privacy Library](https://github.com/google/differential-privacy)

[Computing Private Statistics with Privacy on Beam from Google Codelabs](https://codelabs.developers.google.com/codelabs/privacy-on-beam/#0)

[Introducing TensorFlow Privacy: Learning with Differential Privacy for Training Data](https://blog.tensorflow.org/2020/06/introducing-new-privacy-testing-library.html)

[TensorFlow Federated: Machine Learning on Decentralized Data](https://www.tensorflow.org/federated/)

[Federated Analytics: Collaborative Data Science without Data Collection](https://ai.googleblog.com/2020/05/federated-analytics-collaborative-data.html)

[Differentially-Private Stochastic Gradient Descent(DP-SGD)](https://github.com/tensorflow/privacy/blob/master/tutorials/walkthrough/README.md)

[Learning Differential Privacy from Harvard University Privacy Tools Project](https://privacytools.seas.harvard.edu/differential-privacy)

[Harvard University Privacy Tools Project Courses & Educational Materials](https://privacytools.seas.harvard.edu/courses-educational-materials)

[The Weaknesses of Differential Privacy course on Coursera](https://www.coursera.org/lecture/data-results/weaknesses-of-differential-privacy-50Y9k)

[The Differential Privacy of Bayesian Inference](https://privacytools.seas.harvard.edu/publications/differential-privacy-bayesian-inference)

[Simultaneous private learning of multiple concepts](https://privacytools.seas.harvard.edu/publications/simultaneous-private-learning-multiple-concepts)

[The Complexity of Computing the Optimal Composition of Differential Privacy](https://privacytools.seas.harvard.edu/publications/complexity-computing-optimal-composition-differential-privacy)

[Order revealing encryption and the hardness of private learning](https://privacytools.seas.harvard.edu/publications/order-revealing-encryption-and-hardness-private-learning)

[SAP HANA data anonymization using SAP Software Solutions](https://www.sap.com/cmp/dg/crm-xt17-ddm-data-anony/index.html)

[SAP HANA Security using their In-Memory Database](https://www.sap.com/products/hana/features/security.html)

[DEFCON Differential Privacy Training Launch](https://opensource.googleblog.com/2020/08/defcon-differential-privacy-training.html)

[Secure and Private AI course on Udacity](https://www.udacity.com/course/secure-and-private-ai--ud185)

[Differential Privacy - Security and Privacy for Big Data - Part 1 course on Coursera](https://www.coursera.org/learn/security-privacy-big-data)

[Differential Privacy - Security and Privacy for Big Data - Part 2 course on Coursera](https://www.coursera.org/learn/security-privacy-big-data-protection)

[Certified Ethical Emerging Technologist Professional Certificate course on Coursera](https://www.coursera.org/professional-certificates/certified-ethical-emerging-technologist)


# DevOps

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/96352525-abd64b80-1078-11eb-95c8-e29d4c592bec.png">
</p>


## DevOps Tools

[GitHub](https://github.com/) provides hosting for software development version control using Git. It offers all of the distributed version control and source code management functionality of Git as well as adding its own features. It provides access control and several collaboration features such as bug tracking, feature requests, task management, and wikis for every project.

[GitHub Codespaces](https://docs.github.com/en/free-pro-team@latest/github/developing-online-with-codespaces) is an integrated development environment(IDE) on GitHub. That allows developers to develop entirely in the cloud using Visual Studio and Visual Studio Code.

[GitHub Actions](https://docs.github.com/en/actions) will automate, customize, and execute your software development workflows right in your repository with GitHub Actions. You can discover, create, and share actions to perform any job you'd like, including CI/CD, and combine actions in a completely customized workflow.[GitHub Actions for Azure](https://docs.microsoft.com/en-us/azure/developer/github/github-actions) you can create workflows that you can set up in your repository to build, test, package, release and deploy to Azure.Learn more about all other integrations with Azure.

[GitLab](https://about.gitlab.com/) is a web-based DevOps lifecycle tool that provides a Git-repository manager providing wiki, issue-tracking and CI/CD pipeline features, using an open-source license, developed by GitLab Inc.

[Jenkins](https://jenkins.io/) is a free and open source automation server. Jenkins helps to automate the non-human part of the software development process, with continuous integration and facilitating technical aspects of continuous delivery.

[Bitbucket](https://bitbucket.org/) is a web-based version control repository hosting service owned by Atlassian, for source code and development projects that use either Mercurial or Git revision control systems. Bitbucket offers both commercial plans and free accounts. It offers free accounts with an unlimited number of private repositories. Bitbucket integrates with other Atlassian software like Jira, HipChat, Confluence and Bamboo.

[Bamboo](https://www.atlassian.com/software/bamboo) is a continuous integration (CI) server that can be used to automate the release management for a software application, creating a continuous delivery pipeline.

[Codecov](https://codecov.io/) is the leading, dedicated code coverage solution. It provides highly integrated tools to group, merge, archive and compare coverage reports. Whether your team is comparing changes in a pull request or reviewing a single commit, Codecov will improve the code review workflow and quality.

[Drone](https://drone.io/) is a Continuous Delivery system built on container technology. Drone uses a simple YAML configuration file, a superset of docker-compose, to define and execute Pipelines inside Docker containers.

[Travis CI](https://travis-ci.org/) is a hosted continuous integration service used to build and test software projects hosted at GitHub.

[Circle CI](https://circleci.com/) is a continuous integration and continuous delivery platform that helps software teams work smarter, faster.

[Zuul-CI](https://zuul-ci.org/index.html) is a program that drives continuous integration, delivery, and deployment systems with a focus on project gating and interrelated projects. Using the same [Ansible playbooks](https://docs.ansible.com/ansible/latest/user_guide/playbooks.html) to deploy your system and run your tests.

[Artifactory](https://jfrog.com/artifactory/) is a Universal Artifact Repository Manager developed by JFrog. It supports all major packages, enterprise ready security, clustered, HA, Docker registry, multi-site replication and scalable.

[Azure DevOps](https://azure.microsoft.com/en-us/services/devops/?nav=min) is a set of services for teams to share code, track work, and ship software; CLIs Build, deploy, diagnose, and manage multi-platform, scalable apps and services; Azure Pipelines Continuously build, test, and deploy to any platform and cloud; Azure Lab Services Set up labs for classrooms, trials, development and testing, and other scenarios.

[Team City](https://www.jetbrains.com/teamcity/) is a build management and continuous integration server from JetBrains.

[Shippable](https://www.shippable.com/) simplifies DevOps and makes it systematic with an Assembly Line platform that is heterogeneous, flexible, and provides complete visibility across your DevOps workflows.

[Spinnaker](https://www.spinnaker.io/) is an open source, multi-cloud continuous delivery platform for releasing software changes with high velocity and confidence.

[AWS CodeBuild](https://aws.amazon.com/codebuild/) is a fully managed continuous integration service that compiles source code, runs tests, and produces software packages that are ready to deploy. With CodeBuild, you don't need to provision, manage, and scale your own build servers.

[Selenium](https://www.seleniumhq.org/) is a free (open source) automated testing suite for web applications across different browsers and platforms.

[Cucumber](https://cucumber.io/) is a tool based on Behavior Driven Development (BDD) framework which is used to write acceptance tests for the web application. It allows automation of functional validation in easily readable and understandable format (like plain English) to Business Analysts, Developers, and Testers.

[JUnit](https://junit.org/junit5/) is a unit testing framework for the Java programming language.

[Mocha](https://mochajs.org/) is a JavaScript test framework for Node.js programs, featuring browser support, asynchronous testing, test coverage reports, and use of any assertion library.

[Karma](https://karma-runner.github.io/latest/index.html) is a simple tool that allows you to execute JavaScript code in multiple real browsers.

[Jasmine](https://jasmine.github.io/) is an open source testing framework for JavaScript. It aims to run on any JavaScript-enabled platform, to not intrude on the application nor the IDE, and to have easy-to-read syntax.

[Maven](https://maven.apache.org/) is a build automation tool used primarily for Java projects. Maven can also be used to build and manage projects written in C#, Ruby, Scala, and other languages. The Maven project is hosted by the Apache Software Foundation.

[Gradle](https://gradle.org/) is an open-source build-automation system that builds upon the concepts of Apache Ant and Apache Maven and introduces a Groovy-based domain-specific language instead of the XML form used by Apache Maven for declaring the project configuration.

[Chef](https://www.chef.io/) is an effortless Infrastructure Suite offers visibility into security and compliance status across all infrastructure and makes it easy to detect and correct issues long before they reach production.

[Puppet](https://puppet.com/) is an open source tool that makes continuous integration and delivery of your software on traditional or containerized infrastructure easy by pulling together all your existing tools and giving you flexibility to deploy your way.

[Ansible](https://www.ansible.com/) is an open-source software provisioning, configuration management, and application-deployment tool. It runs on many Unix-like systems, and can configure both Unix-like systems as well as Microsoft Windows.

[KubeInit](https://github.com/kubeinit/kubeinit) provides Ansible playbooks and roles for the deployment and configuration of multiple Kubernetes distributions.

[Salt](https://www.saltstack.com/) is Python-based, open-source software for event-driven IT automation, remote task execution, and configuration management. Supporting the "Infrastructure as Code" approach to data center system and network deployment and management, configuration automation, SecOps orchestration, vulnerability remediation, and hybrid cloud control.

[Terraform](https://www.terraform.io/) is an open-source infrastructure as code software tool created by HashiCorp.It enables users to define and provision a datacenter infrastructure using a high-level configuration language known as Hashicorp Configuration Language (HCL), or optionally JSON.

[Consul](https://www.consul.io) is a service networking solution to connect and secure services across any runtime platform and public or private cloud.

[Packer](https://www.packer.io/) is lightweight, runs on every major operating system, and is highly performant, creating machine images for multiple platforms in parallel. Packer does not replace configuration management like Chef or Puppet. In fact, when building images, Packer is able to use tools like Chef or Puppet to install software onto the image.

[Nomad](https://www.nomadproject.io/) is a highly available, distributed, data-center aware cluster and application scheduler designed to support the modern datacenter with support for long-running services, batch jobs, and much more.

[Vagrant](https://www.vagrantup.com/) is a tool for building and managing virtual machine environments in a single workflow. With an easy-to-use workflow and focus on automation, Vagrant lowers development environment setup time and increases production parity.

[Vault](https://www.hashicorp.com/products/vault/) is a tool for securely accessing secrets. A secret is anything that you want to tightly control access to, such as API keys, passwords, certificates, and more. Vault provides a unified interface to any secret, while providing tight access control and recording a detailed audit log.

[CFEngine](https://cfengine.com/) is an open-source configuration management system, written by Mark Burgess.Its primary function is to provide automated configuration and maintenance of large-scale computer systems, including the unified management of servers, desktops, consumer and industrial devices, embedded networked devices, mobile smartphones, and tablet computers.

[Octpus Deploy](https://octopus.com/) is the deployment automation server for your entire team, designed to make it easy to orchestrate releases and deploy applications, whether on-premises or in the cloud.

[AWS CodeDeploy](https://aws.amazon.com/codedeploy/) is a fully managed deployment service that automates software deployments to a variety of compute services such as Amazon EC2, AWS Fargate, AWS Lambda, and your on-premises servers. AWS CodeDeploy makes it easier for you to rapidly release new features, helps you avoid downtime during application deployment, and handles the complexity of updating your applications.

[Kubernetes](https://kubernetes.io/) is an open-source container-orchestration system for automating application deployment, scaling, and management. It was originally designed by Google, and is now maintained by the Cloud Native Computing Foundation.

[Docker](https://www.docker.com/) is a set of platform as a service products that use OS-level virtualization to deliver software in packages called containers. Containers are isolated from one another and bundle their own software, libraries and configuration files; they can communicate with each other through well-defined channels. All containers are run by a single operating-system kernel and are thus more lightweight than virtual machines.

[PowerShell/PowerShell Core](https://docs.microsoft.com/en-us/powershell/) is a cross-platform (Windows, Linux, and macOS) automation and configuration tool/framework that works well with your existing tools and is optimized for dealing with structured data (e.g. JSON, CSV, XML, etc.), REST APIs, and object models. It includes a command-line shell, an associated scripting language and a framework for processing cmdlets.

[Hyper-V](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/) creates virtual machines on Windows 10. Hyper-V can be enabled in many ways including using the Windows 10 control panel, PowerShell or using the Deployment Imaging Servicing and Management tool (DISM).

[Cloud Hypervisor](https://github.com/cloud-hypervisor/cloud-hypervisor) is an open source Virtual Machine Monitor (VMM) that runs on top of [KVM](https://www.kernel.org/doc/Documentation/virtual/kvm/api.txt). The project focuses on exclusively running modern, cloud workloads, on top of a limited set of hardware architectures and platforms. Cloud workloads refers to those that are usually run by customers inside a cloud provider. Cloud Hypervisor is implemented in [Rust](https://www.rust-lang.org/) and is based on the [rust-vmm](https://github.com/rust-vmm) crates.

[VMware vSphere Hypervisor](https://www.vmware.com/products/vsphere-hypervisor.html) is a bare-metal hypervisor that virtualizes servers; allowing you to consolidate your applications while saving time and money managing your IT infrastructure.

[VMware vSphere](https://www.vmware.com/products/vsphere.html) is the industry-leading compute virtualization platform, and your first step to application modernization. It has been rearchitected with native Kubernetes to allow customers to modernize the 70 million+ workloads now running on vSphere.

[VMware Tanzu](https://tanzu.vmware.com/tanzu) is a centralized management platform for consistently operating and securing your Kubernetes infrastructure and modern applications across multiple teams and private/public clouds.

[Rancher](https://rancher.com/) is a complete software stack for teams adopting containers. It addresses the operational and security challenges of managing multiple Kubernetes clusters, while providing DevOps teams with integrated tools for running containerized workloads.

[K3s](https://github.com/rancher/k3s) is a highly available, certified Kubernetes distribution designed for production workloads in unattended, resource-constrained, remote locations or inside IoT appliances.

[Rook](https://rook.io/) is an open source cloud-native storage orchestrator for Kubernetes that turns distributed storage systems into self-managing, self-scaling, self-healing storage services. It automates the tasks of a storage administrator: deployment, bootstrapping, configuration, provisioning, scaling, upgrading, migration, disaster recovery, monitoring, and resource management.

[Google Kubernetes Engine (GKE)](https://cloud.google.com/kubernetes-engine/) is a managed, production-ready environment for deploying containerized applications.

[Anthos](https://cloud.google.com/anthos/docs/concepts/overview) is a modern application management platform that provides a consistent development and operations experience for cloud and on-premises environments.

[AWS ECS](https://aws.amazon.com/ecs/) is a highly scalable, high-performance container orchestration service that supports Docker containers and allows you to easily run and scale containerized applications on AWS. Amazon ECS eliminates the need for you to install and operate your own container orchestration software, manage and scale a cluster of virtual machines, or schedule containers on those virtual machines.

[Apache Mesos](http://mesos.apache.org/) is a cluster manager that provides efficient resource isolation and sharing across distributed applications, or frameworks. It can run Hadoop, Jenkins, Spark, Aurora, and other frameworks on a dynamically shared pool of nodes.

[Apache Spark](https://spark.apache.org/) is a unified analytics engine for big data processing, with built-in modules for streaming, SQL, machine learning and graph processing.

[Apache Hadoop](http://hadoop.apache.org/) is a framework that allows for the distributed processing of large data sets across clusters of computers using simple programming models. It is designed to scale up from single servers to thousands of machines, each offering local computation and storage. Rather than rely on hardware to deliver high-availability, the library itself is designed to detect and handle failures at the application layer, so delivering a highly-available service on top of a cluster of computers, each of which may be prone to failures.

[Microsoft Azure](https://azure.microsoft.com/en-us/) is a cloud computing service created by Microsoft for building, testing, deploying, and managing applications and services through Microsoft-managed data centers.

[Azure Functions](https://azure.microsoft.com/en-us/services/functions/) is a solution for easily running small pieces of code, or "functions," in the cloud. You can write just the code you need for the problem at hand, without worrying about a whole application or the infrastructure to run it.

[Rkt](https://coreos.com/rkt/) is a pod-native container engine for Linux. It is composable, secure, and built on standards.

[AWS Lambda](https://aws.amazon.com/lambda/) is an event-driven, serverless computing platform provided by Amazon as a part of the Amazon Web Services. It is a computing service that runs code in response to events and automatically manages the computing resources required by that code.

[Helm](https://helm.sh/) is the Kubernetes Package Manager.

[Kubespray](https://kubespray.io/) is a tool that combines Kubernetes and Ansible to easily install Kubernetes clusters that can be deployed on [AWS](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/aws.md), GCE, [Azure](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/azure.md), [OpenStack](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/openstack.md), [vSphere](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/vsphere.md), [Packet](https://github.com/kubernetes-sigs/kubespray/blob/master/docs/packet.md) (bare metal), Oracle Cloud Infrastructure (Experimental), or Baremetal

[Red Hat OpenShift](https://www.openshift.com/) is focused on security at every level of the container stack and throughout the application lifecycle. It includes long-term, enterprise support from one of the leading Kubernetes contributors and open source software companies.

[OpenShift Hive](https://github.com/openshift/hive) is an operator which runs as a service on top of Kubernetes/OpenShift. The Hive service can be used to provision and perform initial configuration of OpenShift 4 clusters.

[OKD](https://okd.io/) is a community distribution of Kubernetes optimized for continuous application development and multi-tenant deployment. OKD adds developer and operations-centric tools on top of Kubernetes to enable rapid application development, easy deployment and scaling, and long-term lifecycle maintenance for small and large teams.

[Odo](https://odo.dev/) is a fast, iterative, and straightforward CLI tool for developers who write, build, and deploy applications on Kubernetes and OpenShift.

[Kata Operator](https://github.com/openshift/kata-operator) is an operator to perform lifecycle management (install/upgrade/uninstall) of [Kata Runtime](https://katacontainers.io/) on Openshift as well as Kubernetes cluster.

[Knative](https://knative.dev/) is a Kubernetes-based platform to build, deploy, and manage modern serverless workloads. Knative takes care of the operational overhead details of networking, autoscaling (even to zero), and revision tracking.

[Etcd](https://etcd.io/) is a distributed key-value store that provides a reliable way to store data that needs to be accessed by a distributed system or cluster of machines. Etcd is used as the backend for service discovery and stores cluster state and configuration for Kubernetes.

[OpenStack](https://www.openstack.org/) is a free and open-source software platform for cloud computing, mostly deployed as infrastructure-as-a-service that controls large pools of compute, storage, and networking resources throughout a datacenter, managed through a dashboard or via the OpenStack API. OpenStack works with popular enterprise and open source technologies making it ideal for heterogeneous infrastructure.

[Cloud Foundry](https://www.cloudfoundry.org/) is an open source, multi cloud application platform as a service that makes it faster and easier to build, test, deploy and scale applications, providing a choice of clouds, developer frameworks, and application services. It is an open source project and is available through a variety of private cloud distributions and public cloud instances.

[Splunk](https://www.splunk.com/) software is used for searching, monitoring, and analyzing machine-generated big data, via a Web-style interface.

[Prometheus](https://prometheus.io/) is a free software application used for event monitoring and alerting. It records real-time metrics in a time series database (allowing for high dimensionality) built using a HTTP pull model, with flexible queries and real-time alerting.

[Loki](https://grafana.com/oss/loki/) is a horizontally-scalable, highly-available, multi-tenant log aggregation system inspired by Prometheus. It is designed to be very cost effective and easy to operate. It does not index the contents of the logs, but rather a set of labels for each log stream.

[Thanos](https://thanos.io/) is a set of components that can be composed into a highly available metric system with unlimited storage capacity, which can be added seamlessly on top of existing Prometheus deployments.

[Container Storage Interface (CSI)](https://www.architecting.it/blog/container-storage-interface/) is an API that lets container orchestration platforms like Kubernetes seamlessly communicate with stored data via a plug-in.

[OpenEBS](https://openebs.io/) is a Kubernetes-based tool to create stateful applications using Container Attached Storage.

[ElasticSearch](https://www.elastic.co/) is a search engine based on the Lucene library. It provides a distributed, multitenant-capable full-text search engine with an HTTP web interface and schema-free JSON documents. Elasticsearch is developed in Java.

[Logstash](https://www.elastic.co/products/logstash) is a tool for managing events and logs. When used generically, the term encompasses a larger system of log collection, processing, storage and searching activities.

[Kibana](https://www.elastic.co/products/kibana) is an open source data visualization plugin for Elasticsearch. It provides visualization capabilities on top of the content indexed on an Elasticsearch cluster. Users can create bar, line and scatter plots, or pie charts and maps on top of large volumes of data.

[New Relic](https://newrelic.com/) is a SaaS-based monitoring tool that fully supports the way DevOps teams work in the modern enterprise by streamlining your workflows with today's collaboration software and orchestration tools like Puppet, Chef, and Ansible.

[Nagios](https://www.nagios.org/) is a free and open source computer-software application that monitors systems, networks and infrastructure. Nagios offers monitoring and alerting services for servers, switches, applications and services. It alerts users when things go wrong and alerts them a second time when the problem has been resolved.

[SonarQube](https://www.sonarqube.org/) is an open-source platform developed by SonarSource for continuous inspection of code quality to perform automatic reviews with static analysis of code to detect bugs, code smells, and security vulnerabilities on 20+ programming languages.

[Genie](https://netflix.github.io/genie) is a federated job orchestration engine developed by Netflix. Genie provides REST APIs to run a variety of big data jobs like Hadoop, Pig, Hive, Spark, Presto, Sqoop and more. It also provides APIs for managing the metadata of many distributed processing clusters and the commands and applications which run on them.

[Inviso](https://github.com/Netflix/inviso) is a lightweight tool that provides the ability to search for Hadoop jobs, visualize the performance, and view cluster utilization.

[Fenzo](https://github.com/Netflix/Fenzo) is a scheduler Java library for Apache Mesos frameworks that supports plugins for scheduling optimizations and facilitates cluster autoscaling.

[Dynomite](https://github.com/Netflix/dynomite) is a thin, distributed dynamo layer for different storage engines and protocols, which includes [Redis](http://redis.io/) and [Memcached](http://www.memcached.org/). Dynomite supports multi-datacenter replication and is designed for High Availability(HA).

[Dyno](https://github.com/Netflix/dynomite) is a tool that is used to scale a Java client application utilizing [Dynomite](https://github.com/Netflix/dynomite).

[Raigad](https://github.com/Netflix/Raigad) is a process/tool that runs alongside Elasticsearch to automate backup/recovery, Deployments and Centralized Configuration management.

[Priam](https://github.com/Netflix/Priam) is a process/tool that runs alongside Apache Cassandra to automate backup/recovery, Deployments and Centralized Configuration management.

[Chaos Monkey](https://github.com/Netflix/chaosmonkey) is a resiliency tool  used to randomly terminates virtual machine instances and containers that run inside of your production environment. Chaos Monkey should work with any backend that [Spinnaker](http://www.spinnaker.io/) supports (AWS, Google Compute Engine, Microsoft Azure, Kubernetes, and Cloud Foundry).

[Falcor](https://netflix.github.io/falcor/) is a JavaScript library for efficient data fetching. Falcor lets you represent all your remote data sources as a single domain model via a virtual JSON graph, whether in memory on the client or over the network on the server.

[Restify](https://github.com/restify/node-restify) is a framework, utilizing [connect](https://github.com/senchalabs/connect) style middleware for building REST APIs.

[Traefik](https://traefik.io/traefik/) is an open source Edge Router that makes publishing your services a fun and easy experience. It receives requests on behalf of your system and finds out which components are responsible for handling them. What sets Traefik apart, besides its many features, is that it automatically discovers the right configuration for your services.

[Jira](https://www.atlassian.com/software/jira) is a proprietary issue tracking product developed by Atlassian that allows bug tracking and agile project management.

[Pivotal Tracker](https://www.pivotaltracker.com/) is the agile project management tool of choice for developers around the world for real-time collaboration around a shared, prioritized backlog.

[Trello](https://trello.com/) is a web-based Kanban-style list-making application that gives you perspective over all your projects, at work and at home.

[Microsoft Teams](https://teams.microsoft.com/start) is the hub for team collaboration in Office 365 that integrates the people, content, and tools your team needs to be more engaged and effective.

[Slack](https://slack.com/) is a cloud-based proprietary instant messaging platform developed by Slack Technologies.

[OpsGenie](https://www.opsgenie.com/) is a cloud-based service for dev & ops teams, providing reliable alerts, on-call schedule management and escalations. OpsGenie integrates with monitoring tools & services, ensures the right people are notified.

[Pagerduty](https://www.pagerduty.com/) automates processes built on best practices, allowing you to focus on higher value parts of incident response. Granular and scalable permissions enable teams to administer and operate independently while controlling visibility.

[Veracode](https://www.veracode.com/) is a leading provider of enterprise-class application security, seamlessly integrating agile security solutions for organizations around the globe. In addition to application security services and secure devops services, Veracode provides a full security assessment to ensure your website and applications are secure, and ensures full enterprise data protection.

## DevOps Learning Resources

[DevOps Engineering on AWS from AWS Training](https://aws.amazon.com/training/course-descriptions/devops-engineering/)

[AWS Certified DevOps Engineer - Professional from A Cloud Guru](https://acloud.guru/learn/aws-certified-devops-engineer-professional)

[Microsoft Certified: DevOps Engineer Expert Cert.](https://docs.microsoft.com/en-us/learn/certifications/devops-engineer)

[Introduction to Azure DevOps from A Cloud Guru](https://acloud.guru/learn/introduction-to-azure-devops)

[Architecting with Google Compute Engine](https://google.qwiklabs.com/courses/1421?utm_source=gcp_training&utm_medium=website&utm_campaign=cgc)

[Architecting with Google Kubernetes Engine in Google Cloud](https://google.qwiklabs.com/courses/1232?utm_source=gcp_training&utm_medium=website&utm_campaign=cgc)

[VMware Training and Certification Program](https://www.vmware.com/education-services/certification.html)

[Cloudera Certification Program](https://www.cloudera.com/about/training/certification.html)

[Salesforce Certification Program](https://trailhead.salesforce.com/credentials/administratoroverview)

[Salesforce Superbadges](https://trailhead.salesforce.com/superbadges)

[Red Hat Training and Certification Program](https://www.redhat.com/en/services/training-and-certification)

[Linux Foundation Training and Certification Program](https://training.linuxfoundation.org/certification/)

[Linux Professional Institute(LPI) Training and Certification](https://www.lpi.org)

[Learn DevOps with Online Courses and Lessons from edX](https://www.edx.org/learn/devops)

[Top DevOps Courses Online from Udemy](https://www.udemy.com/topic/devops/)

[Devops Courses from Coursera](https://www.coursera.org/courses?languages=en&query=devops)

# .NET Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/93719689-0d1e0400-fb39-11ea-82e5-331a8ff8060d.png">
</p>

## .NET Learning Resources

[.NET](https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet) is a developer platform with tools and libraries for building any type of app, including web, mobile, desktop, games, IoT, cloud, and microservices.

[Announcing .NET 6](https://devblogs.microsoft.com/dotnet/announcing-net-6/)

[.NET documentation](https://docs.microsoft.com/en-us/dotnet/fundamentals/)

[C# documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)

[Getting started with .NET](https://docs.microsoft.com/en-us/dotnet/standard/get-started)

[.NET Application Architecture Guide](https://dotnet.microsoft.com/learn/dotnet/architecture-guides)

[Intro .NET Guide by JetBrains ](https://blog.jetbrains.com/dotnet/2020/07/09/introducing-the-net-guide-tutorials-and-tips-tricks-for-net-rider-and-resharper/)

[.NET on Microsoft Learn | Microsoft Docs](https://docs.microsoft.com/en-us/learn/dotnet/)

[Top .NET Courses Online | Udemy](https://www.udemy.com/topic/net/)

[Top ASP.NET Core Courses Online | Udemy](https://www.udemy.com/topic/aspnet-core/)

[Learn Parallel Programming with C# and .NET | Udemy](https://www.udemy.com/course/parallel-dotnet/)

[Learn to build an e-commerce app with .Net Core and Angular | Udemy](https://www.udemy.com/course/learn-to-build-an-e-commerce-app-with-net-core-and-angular/)

[Dependency Injection in C# and .NET with the Autofac Library | Udemy](https://www.udemy.com/course/di-ioc-dotnet/)

[Modern Application Development with .NET on AWS Specialization | Coursera](https://www.coursera.org/specializations/aws-net-serverless-development)

[Introducing .NET Core Course | Coursera](https://www.coursera.org/lecture/develop-windows-apps-gcp/introducing-net-core-JkSfp)

[Learn .NET with Online Courses | edX](https://www.edx.org/learn/.net)

[.NET Training Course | LearningTree](https://www.learningtree.com/training-directory/net-visual-studio-training/)

[.NET Training: Introduction | Pluralsight](https://www.pluralsight.com/courses/becoming-dotnet-developer)

## .NET Tools and Frameworks

[Visual Studio](https://visualstudio.microsoft.com/) is an integrated development environment (IDE) from Microsoft; which is a feature-rich application that can be used for many aspects of software development. Visual Studio makes it easy to edit, debug, build, and publish your app. By using Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, and Windows Store.

[Visual Studio Code](https://code.visualstudio.com/) is a code editor redefined and optimized for building and debugging modern web and cloud applications.

[Code Server](https://coder.com/) is a tool that allows you to run [VS Code](https://code.visualstudio.com/) on any machine anywhere and access it in the browser.

[Language Server Protocol (LSP)](https://microsoft.github.io/language-server-protocol/) is a tool that defines the protocol used between an editor or IDE and a language server that provides language features like auto complete, go to definition, find all references.

[Tabnine](https://marketplace.visualstudio.com/items?itemName=TabNine.tabnine-vscode) is the AI code completion tool trusted by millions of developers to code faster with fewer errors. Whether you are a new dev or a seasoned pro, working solo or part of a team, Tabnine will help push your productivity to new heights while cutting your QA time.

[.NET Core](https://docs.microsoft.com/en-us/dotnet/core/introduction) is a cross-platform .NET implementation for websites, servers, and console apps on Windows, Linux, and macOS.The .NET Framework supports websites, services, desktop apps, and more on Windows. Xamarin/Mono is a .NET implementation for running apps on all the major mobile operating systems.

[.NET runtime](https://github.com/dotnet/runtime) is a collection of libraries and shared host (dotnet) installers for all supported platforms, as well as the sources to .NET runtime and libraries.

[ASP.NET Core](https://asp.net/) is a cross-platform .NET framework for building modern cloud-based web applications on Windows, Mac, or Linux.

[Mono](https://www.mono-project.com/) is a software platform designed to allow developers to easily create cross platform applications. It is an open source implementation of Microsoft's .NET Framework based on the ECMA standards for C# and the Common Language Runtime.

[Rider](https://www.jetbrains.com/rider/) is a fast and powerful, cross-platform .NET IDE devloped by JetBrains to develop .NET, ASP.NET, .NET Core, Xamarin; or Unity applications for Windows, Mac, Linux.

[Resharper](https://www.jetbrains.com/resharper/) is a [Visual Studio](https://visualstudio.microsoft.com/) Extension for .NET Developers that has On-the-fly code quality analysis for C#, VB.NET, XAML, ASP.NET, ASP.NET MVC, JavaScript, TypeScript, CSS, HTML, and XML. Letting you know right away if your code needs to be improved.

[dotTrace](https://www.jetbrains.com/profiler/) is an .NET performance Profiler developed by Jet Brains. It helps users locate performance bottlenecks in a variety of .NET applications: desktop applications, .NET Core, ASP.NET, ASP.NET Core applications hosted on IIS or IIS Express web servers, Silverlight, WCF services, Windows services, Universal Windows Platform applications, and unit tests.

[dotMemory](https://www.jetbrains.com/dotmemory/) is an .NET memory Profiler developed by Jet Brains. It allows the user to analyze memory usage in a variety of .NET and .NET Core applications: desktop applications, Windows services, ASP.NET web applications, IIS, IIS Express, arbitrary .NET processes, and more.

[dotCover](https://www.jetbrains.com/dotcover/) is an .NET unit test runner and code coverage tool developed by Jet Brains. It helps the user figure out on-the-fly which unit tests are affected by your latest code changes, and automatically re-runs the affected tests for you. The continuous testing mode can be switched on for any unit test session.

[Avalonia](https://avaloniaui.net/) is a cross-platform XAML-based UI framework providing a flexible styling system and supporting a wide range of Operating Systems such as Windows via .NET Framework and .NET Core, Linux via Xorg, macOS.

[Polly](https://github.com/App-vNext/Polly) is a .NET resilience and transient-fault-handling library that allows developers to express policies such as Retry, Circuit Breaker, Timeout, Bulkhead Isolation, and Fallback in a fluent and thread-safe manner.

[IdentityServer](https://identityserver.io/) is a free, open source [OpenID Connect](https://openid.net/connect/) and [OAuth 2.0](https://tools.ietf.org/html/rfc6749) framework for ASP.NET Core. IdentityServer4 incorporates all the protocol implementations and extensibility points needed to integrate token-based authentication, single-sign-on and API access control in your applications.

[ILSpy](https://github.com/icsharpcode/ILSpy) is the open-source .NET assembly browser and decompiler.

[Hangfire](https://www.hangfire.io/) is an easy way to perform background job processing in your .NET and .NET Core applications with no Windows Service or Task Scheduler required.

[React Native Windows](https://microsoft.github.io/react-native-windows/) is a framework for building native Windows apps with React. [React Native](https://reactnative.dev/) is a framework developed by Facebook that enables you to build world-class application experiences on native platforms using a consistent developer experience based on JavaScript and React.

[ReactiveUI](https://reactiveui.net/) is a composable, cross-platform model-view-viewmodel framework for all .NET platforms that is inspired by functional reactive programming, which is a paradigm that allows you to abstract mutable state away from your user interfaces and express the idea around a feature in one readable place and improve the testability of your application.

[Refit](https://reactiveui.github.io/refit/) is the automatic type-safe REST library for .NET Core, Xamarin and .NET.It's heavily inspired by Square's Retrofit library, Refit turns your REST API into a live interface.

[MAUI](https://github.com/dotnet/maui) is the .NET Multi-platform App UI, a framework for building native device applications spanning mobile, tablet, and desktop.

[Quasar](https://github.com/quasar/Quasar) is a fast and light-weight remote administration tool coded in C#. The usage ranges from user support through day-to-day administrative work to employee monitoring. Providing high stability and an easy-to-use user interface, Quasar is the perfect remote administration solution for you.

# C# Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/94306457-d6c0fa00-ff27-11ea-85dc-83dbb8f3e3e6.png">
  <br />

</p>

**[Start building with C# on Azure](https://docs.microsoft.com/en-us/azure/search/tutorial-csharp-create-first-app)**

**[C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)**

## C# Learning  Resources

[C#](https://docs.microsoft.com/en-us/dotnet/csharp/) is a modern and object-oriented programming language developed by Microsoft to write any application using the C# programming language on the .NET platform.

[Taking your first steps with C#](https://docs.microsoft.com/en-us/learn/paths/csharp-first-steps/)

[Learning C#](https://dotnet.microsoft.com/learn/csharp)

[C# development with Visual Studio](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/)

[C# programming with Visual Studio Code](https://code.visualstudio.com/Docs/languages/csharp)

[Working with data in C#](https://docs.microsoft.com/en-us/learn/paths/csharp-data/)

[C# Tutorial by W3Schools](https://www.w3schools.com/cs/)

[Windows Forms for .NET 5 and .NET Core 3.1](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-5.0)

[Xamarin documentation](https://docs.microsoft.com/en-us/xamarin/)

[Advanced Topics in C# by Udemy](https://www.udemy.com/course/advanced-topics-csharp/)

[The complete C# tutorial](https://csharp.net-tutorials.com/)

[Unity C# Survival Guide](https://learn.unity.com/course/unity-c-survival-guide)

[RabbitMQ .NET/C# Client API](https://www.rabbitmq.com/dotnet-api-guide.html)

## Tools

[Mono](https://www.mono-project.com/) is a software platform designed to allow developers to easily create cross platform applications. It is an open source implementation of Microsoft's .NET Framework based on the ECMA standards for C# and the Common Language Runtime.

[Visual Studio](https://visualstudio.microsoft.com/) is an integrated development environment (IDE) from Microsoft; which is a feature-rich application that can be used for many aspects of software development. Visual Studio makes it easy to edit, debug, build, and publish your app. By using Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, and Windows Store.

[MSBuild](https://github.com/dotnet/msbuild) is the build platform for .NET and Visual Studio. MSBuild, provides an XML schema for a project file that controls how the build platform processes and builds software. Visual Studio uses MSBuild to perform team builds through Azure DevOps Server, but MSBuild can run without Visual Studio.

[Roslyn](https://docs.microsoft.com/dotnet/csharp/roslyn-sdk/) is a .NET compiler developed by Microsoft that provides C# and Visual Basic languages with rich code analysis APIs.

[Bot Framework](https://github.com/microsoft/botframework-sdk) is a framework developed by Microsoft that provides the most comprehensive experience for building conversation applications. Developers can model and build sophisticated conversation using their favorite programming languages including C#, JS, Python and Java or using Bot Framework Composer, an open-source, visual authoring canvas for developers and multi-disciplinary teams to design and build conversational experiences with Language.

[Uno Platform](https://platform.uno/) is a Universal Windows Platform Bridge that allows UWP-based code (C# and XAML) to run on iOS, Android, macOS, WebAssembly, Linux and Windows 7. It provides the full definitions of the UWP [Windows 10 2004 (19041)](https://docs.microsoft.com/en-us/windows/uwp/whats-new/windows-10-build-19041), and the implementation of a growing number of parts of the UWP API, such as Windows.UI.Xaml, to enable UWP and WinUI applications to run on these platforms.

[Rider](https://www.jetbrains.com/rider/) is a fast and powerful, cross-platform .NET IDE devloped by JetBrains to develop .NET, ASP.NET, .NET Core, Xamarin; or Unity applications for Windows, Mac, Linux.

[Resharper](https://www.jetbrains.com/resharper/) is a [Visual Studio](https://visualstudio.microsoft.com/) Extension for .NET Developers that has On-the-fly code quality analysis for C#, VB.NET, XAML, ASP.NET, ASP.NET MVC, JavaScript, TypeScript, CSS, HTML, and XML. Letting you know right away if your code needs to be improved.

[dotPeek](https://www.jetbrains.com/decompiler/) is a tool developed by JetBrains based on ReSharper's bundled decompiler. It can reliably decompile any .NET assembly into equivalent C# or CIL code.

[dotTrace](https://www.jetbrains.com/profiler/) is an .NET performance Profiler developed by Jet Brains. It helps users locate performance bottlenecks in a variety of .NET applications: desktop applications, .NET Core, ASP.NET, ASP.NET Core applications hosted on IIS or IIS Express web servers, Silverlight, WCF services, Windows services, Universal Windows Platform applications, and unit tests.

[dotMemory](https://www.jetbrains.com/dotmemory/) is an .NET memory Profiler developed by Jet Brains. It allows the user to analyze memory usage in a variety of .NET and .NET Core applications: desktop applications, Windows services, ASP.NET web applications, IIS, IIS Express, arbitrary .NET processes, and more.

[dotCover](https://www.jetbrains.com/dotcover/) is an .NET unit test runner and code coverage tool developed by Jet Brains. It helps the user figure out on-the-fly which unit tests are affected by your latest code changes, and automatically re-runs the affected tests for you. The continuous testing mode can be switched on for any unit test session.

[Json.NET](https://www.newtonsoft.com/json) is a popular high-performance JSON framework for .NET.

[Quasar](https://github.com/quasar/Quasar) is a fast and light-weight remote administration tool coded in C#. The usage ranges from user support through day-to-day administrative work to employee monitoring. Providing high stability and an easy-to-use user interface, Quasar is the perfect remote administration solution for you.

[CodeMaid](https://github.com/codecadwallader/codemaid) is an open source Visual Studio extension to cleanup and simplify our C#, C++, F#, VB, PHP, PowerShell, JSON, XAML, XML, ASP, HTML, CSS, LESS, SCSS, JavaScript and TypeScript coding.

[.NET Fiddle](https://dotnetfiddle.net/) is an advanced online compiler for C# that allows you to create, run and share your code online.

[Octopus Deploy](https://octopus.com/) is a single place for your team to manage releases, automate deployments, and automate the runbooks that keeps your software operating.

[Appveyor](https://ci.appveyor.com/) is a cloud-based continuous integration system that integrates natively with your source control and allows CI configuration files to live alongside your projects.

[AppHarbor](https://appharbor.com/) is a .NET Platform-as-a-Service that let's developers deploy and scale any standard .NET application to the cloud.

[ANTLR (ANother Tool for Language Recognition)](https://www.antlr.org/) is a powerful parser generator for reading, processing, executing, or translating structured text or binary files. It's widely used to build languages, tools, and frameworks. From a grammar, ANTLR generates a parser that can build parse trees and also generates a listener interface that makes it easy to respond to the recognition of phrases of interest.

[AutoRest](https://github.com/Azure/autorest) is a tool generates client libraries for accessing RESTful web services using the [OpenAPI Specification](https://github.com/OAI/OpenAPI-Specification) format. It Supports C#, PowerShell, Go, Java, Node.js, TypeScript, Python, Ruby.

[Markdig](https://github.com/lunet-io/markdig) is a fast, powerful, [CommonMark](https://commonmark.org/) compliant, extensible Markdown processor for .NET.


# F# Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/94306464-da548100-ff27-11ea-8934-e9830a549cf1.png">
  <br />
</p>

**[Start building with F# on Azure](https://docs.microsoft.com/en-us/dotnet/fsharp/using-fsharp-on-azure/)**

**[F# Documentation](https://docs.microsoft.com/en-us/dotnet/fsharp/)**

##  F# Learning Resources

[F#](https://fsharp.org/) is a mature, open source, cross-platform, functional-first programming language. It empowers users and organizations to tackle complex computing problems with simple, maintainable and robust code.

[What is F#](https://docs.microsoft.com/en-us/dotnet/fsharp/what-is-fsharp)

[F#, the Functional programming for .NET](https://dotnet.microsoft.com/languages/fsharp)

[Cloud Programming with F#](https://fsharp.org/guides/cloud/)

[F# style guide](https://docs.microsoft.com/en-us/dotnet/fsharp/style-guide/)

[F# Programming Wikibook](http://en.wikibooks.org/wiki/Programming:F_Sharp)

[F# Developer Network (FSDN)](http://fsdn.azurewebsites.net/)

[Learning F# from The F# Software Foundation ](https://fsharp.org/learn/)

[F# Programming groups | Meetup](https://www.meetup.com/topics/f-programming/)

## Tools

[Python.NET](http://pythonnet.github.io/) is a package that gives Python programmers nearly seamless integration with the .NET Common Language Runtime (CLR) and provides a powerful application scripting tool for .NET developers. It allows Python code to interact with the CLR, and may also be used to embed Python into a .NET application.

[Fable](https://fable.io) is an F# to JavaScript compiler powered by [Babel](https://babeljs.io/), designed to make F# a first-class citizen of the JavaScript ecosystem.

[.NET for Apache Spark](https://dot.net/spark) provides high performance APIs for using Apache Spark from C# and F#. With these .NET APIs, you can access the most popular Dataframe and SparkSQL aspects of Apache Spark, for working with structured data, and Spark Structured Streaming, for working with streaming data. .NET for Apache Spark runs on Windows, Linux, and macOS using .NET Core, or Windows using .NET Framework. It also runs on all major cloud providers including [Azure HDInsight Spark](https://github.com/dotnet/spark/blob/master/deployment/README.md#azure-hdinsight-spark), [Amazon EMR Spark](https://github.com/dotnet/spark/blob/master/deployment/README.md#amazon-emr-spark), [AWS](https://github.com/dotnet/spark/blob/master/deployment/README.md#databricks) & [Azure](https://github.com/dotnet/spark/blob/master/deployment/README.md#databricks) Databricks.

[Giraffe](https://giraffe.wiki/) is a functional ASP.NET Core micro web framework for building rich web applications.

[Suave](https://suave.io/) is a simple web development F# library providing a lightweight web server and a set of combinators to manipulate route flow and task composition. Suave supports Websocket, HTTPS, multiple TCP/IP bindings, Basic Access Authentication, Keep-Alive.

[FsCheck](https://fscheck.github.io/FsCheck/) is a tool for testing .NET programs automatically. The programmer provides a specification of the program, in the form of properties which functions, methods or objects should satisfy, and FsCheck then tests that the properties hold in a large number of randomly generated cases.

[Elmish](https://elmish.github.io/elmish/) implements core abstractions for F# apps that can be used to build applications following the “model view update” style of architecture made famous by Elm. The library however does not model any "view" and is intended for use in conjuction with a DOM/renderer, like React/ReactNative or VirtualDOM.

[Saturn](https://saturnframework.org/) is a web development framework written in F# which implements the server-side MVC pattern. Many of its components and concepts will seem familiar to anyone with experience in other web frameworks like Ruby on Rails or Python’s Django.

[Pulumi](https://www.pulumi.com/) is Infrastructure as Code SDK is the easiest way to create and deploy cloud software that use containers, serverless functions, hosted services, and infrastructure, on any cloud. Simply write code in your favorite language and Pulumi will automatically provisions and manages your AWS, Azure, Google Cloud Platform, and/or Kubernetes resources, using an infrastructure-as-code approach.

[FsPickler](https://github.com/mbraceproject/FsPickler) is a serialization library that facilitates the distribution of .NET objects. The implementation focuses on performance and completeness in supported types, including F# types. It supports multiple, pluggable serialization formats including Binary, Xml, JSON and BSON. The library is based on the functional programming concept of [pickler combinators](https://www.microsoft.com/en-us/research/publication/functional-pearl-pickler-combinators/) which has been adapted to accommodate the object oriented nature of the .NET framework.

[Paket](https://fsprojects.github.io/Paket/) is a dependency manager for .NET with support for NuGet packages and git repositories.

[Fantomas](https://fsprojects.github.io/fantomas-tools/#/fantomas/preview) is a F# source code formatter.

[SQLProvider](http://fsprojects.github.io/SQLProvider) is a general F# SQL database erasing type provider, supporting LINQ queries, schema exploration, individuals, and CRUD operations.

[FsUnit](http://fsprojects.github.io/FsUnit/) makes unit-testing with F# more enjoyable. It adds a special syntax to your favorite .NET testing framework.

# PowerShell Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/115297904-9918fe00-a111-11eb-887c-774b939f1bdf.png">
  <br />
</p>


## PowerShell Learning Resources

[Windows Remote Management in Ansible using PowerShell](https://docs.ansible.com/ansible/latest/user_guide/windows_winrm.html)

[Getting Started with PowerShell](https://docs.microsoft.com/en-us/powershell/)

[Start building with PowerShell on Azure](https://docs.microsoft.com/en-us/powershell/azure/install-az-ps)

[Azure PowerShell Documentation](https://docs.microsoft.com/en-us/powershell/azure/)

[PowerShell in Azure Cloud Shell](https://aka.ms/cloudshell/powershell-docs)

[Azure Functions using PowerShell](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-first-function-vs-code?pivots=programming-language-powershell)

[Azure Automation runbooks](https://docs.microsoft.com/en-us/azure/automation/automation-runbook-types)

[Using Visual Studio Code for PowerShell Development](https://docs.microsoft.com/en-us/powershell/scripting/dev-cross-plat/vscode/using-vscode?view=powershell-7)

[Integrated Terminal in Visual Studio Code](https://code.visualstudio.com/docs/editor/integrated-terminal)

[AWS Tools for Windows PowerShell](https://aws.amazon.com/powershell/)

[Start building with PowerShell on Google Cloud](https://cloud.google.com/powershell/)

[PowerShell Documentation](https://cloud.google.com/powershell/docs/)

[PowerShell Best Practices and Style Guide](https://poshcode.gitbooks.io/powershell-practice-and-style)


## PowerShell Tools

[PowerShell Core](https://microsoft.com/PowerShell) is a cross-platform (Windows, Linux, and macOS) automation and configuration tool/framework that works well with your existing tools and is optimized for dealing with structured data (JSON, CSV, XML, etc.), REST APIs, and object models. It also includes a command-line shell, an associated scripting language and a framework for processing cmdlets.

[Azure PowerShell](https://docs.microsoft.com/en-us/powershell/azure/overview) is a set of cmdlets for managing Microsoft Azure resources directly from the PowerShell command line.

[Windows Subsystem for Linux (WSL)](https://docs.microsoft.com/en-us/learn/modules/get-started-with-windows-subsystem-for-linux/) is a compatibility layer developed by Microsoft for running Linux binary executables in a Executable/Linkable Format natively on Windows 10 and Windows Server.

[AWS Shell](https://aws.amazon.com/cli/) is a command-line shell program that provides convenience and productivity features to help both new and advanced users of the AWS Command Line Interface.

[Google Cloud Shell](https://cloud.google.com/shell/) is a free admin machine with browser-based command-line access for managing your infrastructure and applications on Google Cloud Platform.


# TypeScript Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/93133287-d1dc8a80-f68b-11ea-94d3-bba83dd5b0bb.png">
  <br />

</p>

**[Start building with TypeScript on Azure](https://aka.ms/azsdk/js)**

**[TypeScript Documentation](https://aka.ms/azsdk/js/docs)**

## TypeScript Learning Resources

[TypeScript](https://www.typescriptlang.org) is a language for application-scale JavaScript. TypeScript adds optional types to JavaScript that support tools for large-scale JavaScript applications for any browser, for any host, on any OS. TypeScript compiles to readable, standards-based JavaScript.

[TypeScript support for Webpack](https://webpack.js.org/guides/typescript/)

[TypeScript Support for Nuxt.js](https://typescript.nuxtjs.org)

[TypeScript Support for Vue.js](https://vuejs.org/v2/guide/typescript.html)

[TypeScript Support for React Native](https://reactnative.dev/docs/typescript)

[TypeScript Support for Angular](https://angular.io/guide/typescript-configuration)

[Ionic/TypeScript Starter Project](http://justin-credible.github.io/Ionic-TypeScript-Starter/)

[GitHub Actions for JavaScript and TypeScript](https://docs.github.com/en/actions/language-and-framework-guides/github-actions-for-javascript-and-typescript)

## Tools

[WebStorm](https://www.jetbrains.com/webstorm/) is a professional IDE for JavaScript(including support for both HTML and CSS) developed by JetBrains. WebStorm comes with intelligent code completion, on-the-fly error detection, powerful navigation and refactoring for JavaScript, TypeScript, stylesheet languages, and all the most popular frameworks([Angular](https://angular.io/), [React](https://reactjs.org/), [Vue.js](https://vuejs.org/), [Ionic](https://ionicframework.com/), [Apache Cordova](https://cordova.apache.org/), [React Native](https://reactnative.dev/), [Node.js](https://nodejs.org/), [Meteor](https://www.meteor.com/#!), and [Electron](https://www.electronjs.org/)).

[ReSharper](https://www.jetbrains.com/resharper/) is a Visual Studio Extension for .NET Developers. It comes with code quality analysis, which is available in C#, VB.NET, XAML, ASP.NET, ASP.NET MVC, JavaScript, TypeScript, CSS, HTML, and XML. You'll know right away if your code needs to be improved. ReSharper is one of many powerful tools developed by [JetBrains](https://www.jetbrains.com).

[ts-migrate](https://github.com/airbnb/ts-migrate) is a tool for helping migrate code to TypeScript. It takes a JavaScript, or a partial TypeScript, project in and gives a compiling TypeScript project out. ts-migrate is intended to accelerate the TypeScript migration process. The resulting code will pass the build, but a followup is required to improve type safety.

[Deno](https://deno.land) is a simple, modern and secure runtime for JavaScript and TypeScript that uses V8 and is built in Rust.

[gulp-typescript](https://github.com/ivogabe/gulp-typescript) is an TypeScript compiler for gulp with incremental compilation support.

[React](https://reactjs.org/) is a declarative, efficient, and flexible JavaScript library for building user interfaces.

[React Native](https://reactnative.dev) is a framework for building native apps for iOS and Android with React.

[Vue.js](http://vuejs.org/) is a progressive, incrementally-adoptable JavaScript framework for building UI on the web.

[Angular](https://www.angular.io/) is a development platform for building mobile and desktop web applications using Typescript/JavaScript and other languages.

[Ionic Framework](https://ionicframework.com/) is a powerful cross-platform UI toolkit for building native-quality iOS, Android, and Progressive Web Apps with HTML, CSS, and JavaScript.

[Stencil](https://stenciljs.com/) is a simple compiler for generating Web Components and static site generated progressive web apps (PWA). Stencil was built by the Ionic team for its next generation of performant mobile and desktop Web Components.

[Storybook](https://storybook.js.org/) is a development environment for UI components. It allows you to browse a component library, view the different states of each component, and interactively develop and test components.It works with React, Vue, Angular, Ember, and other web frameworks.

[Prettier](https://prettier.io/) is an opinionated code formatter. It enforces a consistent style by parsing your code and re-printing it with its own rules that take the maximum line length into account, wrapping code when necessary.

[Nest](https://nestjs.com/) is a framework for building efficient, scalable [Node.js](http://nodejs.org/) server-side applications. It is built with TypeScript and combines elements of Object Oriented Programming(OOP), Functional Programming, and Functional Reactive Programming(FRP).

[Definitely Typed](https://github.com/DefinitelyTyped/DefinitelyTyped) is a repository for high quality TypeScript type definitions.

[TypeORM](https://github.com/typeorm/typeorm) is an ORM that can run in NodeJS, Browser, Cordova, PhoneGap, Ionic, React Native, NativeScript, Expo, and Electron platforms and can be used with TypeScript and JavaScript (ES5, ES6, ES7, ES8).

[NativeScript](https://www.nativescript.org/) empowers you to access native APIs from JavaScript directly. The framework currently provides iOS and Android runtimes for rich mobile development and can be utilized in a number of diverse use cases.

[AssemblyScript](https://assemblyscript.org/) compiles a strict variant of TypeScript to [WebAssembly](http://webassembly.org/) using [Binaryen](https://github.com/WebAssembly/binaryen).

[React Hook Form](https://react-hook-form.com/) is a performant, flexible and extensible forms with easy to use validation(Web + React Native).

[Apollo Client](https://apollographql.com/client) is a fully-featured caching GraphQL client with integrations for React, Angular, and more. It allows you to easily build UI components that fetch data via GraphQL.

[TensorFlow.js](https://js.tensorflow.org/) is an open-source WebGL hardware-accelerated JavaScript library for training and deploying machine learning models.

[Rome](https://romefrontend.dev/) is a linter, compiler, bundler, and [more](https://romefrontend.dev/#development-status) for JavaScript, TypeScript, JSON, HTML, Markdown, and CSS.

[Eclipse Theia](https://github.com/eclipse-theia/theia) is an extensible platform to develop full-fledged multi-language Cloud & Desktop IDE-like products with state-of-the-art web technologies.

[InversifyJS](https://github.com/inversify/InversifyJS) is a powerful and lightweight inversion of control(IoC) container for JavaScript & Node.js apps powered by TypeScript. An IoC container uses a class constructor to identify and inject its dependencies.

[Gatsby](https://www.gatsbyjs.com/) is a free and open source framework based on React that helps developers build blazing fast websites and apps.

[Meteor](https://www.meteor.com/) is an ultra-simple environment for building modern web applications with JavavScript.

[TypeScript ESLint](https://typescript-eslint.io/) is a monorepo for all the tooling which enables ESLint to support TypeScript.

[TS node](https://github.com/TypeStrong/ts-node) is a TypeScript execution and REPL for node.js.

# React Native Development
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/100526624-7ba5c080-317f-11eb-8bf6-6fedf59480e1.png">
  <br />
</p>

## React Learning Resources

[React](https://reactjs.org/) is a declarative, efficient, and flexible JavaScript library for building user interfaces.

[Getting Started with React](https://reactjs.org/docs/getting-started.html)

[React JavaScript Tutorial in Visual Studio Code](https://code.visualstudio.com/docs/nodejs/reactjs-tutorial)

[React Community Resources](https://reactjs.org/community/support.html)

[React Courses on Coursera](https://www.coursera.org/courses?query=react)

[React Courses on Udemy](https://www.udemy.com/topic/react/)

[React Nanodegree program on Udacity](https://www.udacity.com/course/react-nanodegree--nd019)

[Becoming a React Developer Learning Path on LinkedIn Learning](https://www.linkedin.com/learning/paths/become-a-react-developer)

[Learning ReactJS on Codecademy](https://www.codecademy.com/learn/react-101)

[React Tutorials and Training Courses on Pluralsight](https://www.pluralsight.com/browse/software-development/react)

[Introduction to React Course on Cloud Academy](https://cloudacademy.com/course/introduction-toreact/development-environment-set-up/)

## React Tools and Frameworks

[WebStorm](https://www.jetbrains.com/webstorm/) is a professional IDE for JavaScript(including support for both HTML and CSS) developed by JetBrains. WebStorm comes with intelligent code completion, on-the-fly error detection, powerful navigation and refactoring for JavaScript, TypeScript, stylesheet languages, and all the most popular frameworks([Angular](https://angular.io/), [React](https://reactjs.org/), [Vue.js](https://vuejs.org/), [Ionic](https://ionicframework.com/), [Apache Cordova](https://cordova.apache.org/), [React Native](https://reactnative.dev/), [Node.js](https://nodejs.org/), [Meteor](https://www.meteor.com/#!), and [Electron](https://www.electronjs.org/)).

[React Native](https://reactnative.dev) is a framework for building native apps for iOS and Android with React.

[Gatsby](https://www.gatsbyjs.com/) is a free and open source framework based on React that helps developers build blazing fast websites and apps.

[React Starter Kit](https://www.reactstarterkit.com/) is an isomorphic web app boilerplate for web development built on top of [Node.js](https://nodejs.org/), [Express](http://expressjs.com/), [GraphQL](http://graphql.org/) and [React](https://facebook.github.io/react/), containing modern web development tools such as [Webpack](https://webpack.github.io/), [Babel](https://babeljs.io/) and [Browsersync](https://www.browsersync.io/). Helping you to stay productive following the best practices.

[React Hook Form](https://react-hook-form.com/) is a performant, flexible and extensible forms with easy to use validation(Web + React Native).

[GraphQL](https://graphql.org/) is a query language for APIs and a runtime for fulfilling those queries with your existing data. It has support in Java, JavaScript, Ruby, Scala, and other programming languages.

[Apollo Client](https://apollographql.com/client) is a fully-featured caching GraphQL client with integrations for React, Angular, and more. It allows you to easily build UI components that fetch data via GraphQL.

[Nest](https://nestjs.com/) is a framework for building efficient, scalable [Node.js](http://nodejs.org/) server-side applications. It uses modern JavaScript, is built with TypeScript (preserves compatibility with pure JavaScript) and combines elements of OOP (Object Oriented Programming), FP (Functional Programming), and FRP (Functional Reactive Programming).

[Meteor](https://www.meteor.com/) is an ultra-simple environment for building modern web applications with JavavScript.

[mysqljs](https://github.com/mysqljs/mysql) is a pure node.js JavaScript Client implementing the MySQL protocol.

[axios](https://github.com/axios/axios) is a promise based HTTP client for the browser and node.js.

[Storybook](https://storybook.js.org/) is a development environment for UI components. It allows you to browse a component library, view the different states of each component, and interactively develop and test components.It works with React, Vue, Angular, Ember, and other web frameworks.

[Next.js](https://github.com/vercel/next.js) is a React Framework for production gives you the best developer experience with all the features needed for production such as hybrid static & server rendering, TypeScript support, smart bundling, route pre-fetching, and more.

[React Boilerplate](https://www.reactboilerplate.com/) is a highly scalable, offline-first foundation with the best developer experience and a focus on performance and best practices.

[TypeORM](https://github.com/typeorm/typeorm) is an ORM that can run in NodeJS, Browser, Cordova, PhoneGap, Ionic, React Native, NativeScript, Expo, and Electron platforms and can be used with TypeScript and JavaScript (ES5, ES6, ES7, ES8).

[Enzyme](https://github.com/enzymejs/enzyme) is a JavaScript Testing utility for React that makes it easier to test your React Components' output. The user can also manipulate, traverse, and in some ways simulate runtime given the output.

[RxDB](https://github.com/pubkey/rxdb) is a NoSQL-database for JavaScript Applications like Websites, hybrid Apps, Electron-Apps, Progressive Web Apps and NodeJs.

[Redux](https://github.com/reduxjs/redux) is a predictable state container for JavaScript apps.

[Inferno](https://infernojs.org/) is an insanely fast, React-like library for building high-performance user interfaces on both the client and server.

[Expo](https://github.com/expo/expo) is an open-source platform for making universal native apps with React.

[React Native Windows](https://microsoft.github.io/react-native-windows/) is a ramework for building native Windows apps with React. [React Native](https://reactnative.dev/) is a framework developed by Facebook that enables you to build world-class application experiences on native platforms using a consistent developer experience based on JavaScript and React.

[ReactiveUI](https://reactiveui.net/) is a composable, cross-platform model-view-viewmodel framework for all .NET platforms that is inspired by functional reactive programming, which is a paradigm that allows you to abstract mutable state away from your user interfaces and express the idea around a feature in one readable place and improve the testability of your application.

[Ant Design](https://ant.design/) is an enterprise-class UI design language and React UI library.

[Material-UI](https://material-ui.com/) is a collection of [React](https://reactjs.org/) components for faster and simpler web development.

[Chakra UI](https://chakra-ui.com/) is  a set of accessible, reusable, and composable React components that make it super easy to create websites and apps.

# Electron Development
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/120394956-0b702700-c2e9-11eb-817d-872b002575b6.png">
  <br />
</p>


# Electron Learning Resources

[Electron](https://electronjs.org/) is a framework lets you write cross-platform desktop applications using JavaScript, HTML and CSS. It is based on [Node.js](https://nodejs.org/) and [Chromium](https://www.chromium.org/) and is used by the [Atom editor](https://github.com/atom/atom) and many other [apps](https://electronjs.org/apps).

[The OpenJS Foundation](https://openjsf.org/) is made up of 32 open source JavaScript projects including Appium, Dojo, Electron, jQuery, Node.js, and webpack. The foundation's mission is to support the healthy growth of JavaScript and web technologies by providing a neutral organization to host and sustain projects, as well as collaboratively fund activities that benefit the ecosystem as a whole.

[Electron Apps](https://www.electronjs.org/apps)

[Getting Started with Electron](https://www.electronjs.org/docs/tutorial/quick-start)

[Electron Development](https://www.electronjs.org/docs/development)

[Configuring JavaScript libraries in WebStorm](https://www.jetbrains.com/help/webstorm/configuring-javascript-libraries.html)

[JavaScript in Visual Studio Code](https://code.visualstudio.com/Docs/languages/javascript)

[JavaScript extensions for VS Code](https://code.visualstudio.com/docs/nodejs/extensions)

[Master Electron: Desktop Apps with HTML, JavaScript & CSS course on Udemy](https://www.udemy.com/course/master-electron/)

[Electron for Desktop Apps: The Complete Developer's Guide course on Udemy](https://www.udemy.com/course/electron-react-tutorial/)

[Electron From Scratch: Build Desktop Apps With JavaScript course on Udemy](https://www.udemy.com/course/electron-from-scratch/)

[Electron Courses on Coursera](https://www.coursera.org/courses?query=electron+js)

[Electron Fundamentals on Pluralsight](https://www.pluralsight.com/courses/electron-fundamentals)


# Electron Tools, Libraries, and Frameworks

[Electron Fiddle](https://electronjs.org/fiddle) is an application that lets you create and play with small Electron experiments. It greets you with a simple quick start template after opening. Simply choose the version of Electron you want to run with your project and then play around.

[Electron Builder](https://www.electron.build/) is a complete solution to package and build a ready for distribution Electron app with “auto update” support out of the box.

[Photon](https://github.com/connors/photon) is a UI toolkit for building desktop apps with Electron.

[Electron.NET](https://github.com/ElectronNET/Electron.NET) is an application that builds cross platform desktop apps with ASP.NET Core (Razor Pages, MVC, Blazor).

[Angular Electron](https://github.com/maximegris/angular-electron) is an application that bootstrap's and package's your project with Angular 11 and Electron 11 (Typescript + SASS + Hot Reload) for creating Desktop applications.

[Selenium](https://selenium.dev/) is a browser automation framework and ecosystem. Selenium specifically provides an infrastructure for the [W3C WebDriver specification](https://w3c.github.io/webdriver/) as a platform and language-neutral coding interface compatible with all major web browsers(Firefox, Google Chrome and Safari).

[Selenium IDE](https://selenium.dev/selenium-ide/) is an Open Source record and playback test automation for the web.

[GitHub Codespaces](https://docs.github.com/en/free-pro-team@latest/github/developing-online-with-codespaces) is an integrated development environment(IDE) on GitHub. That allows developers to develop entirely in the cloud using Visual Studio and Visual Studio Code.

[GitHub Actions](https://docs.github.com/en/actions) will automate, customize, and execute your software development workflows right in your repository with GitHub Actions. You can discover, create, and share actions to perform any job you'd like, including CI/CD, and combine actions in a completely customized workflow.[GitHub Actions for Azure](https://docs.microsoft.com/en-us/azure/developer/github/github-actions) you can create workflows that you can set up in your repository to build, test, package, release and deploy to Azure.Learn more about all other integrations with Azure.

[WebStorm](https://www.jetbrains.com/webstorm/) is a professional IDE for JavaScript(including support for both HTML and CSS) developed by JetBrains. WebStorm comes with intelligent code completion, on-the-fly error detection, powerful navigation and refactoring for JavaScript, TypeScript, stylesheet languages, and all the most popular frameworks([Angular](https://angular.io/), [React](https://reactjs.org/), [Vue.js](https://vuejs.org/), [Ionic](https://ionicframework.com/), [Apache Cordova](https://cordova.apache.org/), [React Native](https://reactnative.dev/), [Node.js](https://nodejs.org/), [Meteor](https://www.meteor.com/#!), and [Electron](https://www.electronjs.org/)).

[Visual Studio Code](https://code.visualstudio.com/) is a code editor redefined and optimized for building and debugging modern web and cloud applications.

[GraphQL](https://graphql.org/) is a query language for APIs and a runtime for fulfilling those queries with your existing data. It has support in Java, JavaScript, Ruby, Scala, and other programming languages.

[TypeORM](https://github.com/typeorm/typeorm) is an ORM that can run in NodeJS, Browser, Cordova, PhoneGap, Ionic, React Native, NativeScript, Expo, and Electron platforms and can be used with TypeScript and JavaScript (ES5, ES6, ES7, ES8).

[Nest](https://nestjs.com/) is a framework for building efficient, scalable [Node.js](http://nodejs.org/) server-side applications. It uses modern JavaScript, is built with TypeScript (preserves compatibility with pure JavaScript) and combines elements of OOP (Object Oriented Programming), FP (Functional Programming), and FRP (Functional Reactive Programming).

[Quasar](https://quasar.dev/) is a framework that builds high-performance VueJS user interfaces in record time. Such as responsive Single Page Apps, SSR Apps, PWAs, Browser extensions, Hybrid Mobile Apps and Electron Apps.

[Gatsby](https://www.gatsbyjs.com/) is a free and open source framework based on React that helps developers build blazing fast websites and apps.

[React Starter Kit](https://www.reactstarterkit.com/) is an isomorphic web app boilerplate for web development built on top of [Node.js](https://nodejs.org/), [Express](http://expressjs.com/), [GraphQL](http://graphql.org/) and [React](https://facebook.github.io/react/), containing modern web development tools such as [Webpack](https://webpack.github.io/), [Babel](https://babeljs.io/) and [Browsersync](https://www.browsersync.io/). Helping you to stay productive following the best practices.

[Enzyme](https://github.com/enzymejs/enzyme) is a JavaScript Testing utility for React that makes it easier to test your React Components' output. The user can also manipulate, traverse, and in some ways simulate runtime given the output.

[Mocha](https://github.com/mochajs/mocha) is a simple, flexible, fun JavaScript test framework for Node.js & The Browser.

[Express](https://expressjs.com/) is a fast, unopinionated, minimalist web framework for node.

[Meteor](https://www.meteor.com/) is an ultra-simple environment for building modern web applications with JavavScript.

[RxDB](https://github.com/pubkey/rxdb) is a NoSQL-database for JavaScript Applications like Websites, hybrid Apps, Electron-Apps, Progressive Web Apps and NodeJs.

[Redux](https://github.com/reduxjs/redux) is a predictable state container for JavaScript apps.

[Standard](https://standardjs.com/) is a JavaScript Style Guide, with linter & automatic code fixer.

[Lowdb](https://github.com/typicode/lowdb) is a small local JSON database powered by Lodash (supports Node, Electron and the browser).

[Nativefier](https://github.com/jiahaog/nativefier) is an application that lets you make any web page into a desktop electron application.

# C/C++ Development
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

<h1 align="center">
 <img src="https://user-images.githubusercontent.com/45159366/115297894-961e0d80-a111-11eb-81c3-e2bd2ac9a7cd.png">
  <br />
</h1>


## C/C++ Learning Resources

[C++](https://www.cplusplus.com/doc/tutorial/) is a cross-platform language that can be used to build high-performance applications developed by Bjarne Stroustrup, as an extension to the C language.

[C](https://www.iso.org/standard/74528.html) is a general-purpose, high-level language that was originally developed by Dennis M. Ritchie to develop the UNIX operating system at Bell Labs. It supports structured programming, lexical variable scope, and recursion, with a static type system. C also provides constructs that map efficiently to typical machine instructions, which makes it one was of the most widely used programming languages today.

[Embedded C](https://en.wikipedia.org/wiki/Embedded_C) is a set of language extensions for the C programming language by the [C Standards Committee](https://isocpp.org/std/the-committee) to address issues that exist between C extensions for different [embedded systems](https://en.wikipedia.org/wiki/Embedded_system). The extensions hep enhance microprocessor features such as fixed-point arithmetic, multiple distinct memory banks, and basic I/O operations. This makes Embedded C the most popular embedded software language in the world.

[C & C++ Developer Tools from JetBrains](https://www.jetbrains.com/cpp/)

[Open source C++ libraries on cppreference.com](https://en.cppreference.com/w/cpp/links/libs)

[C++ Graphics libraries](https://cpp.libhunt.com/libs/graphics)

[C++ Libraries in MATLAB](https://www.mathworks.com/help/matlab/call-cpp-library-functions.html)

[C++ Tools and Libraries Articles](https://www.cplusplus.com/articles/tools/)

[Google C++ Style Guide](https://google.github.io/styleguide/cppguide.html)

[Introduction C++ Education course on Google Developers](https://developers.google.com/edu/c++/)

[C++ style guide for Fuchsia](https://fuchsia.dev/fuchsia-src/development/languages/c-cpp/cpp-style)

[C and C++ Coding Style Guide by OpenTitan](https://docs.opentitan.org/doc/rm/c_cpp_coding_style/)

[Chromium C++ Style Guide](https://chromium.googlesource.com/chromium/src/+/master/styleguide/c++/c++.md)

[C++ Core Guidelines](https://github.com/isocpp/CppCoreGuidelines/blob/master/CppCoreGuidelines.md)

[C++ Style Guide for ROS](http://wiki.ros.org/CppStyleGuide)

[Learn C++](https://www.learncpp.com/)

[Learn C : An Interactive C Tutorial](https://www.learn-c.org/)

[C++ Institute](https://cppinstitute.org/free-c-and-c-courses)

[C++ Online Training Courses on LinkedIn Learning](https://www.linkedin.com/learning/topics/c-plus-plus)

[C++ Tutorials on W3Schools](https://www.w3schools.com/cpp/default.asp)

[Learn C Programming Online Courses on edX](https://www.edx.org/learn/c-programming)

[Learn C++ with Online Courses on edX](https://www.edx.org/learn/c-plus-plus)

[Learn C++ on Codecademy](https://www.codecademy.com/learn/learn-c-plus-plus)

[Coding for Everyone: C and C++ course on Coursera](https://www.coursera.org/specializations/coding-for-everyone)

[C++ For C Programmers on Coursera](https://www.coursera.org/learn/c-plus-plus-a)

[Top C Courses on Coursera](https://www.coursera.org/courses?query=c%20programming)

[C++ Online Courses on Udemy](https://www.udemy.com/topic/c-plus-plus/)

[Top C Courses on Udemy](https://www.udemy.com/topic/c-programming/)

[Basics of Embedded C Programming for Beginners on Udemy](https://www.udemy.com/course/embedded-c-programming-for-embedded-systems/)

[C++ For Programmers Course on Udacity](https://www.udacity.com/course/c-for-programmers--ud210)

[C++ Fundamentals Course on Pluralsight](https://www.pluralsight.com/courses/learn-program-cplusplus)

[Introduction to C++ on MIT Free Online Course Materials](https://ocw.mit.edu/courses/electrical-engineering-and-computer-science/6-096-introduction-to-c-january-iap-2011/)

[Introduction to C++ for Programmers | Harvard ](https://online-learning.harvard.edu/course/introduction-c-programmers)

[Online C Courses | Harvard University](https://online-learning.harvard.edu/subject/c)


## C/C++ Tools, Libraries, and Frameworks

[AWS SDK for C++](https://aws.amazon.com/sdk-for-cpp/)

[Azure SDK for C++](https://github.com/Azure/azure-sdk-for-cpp)

[Azure SDK for C](https://github.com/Azure/azure-sdk-for-c)

[C++ Client Libraries for Google Cloud Services](https://github.com/googleapis/google-cloud-cpp)

[Visual Studio](https://visualstudio.microsoft.com/) is an integrated development environment (IDE) from Microsoft; which is a feature-rich application that can be used for many aspects of software development. Visual Studio makes it easy to edit, debug, build, and publish your app. By using Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, and Windows Store.

[Visual Studio Code](https://code.visualstudio.com/) is a code editor redefined and optimized for building and debugging modern web and cloud applications.

[Vcpkg](https://github.com/microsoft/vcpkg) is a C++ Library Manager for Windows, Linux, and MacOS.

[ReSharper C++](https://www.jetbrains.com/resharper-cpp/features/) is a Visual Studio Extension for C++ developers developed by JetBrains.

[AppCode](https://www.jetbrains.com/objc/) is constantly monitoring the quality of your code. It warns you of errors and smells and suggests quick-fixes to resolve them automatically. AppCode provides lots of code inspections for Objective-C, Swift, C/C++, and a number of code inspections for other supported languages. All code inspections are run on the fly.

[CLion](https://www.jetbrains.com/clion/features/) is a cross-platform IDE for C and C++ developers developed by JetBrains.

[Code::Blocks](https://www.codeblocks.org/) is a free C/C++ and Fortran IDE built to meet the most demanding needs of its users. It is designed to be very extensible and fully configurable. Built around a plugin framework, Code::Blocks can be extended with plugins.

[CppSharp](https://github.com/mono/CppSharp) is a tool and set of libraries which facilitates the usage of native C/C++ code with the .NET ecosystem. It consumes C/C++ header and library files and generates the necessary glue code to surface the native API as a managed API. Such an API can be used to consume an existing native library in your managed code or add managed scripting support to a native codebase.

[Conan](https://conan.io/) is an Open Source Package Manager for C++ development and dependency management into the 21st century and on par with the other development ecosystems.

[High Performance Computing (HPC) SDK](https://developer.nvidia.com/hpc) is a comprehensive toolbox for GPU accelerating HPC modeling and simulation applications. It includes the C, C++, and Fortran compilers, libraries, and analysis tools necessary for developing HPC applications on the NVIDIA platform.

[Thrust](https://github.com/NVIDIA/thrust) is a C++ parallel programming library which resembles the C++ Standard Library. Thrust's high-level interface greatly enhances programmer productivity while enabling performance portability between GPUs and multicore CPUs. Interoperability with established technologies such as CUDA, TBB, and OpenMP integrates with existing software.

[Boost](https://www.boost.org/) is an educational opportunity focused on cutting-edge C++. Boost has been a participant in the annual Google Summer of Code since 2007, in which students develop their skills by working on Boost Library development.

[Automake](https://www.gnu.org/software/automake/) is a tool for automatically generating Makefile.in files compliant with the GNU Coding Standards. Automake requires the use of GNU Autoconf.

[Cmake](https://cmake.org/) is an open-source, cross-platform family of tools designed to build, test and package software. CMake is used to control the software compilation process using simple platform and compiler independent configuration files, and generate native makefiles and workspaces that can be used in the compiler environment of your choice.

[GDB](http://www.gnu.org/software/gdb/) is a debugger, that allows you to see what is going on `inside' another program while it executes or what another program was doing at the moment it crashed.

[GCC](https://gcc.gnu.org/) is a compiler Collection that includes front ends for C, C++, Objective-C, Fortran, Ada, Go, and D, as well as libraries for these languages.

[GSL](https://www.gnu.org/software/gsl/) is a numerical library for C and C++ programmers. It is free software under the GNU General Public License. The library provides a wide range of mathematical routines such as random number generators, special functions and least-squares fitting. There are over 1000 functions in total with an extensive test suite.

[OpenGL Extension Wrangler Library (GLEW)](https://www.opengl.org/sdk/libs/GLEW/) is a cross-platform open-source C/C++ extension loading library. GLEW provides efficient run-time mechanisms for determining which OpenGL extensions are supported on the target platform.

[Libtool](https://www.gnu.org/software/libtool/) is a generic library support script that hides the complexity of using shared libraries behind a consistent, portable interface. To use Libtool, add the new generic library building commands to your Makefile, Makefile.in, or Makefile.am.

[Maven](https://maven.apache.org/) is a software project management and comprehension tool. Based on the concept of a project object model (POM), Maven can manage a project's build, reporting and documentation from a central piece of information.

[TAU (Tuning And Analysis Utilities)](http://www.cs.uoregon.edu/research/tau/home.php) is capable of gathering performance information through instrumentation of functions, methods, basic blocks, and statements as well as event-based sampling. All C++ language features are supported including templates and namespaces.

[Clang](https://clang.llvm.org/) is a production quality C, Objective-C, C++ and Objective-C++ compiler when targeting X86-32, X86-64, and ARM (other targets may have caveats, but are usually easy to fix). Clang is used in production to build performance-critical software like Google Chrome or Firefox.

[OpenCV](https://opencv.org/) is a highly optimized library with focus on real-time applications. Cross-Platform C++, Python and Java interfaces support Linux, MacOS, Windows, iOS, and Android.

[Libcu++](https://nvidia.github.io/libcudacxx) is the NVIDIA C++ Standard Library for your entire system. It provides a heterogeneous implementation of the C++ Standard Library that can be used in and between CPU and GPU code.

[ANTLR (ANother Tool for Language Recognition)](https://www.antlr.org/) is a powerful parser generator for reading, processing, executing, or translating structured text or binary files. It's widely used to build languages, tools, and frameworks. From a grammar, ANTLR generates a parser that can build parse trees and also generates a listener interface that makes it easy to respond to the recognition of phrases of interest.

[Oat++](https://oatpp.io/) is a light and powerful C++ web framework for highly scalable and resource-efficient web application. It's zero-dependency and easy-portable.

[JavaCPP](https://github.com/bytedeco/javacpp) is a program that provides efficient access to native C++ inside Java, not unlike the way some C/C++ compilers interact with assembly language.

[Cython](https://cython.org/) is a language that makes writing C extensions for Python as easy as Python itself. Cython is based on Pyrex, but supports more cutting edge functionality and optimizations such as calling C functions and declaring C types on variables and class attributes.

[Spdlog](https://github.com/gabime/spdlog) is a very fast, header-only/compiled, C++ logging library.

[Infer](https://fbinfer.com/) is a static analysis tool for Java, C++, Objective-C, and C. Infer is written in [OCaml](https://ocaml.org/).

# Java Development
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide#table-of-contents)

<h1 align="center">
 <img src="https://user-images.githubusercontent.com/45159366/93925952-c0b6fd80-fccb-11ea-9f90-21c4148e3c86.png">
  <br />
</h1>

## Java Learning Resources

[Java](https://www.oracle.com/java/) is a popular programming language and development platform(JDK). It reduces costs, shortens development timeframes, drives innovation, and improves application services. With millions of developers running more than 51 billion Java Virtual Machines worldwide.

[The Eclipse Foundation](https://www.eclipse.org/downloads/) is home to a worldwide community of developers, the Eclipse IDE, Jakarta EE and over 375 open source projects, including runtimes, tools and frameworks for Java and other languages.

[Getting Started with Java](https://docs.oracle.com/javase/tutorial/)

[Oracle Java certifications from Oracle University](https://education.oracle.com/java-certification-benefits)

[Google Developers Training](https://developers.google.com/training/)

[Google Developers Certification](https://developers.google.com/certification/)

[Java Tutorial by W3Schools](https://www.w3schools.com/java/)

[Building Your First Android App in Java](codelabs.developers.google.com/codelabs/build-your-first-android-app/)

[Getting Started with Java in Visual Studio Code](https://code.visualstudio.com/docs/java/java-tutorial)

[Google Java Style Guide](https://google.github.io/styleguide/javaguide.html)

[AOSP Java Code Style for Contributors](https://source.android.com/setup/contribute/code-style)

[Chromium Java style guide](https://chromium.googlesource.com/chromium/src/+/master/styleguide/java/java.md)

[Get Started with OR-Tools for Java](https://developers.google.com/optimization/introduction/java)

[Getting started with Java Tool Installer task for Azure Pipelines](https://docs.microsoft.com/en-us/azure/devops/pipelines/tasks/tool/java-tool-installer)

[Gradle User Manual](https://docs.gradle.org/current/userguide/userguide.html)

## Java Tools and Frameworks

[Java SE](https://www.oracle.com/java/technologies/javase/tools-jsp.html) contains several tools to assist in program development and debugging, and in the monitoring and troubleshooting of production applications.

[JDK Development Tools](https://docs.oracle.com/javase/7/docs/technotes/tools/) includes the Java Web Start Tools (javaws) Java Troubleshooting, Profiling, Monitoring and Management Tools (jcmd, jconsole, jmc, jvisualvm); and Java Web Services Tools (schemagen, wsgen, wsimport, xjc).

[Android Studio](https://developer.android.com/studio/) is the official integrated development environment for Google's Android operating system, built on JetBrains' IntelliJ IDEA software and designed specifically for Android development. Availble on Windows, macOS, Linux, Chrome OS.

[IntelliJ IDEA](https://www.jetbrains.com/idea/) is an IDE for Java, but it also understands and provides intelligent coding assistance for a large variety of other languages such as Kotlin, SQL, JPQL, HTML, JavaScript, etc., even if the language expression is injected into a String literal in your Java code.

[NetBeans](https://netbeans.org/features/java/index.html) is an IDE provides Java developers with all the tools needed to create professional desktop, mobile and enterprise applications. Creating, Editing, and Refactoring. The IDE provides wizards and templates to let you create Java EE, Java SE, and Java ME applications.

[Java Design Patterns ](https://github.com/iluwatar/java-design-patterns) is a collection of the best formalized practices a programmer can use to solve common problems when designing an application or system.

[Elasticsearch](https://www.elastic.co/products/elasticsearch) is a distributed RESTful search engine built for the cloud written in Java.

[RxJava](https://github.com/ReactiveX/RxJava) is a Java VM implementation of [Reactive Extensions](http://reactivex.io/): a library for composing asynchronous and event-based programs by using observable sequences. It extends the [observer pattern](http://en.wikipedia.org/wiki/Observer_pattern) to support sequences of data/events and adds operators that allow you to compose sequences together declaratively while abstracting away concerns about things like low-level threading, synchronization, thread-safety and concurrent data structures.

[Guava](https://github.com/google/guava) is a set of core Java libraries from Google that includes new collection types (such as multimap and multiset), immutable collections, a graph library, and utilities for concurrency, I/O, hashing, caching, primitives, strings, and more! It is widely used on most Java projects within Google, and widely used by many other companies as well.

[okhttp](https://square.github.io/okhttp/) is a HTTP client for Java and Kotlin developed by Square.

[Retrofit](https://square.github.io/retrofit/) is a type-safe HTTP client for Android and Java develped by Square.

[LeakCanary](https://square.github.io/leakcanary/) is a memory leak detection library for Android develped by Square.

[Apache Spark](https://spark.apache.org/) is a unified analytics engine for large-scale data processing. It provides high-level APIs in Scala, Java, Python, and R, and an optimized engine that supports general computation graphs for data analysis. It also supports a rich set of higher-level tools including Spark SQL for SQL and DataFrames, MLlib for machine learning, GraphX for graph processing, and Structured Streaming for stream processing.

[Apache Flink](https://flink.apache.org/) is an open source stream processing framework with powerful stream- and batch-processing capabilities with elegant and fluent APIs in Java and Scala.

[Fastjson](https://github.com/alibaba/fastjson/wiki) is a Java library that can be used to convert Java Objects into their JSON representation. It can also be used to convert a JSON string to an equivalent Java object.

[libGDX](https://libgdx.com/) is a cross-platform Java game development framework based on OpenGL (ES) that works on Windows, Linux, Mac OS X, Android, your WebGL enabled browser and iOS.

[Jenkins](https://www.jenkins.io/) is the leading open-source automation server. Built with Java, it provides over 1700 [plugins](https://plugins.jenkins.io/) to support automating virtually anything, so that humans can actually spend their time doing things machines cannot.

[DBeaver](https://dbeaver.io/) is a free multi-platform database tool for developers, SQL programmers, database administrators and analysts. Supports any database which has JDBC driver (which basically means - ANY database). EE version also supports non-JDBC datasources (MongoDB, Cassandra, Redis, DynamoDB, etc).

[Redisson](https://redisson.pro/) is a Redis Java client with features of In-Memory Data Grid. Over 50 Redis based Java objects and services: Set, Multimap, SortedSet, Map, List, Queue, Deque, Semaphore, Lock, AtomicLong, Map Reduce, Publish / Subscribe, Bloom filter, Spring Cache, Tomcat, Scheduler, JCache API, Hibernate, MyBatis, RPC, and local cache.

[GraalVM](https://www.graalvm.org/) is a universal virtual machine for running applications written in JavaScript, Python, Ruby, R, JVM-based languages like Java, Scala, Clojure, Kotlin, and LLVM-based languages such as C and C++.

[Gradle](https://gradle.org/) is a build automation tool for multi-language software development. From mobile apps to microservices, from small startups to big enterprises, Gradle helps teams build, automate and deliver better software, faster. Write in Java, C++, Python or your language of choice.

[Apache Groovy](http://www.groovy-lang.org/) is a powerful, optionally typed and dynamic language, with static-typing and static compilation capabilities, for the Java platform aimed at improving developer productivity thanks to a concise, familiar and easy to learn syntax. It integrates smoothly with any Java program, and immediately delivers to your application powerful features, including scripting capabilities, Domain-Specific Language authoring, runtime and compile-time meta-programming and functional programming.

[JaCoCo](https://www.jacoco.org/jacoco/) is a free code coverage library for Java, which has been created by the EclEmma team based on the lessons learned from using and integration existing libraries for many years.

[Apache JMeter](http://jmeter.apache.org/) is  used to test performance both on static and dynamic resources, Web dynamic applications. It also used to simulate a heavy load on a server, group of servers, network or object to test its strength or to analyze overall performance under different load types.

[Junit](https://junit.org/) is a simple framework to write repeatable tests. It is an instance of the xUnit architecture for unit testing frameworks.

[Mockito](https://site.mockito.org/) is the most popular Mocking framework for unit tests written in Java.

[SpotBugs](https://spotbugs.github.io/) is a program which uses static analysis to look for bugs in Java code.

[SpringBoot](https://spring.io/projects/spring-boot) is a great tool that helps you to create Spring-powered, production-grade applications and services with absolute minimum fuss. It takes an opinionated view of the Spring platform so that new and existing users can quickly get to the bits they need.

[YourKit](https://www.yourkit.com/) is a technology leader, creator of the most innovative and intelligent tools for profiling Java & .NET applications.

# Python Development
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/93133273-ce490380-f68b-11ea-81d0-7f6a3debe6c0.png">
  <br />

</p>

## Python Learning Resources

[Python](https://www.python.org) is an interpreted, high-level programming language. Python is used heavily in the fields of Data Science and Machine Learning.

[Python Developer’s Guide](https://devguide.python.org) is a comprehensive resource for contributing to Python – for both new and experienced contributors. It is maintained by the same community that maintains Python.

[Azure Functions Python developer guide](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference-python) is an introduction to developing Azure Functions using Python. The content below assumes that you've already read the [Azure Functions developers guide](https://docs.microsoft.com/en-us/azure/azure-functions/functions-reference).

[CheckiO](https://checkio.org/) is a programming learning platform and a gamified website that teaches Python through solving code challenges and competing for the most elegant and creative solutions.

[Python Institute](https://pythoninstitute.org)

[PCEP – Certified Entry-Level Python Programmer certification](https://pythoninstitute.org/pcep-certification-entry-level/)

[PCAP – Certified Associate in Python Programming certification](https://pythoninstitute.org/pcap-certification-associate/)

[PCPP – Certified Professional in Python Programming 1 certification](https://pythoninstitute.org/pcpp-certification-professional/)

[PCPP – Certified Professional in Python Programming 2](https://pythoninstitute.org/pcpp-certification-professional/)

[MTA: Introduction to Programming Using Python Certification](https://docs.microsoft.com/en-us/learn/certifications/mta-introduction-to-programming-using-python)

[Getting Started with Python in Visual Studio Code](https://code.visualstudio.com/docs/python/python-tutorial)

[Google's Python Style Guide](https://google.github.io/styleguide/pyguide.html)

[Google's Python Education Class](https://developers.google.com/edu/python/)

[Real Python](https://realpython.com)

[The Python Open Source Computer Science Degree by Forrest Knight](https://github.com/ForrestKnight/open-source-cs-python)

[Intro to Python for Data Science](https://www.datacamp.com/courses/intro-to-python-for-data-science)

[Intro to Python by W3schools](https://www.w3schools.com/python/python_intro.asp)

[Codecademy's Python 3 course](https://www.codecademy.com/learn/learn-python-3)

[Learn Python with Online Courses and Classes from edX](https://www.edx.org/learn/python)

[Python Courses Online from Coursera](https://www.coursera.org/courses?query=python)

# Python Frameworks, Libraries, and Tools

[Python Package Index (PyPI)](https://pypi.org/) is a repository of software for the Python programming language. PyPI helps you find and install software developed and shared by the Python community.

[PyCharm](https://www.jetbrains.com/pycharm/) is the best IDE I've ever used. With PyCharm, you can access the command line, connect to a database, create a virtual environment, and manage your version control system all in one place, saving time by avoiding constantly switching between windows.

[Python Tools for Visual Studio(PTVS)](https://microsoft.github.io/PTVS/) is a free, open source plugin that turns Visual Studio into a Python IDE. It supports editing, browsing, IntelliSense, mixed Python/C++ debugging, remote Linux/MacOS debugging, profiling, IPython, and web development with Django and other frameworks.

[Django](https://www.djangoproject.com/) is a high-level Python Web framework that encourages rapid development and clean, pragmatic design.

[Flask](https://flask.palletsprojects.com/) is a micro web framework written in Python. It is classified as a microframework because it does not require particular tools or libraries.

[Web2py](http://web2py.com/) is an open-source web application framework written in Python allowing allows web developers to program dynamic web content. One web2py instance can run multiple web sites using different databases.

[AWS Chalice](https://github.com/aws/chalice) is a framework for writing serverless apps in python. It allows you to quickly create and deploy applications that use AWS Lambda.

[Tornado](https://www.tornadoweb.org/) is a Python web framework and asynchronous networking library. Tornado uses a non-blocking network I/O, which can scale to tens of thousands of open connections.

[HTTPie](https://github.com/httpie/httpie) is a command line HTTP client that makes CLI interaction with web services as easy as possible. HTTPie is designed for testing, debugging, and generally interacting with APIs & HTTP servers.

[Scrapy](https://scrapy.org/) is a fast high-level web crawling and web scraping framework, used to crawl websites and extract structured data from their pages. It can be used for a wide range of purposes, from data mining to monitoring and automated testing.

[Sentry](https://sentry.io/) is a service that helps you monitor and fix crashes in realtime. The server is in Python, but it contains a full API for sending events from any language, in any application.

[Pipenv](https://github.com/pypa/pipenv) is a tool that aims to bring the best of all packaging worlds (bundler, composer, npm, cargo, yarn, etc.) to the Python world.

[Python Fire](https://github.com/google/python-fire) is a library for automatically generating command line interfaces (CLIs) from absolutely any Python object.

[Bottle](https://github.com/bottlepy/bottle) is a fast, simple and lightweight [WSGI](https://www.wsgi.org/) micro web-framework for Python. It is distributed as a single file module and has no dependencies other than the [Python Standard Library](https://docs.python.org/library/).

[CherryPy](https://cherrypy.org) is a minimalist Python object-oriented HTTP web framework.

[Sanic](https://github.com/huge-success/sanic) is a Python 3.6+ web server and web framework that's written to go fast.

[Pyramid](https://trypyramid.com) is a small and fast open source Python web framework. It makes real-world web application development and deployment more fun and more productive.

[TurboGears](https://turbogears.org) is a hybrid web framework able to act both as a Full Stack framework or as a Microframework.

[Falcon](https://falconframework.org/) is a reliable, high-performance Python web framework for building large-scale app backends and microservices with support for MongoDB, Pluggable Applications and autogenerated Admin.

[Neural Network Intelligence(NNI)](https://github.com/microsoft/nni) is an open source AutoML toolkit for automate machine learning lifecycle, including [Feature Engineering](https://github.com/microsoft/nni/blob/master/docs/en_US/FeatureEngineering/Overview.md), [Neural Architecture Search](https://github.com/microsoft/nni/blob/master/docs/en_US/NAS/Overview.md), [Model Compression](https://github.com/microsoft/nni/blob/master/docs/en_US/Compressor/Overview.md) and [Hyperparameter Tuning](https://github.com/microsoft/nni/blob/master/docs/en_US/Tuner/BuiltinTuner.md).

[Dash](https://plotly.com/dash) is a popular Python framework for building ML & data science web apps for Python, R, Julia, and Jupyter.

[Luigi](https://github.com/spotify/luigi) is a Python module that helps you build complex pipelines of batch jobs. It handles dependency resolution, workflow management, visualization etc. It also comes with Hadoop support built-in.

[Locust](https://github.com/locustio/locust) is an easy to use, scriptable and scalable performance testing tool.

[spaCy](https://github.com/explosion/spaCy) is a library for advanced Natural Language Processing in Python and Cython.

[NumPy](https://www.numpy.org/) is the fundamental package needed for scientific computing with Python.

[Pillow](https://python-pillow.org/) is a friendly PIL(Python Imaging Library) fork.

[IPython](https://ipython.org/) is a command shell for interactive computing in multiple programming languages, originally developed for the Python programming language, that offers enhanced introspection, rich media, additional shell syntax, tab completion, and rich history.

[GraphLab Create](https://turi.com/) is a Python library, backed by a C++ engine, for quickly building large-scale, high-performance machine learning models.

[Pandas](https://pandas.pydata.org/) is a fast, powerful, and easy to use open source data structrures, data analysis and manipulation tool, built on top of the Python programming language.

[PuLP](https://coin-or.github.io/pulp/) is an Linear Programming modeler written in python. PuLP can generate LP files and call on use highly optimized solvers, GLPK, COIN CLP/CBC, CPLEX, and GUROBI, to solve these linear problems.

[Matplotlib](https://matplotlib.org/) is a 2D plotting library for creating static, animated, and interactive visualizations in Python. Matplotlib produces publication-quality figures in a variety of hardcopy formats and interactive environments across platforms.

[Scikit-Learn](https://scikit-learn.org/stable/index.html) is a simple and efficient tool for data mining and data analysis. It is built on NumPy,SciPy, and mathplotlib.

# Ruby Development
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/93719684-07282300-fb39-11ea-98fd-90394a2df6f2.png">
  <br />
</p>

# Ruby Learning Resources

[Ruby](https://www.ruby-lang.org/en/) is a dynamic, open source programming language with a focus on simplicity and productivity. It has an elegant syntax that is natural to read and easy to write.

[Ruby Documentation](https://www.ruby-lang.org/en/documentation/)

[Ruby Community](https://www.ruby-lang.org/en/community/)

[Ruby Gems](https://guides.rubygems.org/rubygems-basics/)

[Ruby courses by Coursera](https://www.coursera.org/courses?query=ruby)

[Learn Ruby course by Codecademy](https://www.codecademy.com/learn/learn-ruby)

[Ruby Glossary](https://www.codecademy.com/articles/glossary-ruby)

[Ruby in Twenty Minutes Quickstart](https://www.ruby-lang.org/en/documentation/quickstart/)

[Getting started with a Ruby on Rails application on CircleCI.](https://circleci.com/docs/2.0/language-ruby/)

[The Ruby Style Guide](https://rubystyle.guide)

[Airbnb's Ruby Style Guide](https://github.com/airbnb/ruby)

# Ruby Tools and Frameworks

[RubyMine](https://www.jetbrains.com/ruby/) is a professional IDE developed by Jet Brains that provides support for Ruby, Ruby on Rails and web development.

[Rails](https://rubyonrails.org/) is a web-application framework that includes everything needed to create database-backed web applications according to the [Model-View-Controller (MVC)](https://en.wikipedia.org/wiki/Model-view-controller) pattern. Understanding the MVC pattern is key to understanding Rails. MVC divides your application into three layers: Model, View, and Controller, each with a specific responsibility.

[rbenv](https://github.com/rbenv/rbenv) allows to pick a Ruby version for your application and guarantee that your development environment matches production. Put rbenv to work with Bundler for painless Ruby upgrades and bulletproof deployments.

[Prettier for Ruby](https://prettier.io/) is a plugin for the Ruby programming language and its ecosystem. prettier is an opinionated code formatter that supports multiple languages and integrates with most editors. The idea is to eliminate discussions of style in code review and allow developers to get back to thinking about code design instead.

[Active Admin](https://activeadmin.info/) is a Ruby on Rails framework for creating elegant backends for website administration.

[Capistrano](https://github.com/capistrano/capistrano) is a framework for building automated deployment scripts. Although Capistrano itself is written in Ruby, it can easily be used to deploy projects of any language or framework, be it Rails, Java, or PHP.

[Spree](https://spreecommerce.org/) is an open source E-commerce platform for Rails 6 with a modern UX, optional PWA frontend, REST API, GraphQL, several official extensions and 3rd party integrations.

[Sidekiq](https://sidekiq.org/) is a simple, efficient background processing for Ruby. It uses hreads to handle many jobs at the same time in the same process. It does not require Rails but will integrate tightly with Rails to make background processing dead simple.

[Kaminari](https://github.com/amatsuda/kaminari/wiki) is a  Scope and Engine based, clean, powerful, and customizable  paginator for modern web app frameworks and ORMs.

[React-Rails](https://github.com/reactjs/react-rails) is a flexible tool to use [React](http://facebook.github.io/react/) with Rails. By integrating React.js with Rails views and controllers, the asset pipeline, or webpacker.

[Pry](https://github.com/pry/pry) is a runtime developer console and IRB alternative with powerful introspection capabilities.

[Brakeman](https://brakemanscanner.org/) is a static analysis tool which checks Ruby on Rails applications for security vulnerabilities.

[dotenv](https://github.com/bkeepers/dotenv) is a Ruby gem to load environment variables from `.env`.

[Scientist](https://github.com/github/scientist) is a Ruby library for carefully refactoring critical paths.

[fastlane](https://fastlane.tools/) is a tool written in Ruby for iOS and Android developers to automate tedious tasks like generating screenshots, dealing with provisioning profiles, and releasing your application.

[Fluentd](https://www.fluentd.org/) collects events from various data sources and writes them to files, RDBMS, NoSQL, IaaS, SaaS, Hadoop and so on all written in Ruby.

# Flutter Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/93719686-0abbaa00-fb39-11ea-978d-91e55844dd7a.png">
</p>

[Flutter](https://flutter.dev/) is Google's UI toolkit for crafting beautiful, natively compiled applications for mobile(Andorid and iOS), web, and desktop(Windows, MacOS, Linux, and Google Fuchsia) from a single codebase. Flutter works with existing code, is used by developers and organizations around the world, and is free and open source.

## Flutter Learning Resources

[Flutter Gems](https://fluttergems.dev) is a curated package guide for Flutter which functionally categorizes some of the most useful and popular flutter packages available on pub.dev Flutter Gems A Flutter package landscape guide comprising 1500+ neatly categorized useful and popular packages.

[Dart](https://dart.dev/) is an open-source, scalable programming language, with robust libraries and runtimes, for building web, server, and mobile apps using the Flutter framework.

[Flutter documentation](https://flutter.dev/docs)

[Style Guide for Flutter](https://github.com/flutter/flutter/wiki/Style-guide-for-Flutter-repo)

[Creating your first Flutter app](https://flutter.dev/docs/get-started/codelab)

[Build and release an Android app using Flutter](https://flutter.dev/docs/deployment/android)

[Flutter Tools & techniques](https://flutter.dev/docs/development/tools)

[Dart and Flutter: The Complete Developer's Guide on Udemy](https://www.udemy.com/course/dart-and-flutter-the-complete-developers-guide/)

[Creating an Interactive Story with Flutter on Coursera](https://www.coursera.org/projects/story-creating-flutter)

[Flutter for Beginners course on Pluralsight](https://www.pluralsight.com/courses/flutter-getting-started)

[Flutter Online Training Courses on LinkedIn Learning](https://www.linkedin.com/learning/topics/flutter)

[The Complete Flutter App Development Bootcamp with Dart by App Brewery](https://www.appbrewery.co/p/flutter-development-bootcamp-with-dart)

[Adding Firebase to your Flutter app](https://firebase.google.com/docs/flutter/setup)

[Using Firebase and Firestore with Flutter](https://flutter.dev/docs/development/data-and-backend/firebase)

[Fuchsia Project](https://fuchsia.dev/)

[Getting Started with Fuchsia](https://fuchsia.dev/fuchsia-src/get-started)

[Fuchsia Reference](https://fuchsia.dev/reference)

[Contributing to Fuchsia](https://fuchsia.dev/fuchsia-src/CONTRIBUTING)

## Flutter Tools

[Firebase](https://firebase.google.com/) is a Backend-as-a-Service (BaaS) app development platform that provides hosted backend services such as a realtime database, cloud storage, authentication, crash reporting, machine learning, remote configuration, and hosting for your static files.

[FlutterFire](https://firebase.flutter.dev/) is a set of [Flutter plugins](https://flutter.io/platform-plugins/) that enable Flutter apps to use [Firebase](https://firebase.google.com/) services. You can follow an example that shows how to use these plugins in the [Firebase for Flutter](https://codelabs.developers.google.com/codelabs/flutter-firebase/index.html#0) codelab.

[FlutterBoost](https://github.com/alibaba/flutter_boost) is a Flutter plugin which enables hybrid integration of Flutter for your existing native apps with minimum efforts.

[Go-flutter](https://github.com/go-flutter-desktop/go-flutter) is a package that brings Flutter to the desktop. project implements the [Flutter's Embedding API](https://github.com/flutter/flutter/wiki/Custom-Flutter-Engine-Embedders) using a single code base that runs on Windows, macOS, and Linux. For rendering, [GLFW](https://github.com/go-gl/glfw) fits the job because it provides the right abstractions over the OpenGL's Buffer/Mouse/Keyboard for each platform.

[Appwrite](https://appwrite.io/) is a secure end-to-end backend server for Web, Mobile, and Flutter developers that is packaged as a set of Docker containers for easy deployment.

[Fluro](https://github.com/theyakka/fluro) is a Flutter routing library that adds flexible routing options like wildcards, named parameters and clear route definitions.

# Node.js Development

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/93719688-0becd700-fb39-11ea-9b87-3d52f1828aee.png">
  <br />
</p>

## Node.js Learning Resources

[Node.js](https://nodejs.org/) is a JavaScript runtime built on Chrome's V8 JavaScript engine that lets developers write command line tools and server-side scripts outside of a browser.

[Node.js Build Working Group](https://github.com/nodejs/build) maintains and controls infrastructure used for continuous integration (CI), releases, benchmarks, web hosting (of nodejs.org and other Node.js web properties) and more.

[The OpenJS Foundation](https://openjsf.org/) is made up of 32 open source JavaScript projects including Appium, Dojo, Electron, jQuery, Node.js, and webpack. The foundation's mission is to support the healthy growth of JavaScript and web technologies by providing a neutral organization to host and sustain projects, as well as collaboratively fund activities that benefit the ecosystem as a whole.

[Set up NodeJS on WSL 2](https://docs.microsoft.com/en-us/windows/nodejs/setup-on-wsl2)

[Getting started with Node.js in Google Cloud](https://cloud.google.com/nodejs/getting-started)

[Getting Started with Node.js in AWS](https://docs.aws.amazon.com/sdk-for-javascript/v2/developer-guide/getting-started-nodejs.html)

[Node.js App Hosting & Deployment in Microsoft Azure](https://azure.microsoft.com/en-us/develop/nodejs/)

[The Node.js best practices list ](https://github.com/goldbergyoni/nodebestpractices)

[Introduction to Node.js by W3Schools](https://www.w3schools.com/nodejs/nodejs_intro.asp)

[The Node.js Community Committee](https://github.com/nodejs/community-committee)

[Node.js Mentorship Program Initiative](https://github.com/nodejs/mentorship)

[Node.js tutorial in Visual Studio Code](https://code.visualstudio.com/docs/nodejs/nodejs-tutorial)

[Server-side Development with NodeJS, Express and MongoDB on Coursera](https://www.coursera.org/learn/server-side-nodejs)

## Node.js Tools

[NPM](https://www.npmjs.com/) is the company behind Node package manager, the npm Registry, and npm CLI.

[node-gyp](https://github.com/nodejs/node-gyp) is a cross-platform command-line tool written in Node.js for compiling native addon modules for Node.js. It contains a vendored copy of the gyp-next project that was previously used by the Chromium team, extended to support the development of Node.js native addons.

[nvm ](https://github.com/nvm-sh/nvm) is a version manager for node.js, designed to be installed per-user, and invoked per-shell. nvm works on any POSIX-compliant shell (sh, dash, ksh, zsh, bash), in particular on these platforms: unix, macOS, and windows WSL.

[node-docker](https://hub.docker.com/_/node/) is the official Node.js docker image, made with love by the node community.

[Mocha](https://github.com/mochajs/mocha) is a simple, flexible, fun JavaScript test framework for Node.js & The Browser.

[AVA](https://github.com/avajs/ava) is a test runner for Node.js with a concise API, detailed error output, embrace of new language features and process isolation that lets you develop with confidence.

[egg](https://eggjs.org/) is a born to build better enterprise frameworks and apps with Node.js & Koa.

[mysqljs](https://github.com/mysqljs/mysql) is a pure node.js JavaScript Client implementing the MySQL protocol.

[axios](https://github.com/axios/axios) is a promise based HTTP client for the browser and node.js.

[Fastify](https://www.fastify.io/) is a fast and low overhead web framework, for Node.js.

[Express](https://expressjs.com/) is a fast, unopinionated, minimalist web framework for node.

[Meteor](https://www.meteor.com/) is an ultra-simple environment for building modern web applications with JavavScript.

[NW.js](https://nwjs.io/) is an app runtime based on Chromium and node.js. You can write native apps in HTML and JavaScript with NW.js. It also lets you call Node.js modules directly from the DOM and enables a new way of writing native applications with all Web technologies.

[PM2](https://pm2.io/) is a production process manager for Node.js applications with a built-in load balancer. It allows you to keep applications alive forever, to reload them without downtime and to facilitate common system admin tasks.

[NestJS](https://nestjs.com/) is a framework for building efficient, scalable Node.js web applications. It uses modern JavaScript, is built with TypeScript and combines elements of OOP (Object Oriented Progamming), FP (Functional Programming), and FRP (Functional Reactive Programming).

[jenkins-nodejs](https://plugins.jenkins.io/nodejs/) is a Jenkins plugin for Node.js that provides the NodeJS auto-installer, allowing to create as many NodeJS installations "profiles" as you want.

[Strapi](https://strapi.io/) is an open source Node.js Headless CMS to easily build customisable APIs.

[Standard](https://standardjs.com/) is a JavaScript Style Guide, with linter & automatic code fixer.

[React Starter Kit](https://www.reactstarterkit.com/) is an isomorphic web app boilerplate for web development built on top of [Node.js](https://nodejs.org/), [Express](http://expressjs.com/), [GraphQL](http://graphql.org/) and [React](https://facebook.github.io/react/), containing modern web development tools such as [Webpack](https://webpack.github.io/), [Babel](https://babeljs.io/) and [Browsersync](https://www.browsersync.io/). Helping you to stay productive following the best practices.

[Hexo](https://hexo.io/) is a A fast, simple & powerful blog framework, powered by Node.js.


# Networking

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/82833053-d1687b80-9e71-11ea-8c6d-074100f2f54b.png">
  <br />
</p>

## Networking Learning Resources

[AWS Certified Security - Specialty Certification](https://aws.amazon.com/certification/certified-security-specialty/)

[Microsoft Certified: Azure Security Engineer Associate](https://docs.microsoft.com/en-us/learn/certifications/azure-security-engineer)

[Google Cloud Certified Professional Cloud Security Engineer](https://cloud.google.com/certification/cloud-security-engineer)

[Cisco Security Certifications](https://www.cisco.com/c/en/us/training-events/training-certifications/certifications/security.html)

[The Red Hat Certified Specialist in Security: Linux](https://www.redhat.com/en/services/training/ex415-red-hat-certified-specialist-security-linux-exam)

[Linux Professional Institute LPIC-3 Enterprise Security Certification](https://www.lpi.org/our-certifications/lpic-3-303-overview)

[Cybersecurity Training and Courses from IBM Skills](https://www.ibm.com/skills/topics/cybersecurity/)

[Cybersecurity Courses and Certifications by Offensive Security](https://www.offensive-security.com/courses-and-certifications/)

[Citrix Certified Associate – Networking(CCA-N)](http://training.citrix.com/cms/index.php/certification/networking/)

[Citrix Certified Professional – Virtualization(CCP-V)](https://www.globalknowledge.com/us-en/training/certification-prep/brands/citrix/section/virtualization/citrix-certified-professional-virtualization-ccp-v/)

[CCNP Routing and Switching](https://learningnetwork.cisco.com/s/ccnp-enterprise)

[Certified Information Security Manager(CISM)](https://www.isaca.org/credentialing/cism)

[Wireshark Certified Network Analyst (WCNA)](https://www.wiresharktraining.com/certification.html)

[Juniper Networks Certification Program Enterprise (JNCP)](https://www.juniper.net/us/en/training/certification/)

[Networking courses and specializations from Coursera](https://www.coursera.org/browse/information-technology/networking)

[Network & Security Courses from Udemy](https://www.udemy.com/courses/it-and-software/network-and-security/)

[Network & Security Courses from edX](https://www.edx.org/learn/cybersecurity)

  ## Tools & Networking Concepts

    • Connection: In networking, a connection refers to pieces of related information that are transferred through a network. This generally infers that a connection is built before the data transfer (by following the procedures laid out in a protocol) and then is deconstructed at the at the end of the data transfer.

    • Packet: A packet is, generally speaking, the most basic unit that is transferred over a network. When communicating over a network, packets are the envelopes that carry your data (in pieces) from one end point to the other.

Packets have a header portion that contains information about the packet including the source and destination, timestamps, network hops. The main portion of a packet contains the actual data being transferred. It is sometimes called the body or the payload.

    • Network Interface: A network interface can refer to any kind of software interface to networking hardware. For instance, if you have two network cards in your computer, you can control and configure each network interface associated with them individually.

A network interface may be associated with a physical device, or it may be a representation of a virtual interface. The "loop-back" device, which is a virtual interface to the local machine, is an example of this.

    • LAN: LAN stands for "local area network". It refers to a network or a portion of a network that is not publicly accessible to the greater internet. A home or office network is an example of a LAN.

    • WAN: WAN stands for "wide area network". It means a network that is much more extensive than a LAN. While WAN is the relevant term to use to describe large, dispersed networks in general, it is usually meant to mean the internet, as a whole.
If an interface is connected to the WAN, it is generally assumed that it is reachable through the internet.

    • Protocol: A protocol is a set of rules and standards that basically define a language that devices can use to communicate. There are a great number of protocols in use extensively in networking, and they are often implemented in different layers.

Some low level protocols are TCP, UDP, IP, and ICMP. Some familiar examples of application layer protocols, built on these lower protocols, are HTTP (for accessing web content), SSH, TLS/SSL, and FTP.

    • Port: A port is an address on a single machine that can be tied to a specific piece of software. It is not a physical interface or location, but it allows your server to be able to communicate using more than one application.

    • Firewall: A firewall is a program that decides whether traffic coming into a server or going out should be allowed. A firewall usually works by creating rules for which type of traffic is acceptable on which ports. Generally, firewalls block ports that are not used by a specific application on a server.

    • NAT: Network address translation is a way to translate requests that are incoming into a routing server to the relevant devices or servers that it knows about in the LAN. This is usually implemented in physical LANs as a way to route requests through one IP address to the necessary backend servers.

    • VPN: Virtual private network is a means of connecting separate LANs through the internet, while maintaining privacy. This is used as a means of connecting remote systems as if they were on a local network, often for security reasons.

## Network Layers

	While networking is often discussed in terms of topology in a horizontal way, between hosts, its implementation is layered in a vertical fashion throughout a computer or network. This means is that there are multiple technologies and protocols that are built on top of each other in order for communication to function more easily. Each successive, higher layer abstracts the raw data a little bit more, and makes it simpler to use for applications and users. It also allows you to leverage lower layers in new ways without having to invest the time and energy to develop the protocols and applications that handle those types of traffic.

	As data is sent out of one machine, it begins at the top of the stack and filters downwards. At the lowest level, actual transmission to another machine takes place. At this point, the data travels back up through the layers of the other computer. Each layer has the ability to add its own "wrapper" around the data that it receives from the adjacent layer, which will help the layers that come after decide what to do with the data when it is passed off.

	One method of talking about the different layers of network communication is the OSI model. OSI stands for Open Systems Interconnect.This model defines seven separate layers. The layers in this model are:

    • Application: The application layer is the layer that the users and user-applications most often interact with. Network communication is discussed in terms of availability of resources, partners to communicate with, and data synchronization.

    • Presentation: The presentation layer is responsible for mapping resources and creating context. It is used to translate lower level networking data into data that applications expect to see.

    • Session: The session layer is a connection handler. It creates, maintains, and destroys connections between nodes in a persistent way.

    • Transport: The transport layer is responsible for handing the layers above it a reliable connection. In this context, reliable refers to the ability to verify that a piece of data was received intact at the other end of the connection. This layer can resend information that has been dropped or corrupted and can acknowledge the receipt of data to remote computers.

    • Network: The network layer is used to route data between different nodes on the network. It uses addresses to be able to tell which computer to send information to. This layer can also break apart larger messages into smaller chunks to be reassembled on the opposite end.

    • Data Link: This layer is implemented as a method of establishing and maintaining reliable links between different nodes or devices on a network using existing physical connections.

    • Physical: The physical layer is responsible for handling the actual physical devices that are used to make a connection. This layer involves the bare software that manages physical connections as well as the hardware itself (like Ethernet).

The TCP/IP model, more commonly known as the Internet protocol suite, is another layering model that is simpler and has been widely adopted.It defines the four separate layers, some of which overlap with the OSI model:

    • Application: In this model, the application layer is responsible for creating and transmitting user data between applications. The applications can be on remote systems, and should appear to operate as if locally to the end user.
The communication takes place between peers network.

    • Transport: The transport layer is responsible for communication between processes. This level of networking utilizes ports to address different services. It can build up unreliable or reliable connections depending on the type of protocol used.

    • Internet: The internet layer is used to transport data from node to node in a network. This layer is aware of the endpoints of the connections, but does not worry about the actual connection needed to get from one place to another. IP addresses are defined in this layer as a way of reaching remote systems in an addressable manner.

    • Link: The link layer implements the actual topology of the local network that allows the internet layer to present an addressable interface. It establishes connections between neighboring nodes to send data.

## Interfaces
Interfaces are networking communication points for your computer. Each interface is associated with a physical or virtual networking device. Typically, your server will have one configurable network interface for each Ethernet or wireless internet card you have. In addition, it will define a virtual network interface called the "loopback" or localhost interface. This is used as an interface to connect applications and processes on a single computer to other applications and processes. You can see this referenced as the "lo" interface in many tools.

## Protocols
Networking works by piggybacks on a number of different protocols on top of each other. In this way, one piece of data can be transmitted using multiple protocols encapsulated within one another.

Media access control is a communications protocol that is used to distinguish specific devices. Each device is supposed to get a unique MAC address during the manufacturing process that differentiates it from every other device on the internet. Addressing hardware by the MAC address allows you to reference a device by a unique value even when the software on top may change the name for that specific device during operation. Media access control is one of the only protocols from the link layer that you are likely to interact with on a regular basis.

The IP protocol is one of the fundamental protocols that allow the internet to work. IP addresses are unique on each network and they allow machines to address each other across a network. It is implemented on the internet layer in the IP/TCP model. Networks can be linked together, but traffic must be routed when crossing network boundaries. This protocol assumes an unreliable network and multiple paths to the same destination that it can dynamically change between. There are a number of different implementations of the protocol. The most common implementation today is IPv4, although IPv6 is growing in popularity as an alternative due to the scarcity of IPv4 addresses available and improvements in the protocols capabilities.

ICMP: internet control message protocol is used to send messages between devices to indicate the availability or error conditions. These packets are used in a variety of network diagnostic tools, such as ping and traceroute. Usually ICMP packets are transmitted when a packet of a different kind meets some kind of a problem. Basically, they are used as a feedback mechanism for network communications.

TCP: Transmission control protocol is implemented in the transport layer of the IP/TCP model and is used to establish reliable connections. TCP is one of the protocols that encapsulates data into packets. It then transfers these to the remote end of the connection using the methods available on the lower layers. On the other end, it can check for errors, request certain pieces to be resent, and reassemble the information into one logical piece to send to the application layer. The protocol builds up a connection prior to data transfer using a system called a three-way handshake. This is a way for the two ends of the communication to acknowledge the request and agree upon a method of ensuring data reliability. After the data has been sent, the connection is torn down using a similar four-way handshake. TCP is the protocol of choice for many of the most popular uses for the internet, including WWW, FTP, SSH, and email. It is safe to say that the internet we know today would not be here without TCP.

UDP: User datagram protocol is a popular companion protocol to TCP and is also implemented in the transport layer. The fundamental difference between UDP and TCP is that UDP offers unreliable data transfer. It does not verify that data has been received on the other end of the connection. This might sound like a bad thing, and for many purposes, it is. However, it is also extremely important for some functions. It’s not required to wait for confirmation that the data was received and forced to resend data, UDP is much faster than TCP. It does not establish a connection with the remote host, it simply fires off the data to that host and doesn't care if it is accepted or not. Since UDP is a simple transaction, it is useful for simple communications like querying for network resources. It also doesn't maintain a state, which makes it great for transmitting data from one machine to many real-time clients. This makes it ideal for VOIP, games, and other applications that cannot afford delays.

HTTP: Hypertext transfer protocol is a protocol defined in the application layer that forms the basis for communication on the web. HTTP defines a number of functions that tell the remote system what you are requesting. For instance, GET, POST, and DELETE all interact with the requested data in a different way.

[JSON Web Token (JWT)](https://jwt.io) is a compact URL-safe means of representing claims to be transferred between two parties. The claims in a JWT are encoded as a JSON object that is digitally signed using JSON Web Signature (JWS).

[OAuth 2.0](https://oauth.net/2/) is an open source authorization framework that enables applications to obtain limited access to user accounts on an HTTP service, such as Amazon, Google, Facebook, Microsoft, Twitter GitHub, and DigitalOcean. It works by delegating user authentication to the service that hosts the user account, and authorizing third-party applications to access the user account.

FTP: File transfer protocol is in the application layer and provides a way of transferring complete files from one host to another. It is inherently insecure, so it is not recommended for any externally facing network unless it is implemented as a public, download-only resource.

DNS: Domain name system is an application layer protocol used to provide a human-friendly naming mechanism for internet resources. It is what ties a domain name to an IP address and allows you to access sites by name in your browser.

SSH: Secure shell is an encrypted protocol implemented in the application layer that can be used to communicate with a remote server in a secure way. Many additional technologies are built around this protocol because of its end-to-end encryption and ubiquity. There are many other protocols that we haven't covered that are equally important. However, this should give you a good overview of some of the fundamental technologies that make the internet and networking possible.

## Virtualization

[KVM (for Kernel-based Virtual Machine)](https://www.linux-kvm.org/page/Main_Page) is a full virtualization solution for Linux on x86 hardware containing virtualization extensions (Intel VT or AMD-V). It consists of a loadable kernel module, kvm.ko, that provides the core virtualization infrastructure and a processor specific module, kvm-intel.ko or kvm-amd.ko.

[QEMU](https://www.qemu.org) is a fast processor emulator using a portable dynamic translator. QEMU emulates a full system, including a processor and various peripherals. It can be used to launch a different Operating System without rebooting the PC or to debug system code.

[Hyper-V](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/) enables running virtualized computer systems on top of a physical host. These virtualized systems can be used and managed just as if they were physical computer systems, however they exist in virtualized and isolated environment. Special software called a hypervisor manages access between the virtual systems and the physical hardware resources. Virtualization enables quick deployment of computer systems, a way to quickly restore systems to a previously known good state, and the ability to migrate systems between physical hosts.

[VirtManager](https://github.com/virt-manager/virt-manager) is a graphical tool for managing virtual machines via libvirt. Most usage is with QEMU/KVM virtual machines, but Xen and libvirt LXC containers are well supported. Common operations for any libvirt driver should work.

[oVirt](https://www.ovirt.org) is an open-source distributed virtualization solution, designed to manage your entire enterprise infrastructure. oVirt uses the trusted KVM hypervisor and is built upon several other community projects, including libvirt, Gluster, PatternFly, and Ansible.Founded by Red Hat as a community project on which Red Hat Enterprise Virtualization is based allowing for centralized management of virtual machines, compute, storage and networking resources, from an easy-to-use web-based front-end with platform independent access.

[Xen](https://github.com/xen-project/xen) is focused on advancing virtualization in a number of different commercial and open source applications, including server virtualization, Infrastructure as a Services (IaaS), desktop virtualization, security applications, embedded and hardware appliances, and automotive/aviation.

[Ganeti](https://github.com/ganeti/ganeti) is a virtual machine cluster management tool built on top of existing virtualization technologies such as Xen or KVM and other open source software. Once installed, the tool assumes management of the virtual instances (Xen DomU).

[Packer](https://www.packer.io/) is an open source tool for creating identical machine images for multiple platforms from a single source configuration. Packer is lightweight, runs on every major operating system, and is highly performant, creating machine images for multiple platforms in parallel. Packer does not replace configuration management like Chef or Puppet. In fact, when building images, Packer is able to use tools like Chef or Puppet to install software onto the image.

[Vagrant](https://www.vagrantup.com/) is a tool for building and managing virtual machine environments in a single workflow. With an easy-to-use workflow and focus on automation, Vagrant lowers development environment setup time, increases production parity, and makes the "works on my machine" excuse a relic of the past. It provides easy to configure, reproducible, and portable work environments built on top of industry-standard technology and controlled by a single consistent workflow to help maximize the productivity and flexibility of you and your team.

[VMware Workstation](https://www.vmware.com/products/workstation-pro.html) is a hosted hypervisor that runs on x64 versions of Windows and Linux operating systems; it enables users to set up virtual machines on a single physical machine, and use them simultaneously along with the actual machine.

[VirtualBox](https://www.virtualbox.org) is a powerful x86 and AMD64/Intel64 virtualization product for enterprise as well as home use. Not only is VirtualBox an extremely feature rich, high performance product for enterprise customers.

# Databases

[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

<p align="center">
 <img src="https://user-images.githubusercontent.com/45159366/111918157-fcdfd680-8a40-11eb-96e9-7fecb43ea0eb.png">
  <br />
</p>

# SQL/NoSQL Learning Resources

[SQL](https://en.wikipedia.org/wiki/SQL) is a standard language for storing, manipulating and retrieving data in relational databases.

[NoSQL](https://www.ibm.com/cloud/blog/sql-vs-nosql) is a database that is interchangeably referred to as "nonrelational, or "non-SQL" to highlight that the database can handle huge volumes of rapidly changing, unstructured data in different ways than a relational (SQL-based) database with rows and tables.

[SQL Tutorial by W3Schools](https://www.w3schools.com/sql/)

[Learn SQL Skills Online from Coursera](https://www.coursera.org/courses?query=sql)

[SQL Courses Online from Udemy](https://www.udemy.com/topic/sql/)

[SQL Online Training Courses from LinkedIn Learning](https://www.linkedin.com/learning/topics/sql)

[Learn SQL For Free from Codecademy](https://www.codecademy.com/learn/learn-sql)

[GitLab's SQL Style Guide](https://about.gitlab.com/handbook/business-ops/data-team/platform/sql-style-guide/)

[OracleDB SQL Style Guide Basics](https://oracle.readthedocs.io/en/latest/sql/basics/style-guide.html)

[Tableau CRM: BI Software and Tools](https://www.salesforce.com/products/crm-analytics/overview/)

[Databases on AWS](https://aws.amazon.com/products/databases/)

[Best Practices and Recommendations for SQL Server Clustering in AWS EC2.](https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/aws-sql-clustering.html)

[Connecting from Google Kubernetes Engine to a Cloud SQL instance.](https://cloud.google.com/sql/docs/mysql/connect-kubernetes-engine)

[Educational Microsoft Azure SQL resources](https://docs.microsoft.com/en-us/sql/sql-server/educational-sql-resources?view=sql-server-ver15)

[MySQL Certifications](https://www.mysql.com/certification/)

[SQL vs. NoSQL Databases: What's the Difference?](https://www.ibm.com/cloud/blog/sql-vs-nosql)

[What is NoSQL?](https://aws.amazon.com/nosql/)

# SQL/NoSQL Tools and Databases

[Azure Data Studio](https://github.com/Microsoft/azuredatastudio) is an open source data management tool that enables working with SQL Server, Azure SQL DB and SQL DW from Windows, macOS and Linux.

[Azure SQL Database](https://azure.microsoft.com/en-us/services/sql-database/)  is the intelligent, scalable, relational database service built for the cloud. It’s evergreen and always up to date, with AI-powered and automated features that optimize performance and durability for you. Serverless compute and Hyperscale storage options automatically scale resources on demand, so you can focus on building new applications without worrying about storage size or resource management.

[Azure SQL Managed Instance](https://azure.microsoft.com/en-us/services/azure-sql/sql-managed-instance/) is a fully managed SQL Server Database engine instance that's hosted in Azure and placed in your network. This deployment model makes it easy to lift and shift your on-premises applications to the cloud with very few application and database changes. Managed instance has split compute and storage components.

[Azure Synapse Analytics](https://azure.microsoft.com/en-us/services/synapse-analytics/) is a limitless analytics service that brings together enterprise data warehousing and Big Data analytics. It gives you the freedom to query data on your terms, using either serverless or provisioned resources at scale. It brings together the best of the SQL technologies used in enterprise data warehousing, Spark technologies used in big data analytics, and Pipelines for data integration and ETL/ELT.

[MSSQL for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-mssql.mssql) is an extension for developing Microsoft SQL Server, Azure SQL Database and SQL Data Warehouse everywhere with a rich set of functionalities.

[SQL Server Data Tools (SSDT)](https://docs.microsoft.com/en-us/sql/ssdt/download-sql-server-data-tools-ssdt) is a development tool for building SQL Server relational databases, Azure SQL Databases, Analysis Services (AS) data models, Integration Services (IS) packages, and Reporting Services (RS) reports. With SSDT, a developer can design and deploy any SQL Server content type with the same ease as they would develop an application in Visual Studio or Visual Studio Code.

[Bulk Copy Program](https://docs.microsoft.com/en-us/sql/tools/bcp-utility) is a command-line tool that comes with Microsoft SQL Server. BCP, allows you to import and export large amounts of data in and out of SQL Server databases quickly snd efficeiently.

[SQL Server Migration Assistant](https://www.microsoft.com/en-us/download/details.aspx?id=54258) is a tool from Microsoft that simplifies database migration process from Oracle to SQL Server, Azure SQL Database, Azure SQL Database Managed Instance and Azure SQL Data Warehouse.

[SQL Server Integration Services](https://docs.microsoft.com/en-us/sql/integration-services/sql-server-integration-services?view=sql-server-ver15) is a development platform for building enterprise-level data integration and data transformations solutions. Use Integration Services to solve complex business problems by copying or downloading files, loading data warehouses, cleansing and mining data, and managing SQL Server objects and data.

[SQL Server Business Intelligence(BI)](https://www.microsoft.com/en-us/sql-server/sql-business-intelligence) is a collection of tools in Microsoft's SQL Server for transforming raw data into information businesses can use to make decisions.

[Tableau](https://www.tableau.com/) is a Data Visualization software used in relational databases, cloud databases, and spreadsheets. Tableau was acquired by [Salesforce in August 2019](https://investor.salesforce.com/press-releases/press-release-details/2019/Salesforce-Completes-Acquisition-of-Tableau/default.aspx).

[DataGrip](https://www.jetbrains.com/datagrip/) is a professional DataBase IDE developed by Jet Brains that provides context-sensitive code completion, helping you to write SQL code faster. Completion is aware of the tables structure, foreign keys, and even database objects created in code you're editing.

[RStudio](https://rstudio.com/) is an integrated development environment for R and Python, with a console, syntax-highlighting editor that supports direct code execution, and tools for plotting, history, debugging and workspace management.

[MySQL](https://www.mysql.com/) is a fully managed database service to deploy cloud-native applications using the world's most popular open source database.

[PostgreSQL](https://www.postgresql.org/) is a powerful, open source object-relational database system with over 30 years of active development that has earned it a strong reputation for reliability, feature robustness, and performance.

[Amazon DynamoDB](https://aws.amazon.com/dynamodb/) is a key-value and document database that delivers single-digit millisecond performance at any scale. It is a fully managed, multiregion, multimaster, durable database with built-in security, backup and restore, and in-memory caching for internet-scale applications.

[Apache Cassandra](https://cassandra.apache.org/) is an open source NoSQL distributed database trusted by thousands of companies for scalability and high availability without compromising performance. Cassandra provides linear scalability and proven fault-tolerance on commodity hardware or cloud infrastructure make it the perfect platform for mission-critical data.

[FoundationDB](https://www.foundationdb.org/) is an open source distributed database designed to handle large volumes of structured data across clusters of commodity servers. It organizes data as an ordered key-value store and employs ACID transactions for all operations. It is especially well-suited for read/write workloads but also has excellent performance for write-intensive workloads. FoundationDB was acquired by [Apple in 2015](https://techcrunch.com/2015/03/24/apple-acquires-durable-database-company-foundationdb/).

[IBM DB2](https://www.ibm.com/analytics/db2) is a collection of hybrid data management products offering a complete suite of AI-empowered capabilities designed to help you manage both structured and unstructured data on premises as well as in private and public cloud environments. Db2 is built on an intelligent common SQL engine designed for scalability and flexibility.

[MongoDB](https://www.mongodb.com/) is a document database meaning it stores data in JSON-like documents.

[OracleDB](https://www.oracle.com/database/) is a powerful fully managed database helps developers manage business-critical data with the highest availability, reliability, and security.

[MariaDB](https://mariadb.com/) is an enterprise open source database solution for modern, mission-critical applications.

[SQLite](https://sqlite.org/index.html) is a C-language library that implements a small, fast, self-contained, high-reliability, full-featured, SQL database engine.SQLite is the most used database engine in the world. SQLite is built into all mobile phones and most computers and comes bundled inside countless other applications that people use every day.

[SQLite Database Browser](https://sqlitebrowser.org/) is an open source SQL tool that allows users to create, design and edits SQLite database files. It lets users show a log of all the SQL commands that have been issued by them and by the application itself.

[CouchbaseDB](https://www.couchbase.com/) is an open source distributed [multi-model NoSQL document-oriented database](https://en.wikipedia.org/wiki/Multi-model_database). It creates a key-value store with managed cache for sub-millisecond data operations, with purpose-built indexers for efficient queries and a powerful query engine for executing SQL queries.

[dbWatch](https://www.dbwatch.com/) is a complete database monitoring/management solution for SQL Server, Oracle, PostgreSQL, Sybase, MySQL and Azure. Designed for proactive management and automation of routine maintenance in large scale on-premise, hybrid/cloud database environments.

[Cosmos DB Profiler](https://hibernatingrhinos.com/products/cosmosdbprof) is a real-time visual debugger allowing a development team to gain valuable insight and perspective into their usage of Cosmos DB database. It identifies over a dozen suspicious behaviors from your application’s interaction with Cosmos DB.

[Adminer](https://www.adminer.org/) is an SQL management client tool for managing databases, tables, relations, indexes, users. Adminer has support for all the popular database management systems such as MySQL, MariaDB, PostgreSQL, SQLite, MS SQL, Oracle, Firebird, SimpleDB, Elasticsearch and MongoDB.

[DBeaver](https://dbeaver.io/) is an open source database tool for developers and database administrators. It offers supports for JDBC compliant databases such as MySQL, Oracle, IBM DB2, SQL Server, Firebird, SQLite, Sybase, Teradata, Firebird, Apache Hive, Phoenix, and Presto.

[DbVisualizer](https://dbvis.com/) is a SQL management tool that allows users to manage a wide range of databases such as Oracle, Sybase, SQL Server, MySQL, H3, and SQLite.

[AppDynamics Database](https://www.appdynamics.com/supported-technologies/database) is a management product for Microsoft SQL Server. With AppDynamics you can monitor and trend key performance metrics such as resource consumption, database objects, schema statistics and more, allowing you to proactively tune and fix issues in a High-Volume Production Environment.

[Toad](https://www.quest.com/toad/) is a SQL Server DBMS toolset developed by Quest. It increases productivity by using extensive automation, intuitive workflows, and built-in expertise. This SQL management tool resolve issues, manage change and promote the highest levels of code quality for both relational and non-relational databases.

[Lepide SQL Server](https://www.lepide.com/sql-storage-manager/) is an open source storage manager utility to analyse the performance of SQL Servers. It provides a complete overview of all configuration and permission changes being made to your SQL Server environment through an easy-to-use, graphical user interface.

[Sequel Pro](https://sequelpro.com/) is a fast MacOS database management tool for working with MySQL. This SQL management tool helpful for interacting with your database by easily to adding new databases, new tables, and new rows.


## Contribute

- [x] If would you like to contribute to this guide simply make a [Pull Request](https://github.com/mikeroyal/Windows-11-Guide/pulls).


## License
[Back to the Top](https://github.com/mikeroyal/Windows-11-Guide/blob/main/README.md#table-of-contents)

Distributed under the [Creative Commons Attribution 4.0 International (CC BY 4.0) Public License](https://creativecommons.org/licenses/by/4.0/).
