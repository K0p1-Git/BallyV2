; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{A68DECFF-C61F-47C0-96C1-381564FD30B4}
AppName=BALLY
AppVersion=2.1
;AppVerName=BALLY 2.1
AppPublisher=Jason's
AppPublisherURL=http://www.example.com/
AppSupportURL=http://www.example.com/
AppUpdatesURL=http://www.example.com/
DefaultDirName={pf}\BALLY
DisableProgramGroupPage=yes
OutputDir=F:\UnityProject\Bally version 2\Build\Window\version 2
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\UnityProject\Bally version 2\Build\Window\version 2\Bally [BETA 2.0].exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\UnityProject\Bally version 2\Build\Window\version 2\Data\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\BALLY"; Filename: "{app}\Bally [BETA 2.0].exe"
Name: "{commondesktop}\BALLY"; Filename: "{app}\Bally [BETA 2.0].exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Bally [BETA 2.0].exe"; Description: "{cm:LaunchProgram,BALLY}"; Flags: nowait postinstall skipifsilent
