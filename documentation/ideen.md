# Ideen

## Produktbeschreibung

Das Produkt *School* ist eine Schulverwaltungssoftware für schulische Einrichtungen wie Grundschulen, Realschulen, Gymnasien, Universitäten und weiteren Einrichtungen. Diesen Einrichtungen soll es ermöglicht werden, das Personal sowie die Shüler zu verwalten.

## Fachliche Ideen

### Person

> Beschreibung:

> Attribute:

* Vorname
* Nachname
* Geburtstag

### Schule

> Beschreibung:

Eine Schule ist eine schulische Einrichtung. Dieser Einrichtung sind **Lehrer**, **Verwaltungsangestellte** und **Schüler** unterstellt.

> Attribute:

* Adresse

### Lehrer

> Beschreibung:

Ein Lehrer ist eine **Person**.

> Attribute:

### Schüler

> Beschreibung:

Ein Schüler ist eine **Person**. Ein Schüler ist eine **Person**, die eine **Klasse** in einer **Schule** besucht.
Ein Schüler hat (priorisiert) **Person**en, die die **Fürsorge** inne tragen.

> Attribute:

* Liste von **Fürsorger**

### Fürsorge

> Beschreibung:

Die Fürsoge ist eine **Person**, die die fürsorgliche Verantwortung für einen **Schüler** inne trägt.
Diese **Person** kann ein Elternteil sein, oder eine Person, aus einer sozialen Einrichtung.

> Attribute:

### Note

> Beschreibung:

Eine Note ist eine Bewertung für einen **Schüler**.
Eine Note wird von einem **Lehrer** in einem bestimmten **Fach** vergeben. Zusäzlich kann dem **Schüler** **Kopfnote**n vergeben werden, die auch außerhalb des Faches liegen können.

> Attribute:

### Kopfnote

> Beschreibung:

Ein Kopfnote ist eine Bewertung auf ein sozialen Verhalten.
Diese sind können zum Beispiel folgendermaßen unterteilt werden:

* Ordnung
* Mitarbeit
* Fleiß
* Betragen

Diese können aber in den Einstellungen für eine **Schule** verändert werden.

> Attribute:

### Notenbuch

> Beschreibung:

Ein Notenbuch ist eine Sammlung von **Note**n für einen **Schüler** in einer **Schule**. Ein Notenbuch wird für jedes **Schuljahr** angelegt.

> Attribute:

### Schuljahr

> Beschreibung:

Ein Schuljahr ist ein definierter Zeitraum einer **Schule**.

> Attribute:

### Fach

> Beschreibung:

> Attribute:

### Hausaufgabe

> Beschreibung:

Eine Hausaufgabe ist eine Aufgabe für ein **Fach**. Ein **Lehrer** vergibt die Aufgaben an eine **Klasse** oder an einen oder mehrere **Schüler**.

### Stundenplan

> Beschreibung:

> Attribute:

### Vertretungsplan

> Beschreibung:

> Attribute:

### Berichte

> Beschreibung:

> Attribute:

### Zeugnis

> Beschreibung:

> Attribute:

### Termine

> Beschreibung:

> Attribute:

### Klasse

> Beschreibung:

Eine Klasse gehört zu einer **Schule**. Eine Klasse ist einem **Schuljahr** zugeordnet. Eine Klasse hat eine Liste von **Schüler**n. Es gibt eine priorisierte Liste von **Schüler**n, die den **Schülersprecher** repreäsentieren. Zu einer Klasse gehört immer ein **Lehrer**.

### Verwaltung (Angestellter)

> Beschreibung:

> Attribute:

### eBooks

> Beschreibung:

> Attribute:

### Lernmaterial

> Beschreibung:

> Attribute:

### Leistungskontrolle/Arbeiten

> Beschreibung:

> Attribute:

### Lernverbesserung (Achivement)

> Beschreibung:

> Attribute:

### Sitzplan

> Beschreibung:

> Attribute:

### Essensplan

> Beschreibung:

> Attribute:

### Schulordnung

> Beschreibung:

> Attribute:

### Fehlzeiten/Kranktage/Krankschreibung

> Beschreibung:

> Attribute:

### Dokumentenbibliothek

> Beschreibung:

> Attribute:

### Klassenbuch

> Beschreibung:

> Attribute:

### Gebäude/Raumverwaltung

> Beschreibung:

> Attribute:

### Ferien (je Bundesland)

> Beschreibung:

> Attribute:

## Technische Ideen

### UI

* HTML5
* CSS/LESS
* Javascript
* [Typescript](https://www.typescriptlang.org/index.html#download-links)
* [Bootstrapper](http://getbootstrap.com/getting-started/#download)
* [Electron](http://electron.atom.io/)
* .Net Core Web API

* Einsatz von Produkten:
  * [Slack](https://slack.com/) *(zur Kommunikation innerhalb von Klassen)*

### Datenbank

[MongoDB](https://www.mongodb.com/download-center#community)

### Plattformen

> Betriebssysteme

* Windows
* Mac OS
* Linux

> Architektur

* x86
* x64
* ARM

### Dokumente

* Anwenderhandbuch
* Architekturdokumentation
* Entwicklung
  * Branching
  * Codeing-Guideline
  * Roadmap
  * Issue-Vorgehen
  * Glossar
  * Entwicklungsrichtlinien
  * Build-Prozess
  * Code-Review