# ReClass.NET
This is a port of ReClass to the .NET platform with lots of additional features.

![](https://abload.de/img/main4hsbj.jpg)

## Features
- Support for x86 / x64
- File import from ReClass 2007-2016 and ReClass QT
- Memory Nodes
  - Arrays and Pointers to every other node types
  - Hex 8 / 16 / 32 / 64
  - Int 8 / 16 / 32 / 64
  - UInt 8 / 16 / 32 / 64
  - Bool
  - Bits ![](https://abload.de/img/bitsnhlql.jpg)
  - Enumerations
  - Float / Double
  - Vector 2 / 3 / 4
  - Matrix 3x3 / 3x4 / 4x4
  - UTF8 / UTF16 / UTF32 Text and pointer to text
  - Virtual Tables
  - Function
  - Function Pointer
  - Unions
- Automatic Node Dissection
- Highlight changed memory
- Pointer Preview
- Copy / Paste Support across ReClass.NET instances
- Display types from Debug Symbols (*.pdb)
- Display Runtime Type Informations (RTTI)
- Control the remote process: start / stop / kill
- Process Selection Dialog with filtering
- Memory Viewer
- Memory Scanner
  - Import files from Cheat Engine and CrySearch
  - Scan for values correlated to your input
- Class address calculator
- Code Generator (C++ / C#)
- Module / Section Dumper
- Linux Support (tested on Ubuntu 18.04)
- Debugger with "Find out what writes/accesses this address" support
- Plugin Support
  - Plugins can be written in different languages (example: C++, C++/CLI, C#)
  - Plugins can provide custom methods to access an other process (example: use a driver)
  - Plugins can interact with the ReClass.NET windows
  - Plugins can provide node infos which will be displayed (example: class informations for Frostbite games)
  - Plugins can implement custom nodes with load/save and code generation support
- DarkMode
- Configurable Editor Colors
  - Import/Export of Editor Themes
- Open MiniDumps
- Basic Networking-functionality

## Plugins
- [Sample Plugins](https://github.com/ReClassNET/ReClass.NET-SamplePlugin)
- [Frostbite Plugin](https://github.com/ReClassNET/ReClass.NET-FrostbitePlugin)
- [MemoryPipe Plugin](https://github.com/ReClassNET/ReClass.NET-MemoryPipePlugin)
- [LoadBinary Plugin](https://github.com/ReClassNET/ReClass.NET-LoadBinaryPlugin)
- [Handle Abuser Plugin](https://github.com/ReClassNET/ReClass.NET-HandleAbuser)
- [Unreal Plugin](https://github.com/TetzkatLipHoka/ReClass.NET-UnrealPlugin) (by [DrP3pp3r](https://github.com/DrP3pp3r))
- [DriverReader](https://github.com/niemand-sec/ReClass.NET-DriverReader) (by [Niemand](https://github.com/niemand-sec))

- [Playstation 4: Frame4 Plugin](https://github.com/TetzkatLipHoka/ReClass.Net-Frame4Plugin)
- [Playstation 4: PS4Debug Plugin](https://github.com/TetzkatLipHoka/ReClass.Net-PS4DebugPlugin)



To install a plugin just copy it in the "Plugins" folder.
If you want to develop your own plugin just learn from the code of the [Sample Plugins](https://github.com/ReClassNET/ReClass.NET-SamplePlugin) and [Frostbite Plugin](https://github.com/ReClassNET/ReClass.NET-FrostbitePlugin) repositories. If you have developed a nice plugin, leave me a message and I will add it to the list above.

## Installation
Just download the [latest version](https://github.com/TetzkatLipHoka/ReClass.NET/releases) and start the x86 / x64 version or let the launcher decide.

## Tips
- Lots of elements have a context menu. Just right-click it and see what you can do there.
- The node window can be controlled with the keyboard too. Arrow keys can select other keys, combined with the shift key the nodes get selected. The menu key opens the context menu which itself can be controlled with the keyboard.
- The memory address field of a class can contain a real formula not just a fixed address.  
  
  **\<Program.exe> + 0x123** will use the base address of Program.exe and add 0x123 to it.  
  **[0x4012ABDE]** will read the integer (4 byte on x86 / 8 byte on x64) from the address 0x4012ABDE and use this value as class address.  
  **[\<Program.exe> + 0xDE] - AB** will use the base address of Program.exe, add 0xDE to it, read the value from this address and finally sub 0xAB from it.  
  **[\<Program.exe> + offset + [\<Program.exe> + offset2]]** Nested operations are supported too.  
  
  Valid operations are read ([..]), add (+), sub (-), mul (*) and div (/). Please note that all operations are integer calculations.

## Compiling
If you want to compile ReClass.NET just fork the repository and open the ReClass.NET.sln file with Visual Studio 2019.
Compile the project and copy the dependencies to the output folder.

To compile the linux native core library, you need WSL [installed and configured](https://learn.microsoft.com/en-us/cpp/build/walkthrough-build-debug-wsl2). If you do not need linux support, simply unload the project in the Solution Explorer. If you want to build cross-platform (x86/x64) you have to install `g++-multilib` too.

If you use the `Makefile` with `docker` or `podman` you have to build the needed image `gcc_multilib` from the following `Dockerfile` (`docker build -t gcc_multi .`):

```
FROM ubuntu:latest

RUN apt-get update \
 && apt-get install --assume-yes --no-install-recommends --quiet \
        make \
        g++ \
        g++-multilib \
 && apt-get clean all
```

## Videos

[Youtube Playlist](https://www.youtube.com/playlist?list=PLO246BmtoITanq3ygMCL8_w0eov4D8hjk)

## Screenshots

Process Selection

![image](https://github.com/user-attachments/assets/f7b327dc-50d7-44d5-b033-9c398cb5e999)

PS4

![image](https://github.com/user-attachments/assets/c8501516-482d-4264-9128-c5542183fcb8)


Memory Viewer  
![image](https://github.com/user-attachments/assets/d0ea7cc9-e89e-427f-965a-d57061531b5d)


Memory Scanner  
![image](https://github.com/user-attachments/assets/7805d290-1406-42a1-b87f-891508b2d0ed)


Pointer Preview  
![](https://abload.de/img/memorypreview2gsfp.jpg)

Code Generator  
![](https://abload.de/img/codegeneratorqdat2.jpg)
![](https://abload.de/img/codegenerator24qzce.jpg)

Plugins  
![image](https://github.com/user-attachments/assets/83532067-00e2-4a23-8e83-cd2cbfc540e1)
![image](https://github.com/user-attachments/assets/3c0843d3-c48a-4b27-b23b-cb953f32a380)


Settings  
![image](https://github.com/user-attachments/assets/338b41ee-69e7-411c-8e57-3729e70378b7)
![image](https://github.com/user-attachments/assets/219f47b8-7fdf-49c7-99bf-9b64f82f3ee0)
![image](https://github.com/user-attachments/assets/a561947e-3660-4705-9c64-4f615a020f50)
![image](https://github.com/user-attachments/assets/aede026b-b875-429a-8ef2-5eceb6b47f21)


## Authors / Special Thanks
- [KN4CK3R](https://github.com/KN4CK3R)
- DrUnKeN ChEeTaH
- P47R!CK
- DogMatt
- [ajkhoury](https://github.com/ajkhoury)
- [IChooseYou](https://github.com/IChooseYou)
- [stevemk14ebr](https://github.com/stevemk14ebr)
- [Timboy67678](https://github.com/Timboy67678)
- [DarthTon](https://github.com/DarthTon)
- [ReUnioN](https://github.com/ReUnioN)
- leveln
- [buddyfavors](https://github.com/buddyfavors)
- [DrP3pp3r](https://github.com/DrP3pp3r)
- [ko1N](https://github.com/ko1N)
- [Niemand](https://github.com/niemand-sec) (see his talk at [BlackHat Europe 2019 (London) "Unveiling the underground world of Anti-Cheats"](https://www.blackhat.com/eu-19/briefings/schedule/index.html#unveiling-the-underground-world-of-anti-cheats-17358))
- [Pharaoh2k](https://github.com/Pharaoh2k/)
- [Frans Bouma](https://github.com/FransBouma/)
- [João Vítor Moutinho Rocha](https://github.com/jvmr10/)
- [kapai](https://github.com/mkapai/)
- [sakiodre](https://github.com/sakiodre/)
- [кафіф](https://github.com/cafeed28/)
- [Gabriel-Marian Cristei](https://github.com/cristeigabriel/)
- [Peter Elmegaard](https://github.com/Elmegaard/)
- [Deniz Ozmus](https://github.com/dozmus/)
- [FynnTW](https://github.com/FynnTW/)
- [TechForBad](https://github.com/TechForBad/)
- [PeaceBeUponYou](https://github.com/PeaceBeUponYou/)
- [user23333](https://github.com/user23333/)
- [Pinwhell](https://github.com/pinwhell/)
- [Nu](https://github.com/Autoplay1999/)
