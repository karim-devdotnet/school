# Testfall-Dokumentation

Dieses Dokument ist das Einstiegs-Dokument für die Testfälle.

## Prinzip

Es wird das Prinzip **Test First** angewandt. Das heißt, es wird erst die Anforderung im [Issue](../project/issue-guide.md) und im Beschreibungs-Dokument festgehalten, dann die Testfälle beschrieben und erstellt und dann die eigentliche Implementierung durchgeführt.

## Implementierung

### Test-Framework

Verwendet wird das Test-Framework [xunit](https://xunit.github.io/).

Dies wird der NuGet installiert:

> PM> Install-Package xunit -Version 2.2.0-beta2-build3300 -Pre

> PM> Install-Package dotnet-test-xunit -Pre

In der Datei `project.json` wird folgende Einstellung verwendet, damit `xunit` als **testrunner** verwendet wird:

```json
{
    "testRunner": "xunit"
}
```

### Hilfsklassen

#### TestFixture

Die Klasse `TestFixture` wird verwendet, um für Testklassen eine Datenbank-Verbindung aufzubauen, eine Test-Datenbank anzulegen und diese am Ende der Tests wieder zu löschen.

##### Verwendung

```csharp
public class TestClass : IClassFixture<TestFixture>
{
    // TestCode
}
```

##### Test-Methode

Um eine Test-Methode zu deklarieren, muss das Attribut `Fact` an eine **öffentlich** Methode geschrieben werden.

**Beispiel:**

```csharp
public class EMailAdresseTest : IClassFixture<DatabaseTestFixture>
{
    /// <summary>
    /// Testen der E-Mail-Adresse auf ihre Gültigkeit
    /// </summary>
    [Fact]
    public void ValidEMailAdresse()
    {
        EMailAdresse adresse = new EMailAdresse();
        adresse.Adresse = "test@test.de";
        Assert.True(adresse.IsValid);
    }
}
```

## Testfall-Dokumente

Komponenten:

* [WebApi.Test](#webapitest)

### WebApi.Test

#### Models

* [Adresse](./components/WebApi.Test/Models/AdresseTest.md)
* [EMailAdresse](./components/WebApi.Test/Models/EMailAdresseTest.md)