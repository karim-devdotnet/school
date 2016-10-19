# Testfälle für Objekt **Adresse**

Im folgendem Dokument werden die Testfälle für das Objekt **Adresse** beschrieben.

## Testfall 1: **AdresseSpeichern**

### 1.1 Beschreibung

Dieser Testfall testet die E-Mail-Adresse auf ihre Gültigkeit.

#### 1.1.1 Testdaten

| E-Mail-Adresse |
| :--- |
| test@test.de |

### 1.2 Art

**Unit-Test** (Positiv-Test)

### 1.3 Implementierung

```csharp
[Theory, MemberData(nameof(GueltigeAdresseDaten))]
[Trait("Komponente", "Adresse")]
[Trait("UnitTestArt", "Positiv-Test")]
public void AdresseSpeichern(Adresse adresse)
{
    try
    {
        BsonDocument allFilter = new BsonDocument();
        SchoolContext.Instance().GetCollection<Adresse>().DeleteMany(allFilter);

        SchoolContext.Instance().SaveItem<Adresse>(adresse);
        Assert.True(true);
    }
    catch(Exception)
    {
        Assert.False(false);
    }
}
```