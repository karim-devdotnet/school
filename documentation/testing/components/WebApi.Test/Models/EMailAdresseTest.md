# Testfälle für Objekt **EMailAdresse**

Im folgendem Dokument werden die Testfälle für das Objekt **EMailAdresse** beschrieben.

## Testfall 1: **GueltigeEMailAdressen**

### 1.1 Beschreibung

Dieser Testfall testet die E-Mail-Adresse auf ihre Gültigkeit.

#### 1.1.1 Testdaten

| E-Mail-Adresse |
| :--- |
| test@test.de |
| test-test@test.de |
| test@test-test.de |
| test-test@test-test.de |

### 1.2 Art

**Unit-Test** (Positiv-Test)

### 1.3 Implementierung

```csharp
[Theory, MemberData("GueltigeEMailAdressdaten")]
[Trait("Komponente", "EMailAdresse")]
[Trait("UnitTestArt", "Positiv-Test")]
public void GueltigeEMailAdressen(string emailadresse)
{
    EMailAdresse adresse = new EMailAdresse();
    adresse.Adresse = emailadresse;
    Assert.True(adresse.IstGueltig);
}
```

## Testfall 2: **UngueltigeEMailAdressen**

### 2.1 Beschreibung

Dieser Testfall testet die E-Mail-Adresse auf ihre Ungültigkeit.

#### 2.1.1 Testdaten

| E-Mail-Adresse |
| :--- |
| test@testde |
| test-test.de |
| test-testde |
| test@@testde |
| test@@test.de |
| testattest.de |

### 2.2 Art

**Unit-Test** (Negativ-Test)

### 2.3 Implementierung

```csharp
[Theory, MemberData("UngueltigeEMailAdressdaten")]
[Trait("Komponente", "EMailAdresse")]
[Trait("UnitTestArt", "Negativ-Test")]
public void UngueltigeEMailAdressen(string emailadresse)
{
    EMailAdresse adresse = new EMailAdresse();
    adresse.Adresse = emailadresse;
    Assert.False(adresse.IstGueltig);
}
```