# Branching Guide

Folgendes wird in diesem Guideline behandelt:
* Aufbau der Branchzweige
* Vorgehen zum Erstellen von neuen Branches anhand von Issues
* Vorgehen zum Erstellen von *Pull Requests* bzw. mergen von Branches


## Allgemein

* Es muss zu einem Feature oder einem Hotfix immer ein Issue geben.
* Commit-Nachricht mit folgendem Format: `#{issueid} - foo, bar`
* Commit-Nachrichten enthalten kurze und pregnante Änderungen
* So oft wie es geht Änderungen committen und wenn möglichen mit GitHub synchronisieren

## Branches

### master

* Ist der letzte releasebare Stand
* *Pull Request*s aus **develop** oder **hotfix/{issueid}**
* Vom **master** wurde initial der **develop**-Branch erzeugt 

### develop

* Ist der aktuelle Entwicklungszweig
* Alle Branches von **features/\#{issueid}** werden hier per *Pull Request** *gemerged* 

### release/{version}

* Wird immer von **master** erstellt
* Wird erstellt, nachdem der *Pull Request* nach **develop** erfolgreich erfolgt ist

### features/\#{issueid}

1. Erstellen von **develop**
2. Nach Beendigung, *Pull Request* nach **develop**
    * Alle noch offenen Branches *mergen* dann von **develop** in ihren Branch (ausgeschlossen sind **master** und **hotfix/\#{issueid}**) 

### hotfix/\#{issueid}

1. Erstellung von **master**-Branch
2. Nach Beendigung, *Pull Request* in **master** und *merge* in den **develop**-Zweig