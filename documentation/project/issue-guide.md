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

## Vorlage für Hotfix-Issue:

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

## Vorlagen für das Schließen von Issues:

```
**Anforderung:** *Anforderungsbeschreibung*

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