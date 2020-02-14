# FirmwareCopy

## Ziele

* VSCode einrichten
* GIT einrichten
* Konsolenanwendung anlegen
* Funktionen in Basisprojekt anlegen
* Projekt mit WPF-Anwendung anlegen (GUI) 
* Testprojekt anlegen
* Auswahl von Firmwaredateien aus dem Entwicklungsserver
* Major- und Minor-Build wichtig
* Check mit upx-patcher
* Kopiervorgang in DeviceFiles (Ordnerstruktur 87xyz)

## Einrichten VSCode


* Befehl: `dotnet new console`  
* C# extensions installiert
--> dotnet core 3.1 sdk installieren
* don't be a douchebag and name your program like a system namespace

## Einrichten Git

* download Git
* Standard-Installation mit VSCode als Editor
* `git init` auf Folder FirmwareCopy
* .gitignore hinzugefügt  mit git bash `touch .gitignore`
* .gitignore-Code aus https://github.com/github/gitignore/blob/master/VisualStudio.gitignore
* Dateien gestaged und commited

## Basisfunktionalität in neuem Projekt implementieren

* Projekt `BasicFunctions` angelegt mit `dotnet new classlib`
* Referenz zu ConsoleApp mit `dotnet add reference ..\BasicFunctions
`

