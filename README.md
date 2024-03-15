![Software Logo](/openLinksInFileExplorer/icons/openLinkInFileExplorer%20ICON.png)

#  openLinksInFileExplorer
A Software that lets you create links in the web, that when opened highlight the linked filde on your local Windows File Explorer.


## Goals
* Make it easy for users to find the file that is writen about on their local PC by simply showing it in their Windows Explorer Window

## How to use
Here are some examples for links that you can use on your website:
* localDrive:///C:\
* localDrive:///C:\Users\testuser\Documents\testFileGood.txt
* localDrive:///%UserProfile%\
* localDrive:///%UserProfile%\Documents


## Compatability
* Platforms:
    * Windows


## Installation
* Download the .NET Desktop Runtime here:
https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-8.0.3-windows-x64-installer
* Download "openLinksInFIleExplorerSetup.msi" from this project

## What does it do exactly?
* Registeres a protocol called localdrive:/// on your PC
* Opens a small executable to check if the link is ok
* If the link is a File, it opens the explorer and highlights the file
* If its a folder it opens the folder in explorer
