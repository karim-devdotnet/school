# Issue Guide

## Allgemein

Dieser Guide dient dazu, eine allgemeine Richtlinie zu schaffen, wie Issues oder Hotfixes mittels Vorlagen erstellt und geschlossen werden. Dokumentiert wird vor allem, welche Dokumente erstellt bzw. angepasst werden sollen. Desweiteren dokumentiert es, welche Testfälle vorgesehen sind.

## Symbole

Symbole kennzeichnen Aufgaben in einem Issue, die umzusetzen oder nicht benötigt werden. Erledigte Aufgaben werden mit einem &#10003; gekennzeichnet.

### Symbolbeschreibungen:

* Umzusetzen: `!`
* Erledigt: `&#10003;` (&#10003;)
* Nicht benötigt: `&#10007;` (&#10007;)

## Vorlage für Feature-Issue:

```
**Anforderung:** *Anforderungsbeschreibung*

**Betroffene Komponenten:**

* WebApi (symbol)
  * WebApi.Model (symbol)
  * WebApi.Test (symbol)
* WebClient (symbol)

**Dokumentationsanpassungen:**

* Beschreibungs-Dokumentationen
  * Architektur-Handbuch (symbol)
  * Online-Handbuch (symbol)
  * Kontenxt-Hilfe (symbol)
  * Sicherheits-Handbuch (symbol)
* Deployment-Handbuch (symbol)
* Build-Prozess (symbol)
* Testfall-Dokumentation (symbol)

**Testfälle:**

* *Komponente 1*
  * *Testfall 1* - *Testfallbeschreibung*
  * *Testfall 2* - *Testfallbeschreibung*
```

## Vorlage für Bug-Issue:

```
**Fehler:** *Fehlerbeschreibung*

**StackTrace *(wenn vorhanden):***

**Betroffene Komponenten:**

* WebApi (symbol)
  * WebApi.Model (symbol)
  * WebApi.Test (symbol)
* WebClient (symbol)

**Dokumentationsanpassungen:**

* Beschreibungs-Dokumentationen
  * Architektur-Handbuch (symbol)
  * Online-Handbuch (symbol)
  * Kontenxt-Hilfe (symbol)
  * Sicherheits-Handbuch (symbol)
* Deployment-Handbuch (symbol)
* Build-Prozess (symbol)
* Testfall-Dokumentation (symbol)

**Testfälle:**

* *Komponente 1*
  * *Testfall 1* - *Testfallbeschreibung*
  * *Testfall 2* - *Testfallbeschreibung*
```

## Vorlagen für das Schließen von Issues:

```
**Betroffene Komponenten:**

* WebApi (symbol)
  * WebApi.Model (symbol)
  * WebApi.Test (symbol)
* WebClient (symbol)

**Dokumentationsanpassungen:**

* Beschreibungs-Dokumentationen angepasst
  * Architektur-Handbuch (symbol)
  * Online-Handbuch (symbol)
  * Kontenxt-Hilfe (symbol)
  * Sicherheits-Handbuch (symbol)
* Deployment-Handbuch (symbol)
* Build-Prozess (symbol)
* Testfall-Dokumentation (symbol)

**Testfälle erstellt:**

* *Komponente 1*
  * *Testfall 1* - *Testfallbeschreibung*
  * *Testfall 2* - *Testfallbeschreibung*
```

## Labels

Im folgendem Abschnitt werden die Labels und deren Einsatzweise beschrieben:

* `documentation` - Der Issue ist Hauptsächlich für Dokumentations-Arbeiten
* `environment` - Der Issue ist hauptsächlich für Umgebungsarbeiten wie z.B. Build-Management
* `feature` - Der Issue ist ein neues Feature. Hierzu muss das Vorlage *Vorlage für Feature-Issue* benutzt werden
* `bug`- Der Issue bezeichnet einen Fehler in der Software. Hierzu muss die Vorlage *Vorlage für Bug-Issue* verwendet werden. Unterteilt wird der Bug noch bei seinem Auftreten:
  * `bug-dev` - Dies ist ein Fehler, der in der Entwicklung aufgetreten ist
  * `bug-prod` - Dies ist ein Fehler, der in der Produktionsumgebung aufgetreten ist
* `ui` - Der Issue behandelt mit seiner Anforderung eine Anpassung an der Oberfläche
* `webservice`- Der Issue behandelt mit seiner Anforderung eine Anpassung an dem Web-Service

## Vorlage für die Erstellung von Pull Requests

### Titel
```
Pull Request-Anforderung für {Branch-Name} - Issue: #{issueid}
```

### Beschreibung

```
Pull Request-Anforderung für **{Branch-Name}**

Zugehöriger Issue: **#{issueid}**
```