# FirmwareCopy

## Ziele

- VSCode einrichten
- GIT einrichten
- Konsolenanwendung anlegen
- Funktionen in Basisprojekt anlegen
- Projekt mit WPF-Anwendung anlegen (GUI)
- Testprojekt anlegen
- Auswahl von Firmwaredateien aus dem Entwicklungsserver
- Major- und Minor-Build wichtig
- Check mit upx-patcher
- Kopiervorgang in DeviceFiles (Ordnerstruktur 87xyz)

## Einrichten VSCode

- Befehl: `dotnet new console`
- C# extensions installiert
  --> dotnet core 3.1 sdk installieren
- don't be a douchebag and name your program like a system namespace

## Einrichten Git

- download Git
- Standard-Installation mit VSCode als Editor
- `git init` auf Folder FirmwareCopy
- .gitignore hinzugefügt mit git bash `touch .gitignore`
- .gitignore-Code aus https://github.com/github/gitignore/blob/master/VisualStudio.gitignore
- Dateien gestaged und commited

## Basisfunktionalität in neuem Projekt implementieren

- Projekt `BasicFunctions` angelegt mit `dotnet new classlib`
- Referenz zu ConsoleApp mit `dotnet add reference ..\BasicFunctions`
- json-File angelegt, Syntax für Dictionary
- `Prettier` installiert
- formatting für json und md in `settings.json` angepasst
- `CopyService Klasse` erzeugt mit Methode zum Einlesen des Json-Files
- Nuget-Packet `System.Text.Json` installiert --> `dotnet add package <paket>`
- Serialisierungs-Methode aus o.g. Paket benutzt und Exception Handling hinzugefügt
- .gitignore für \*.upx-ignore erweitert

## Github account erstellt und Projekt gepushed

- command für local remote Verknüpfung: `git remote add origin https://github.com/Spike008/CopyFirmware.git`
- commad push: `git push -u origin master` (Login erforderlich)
