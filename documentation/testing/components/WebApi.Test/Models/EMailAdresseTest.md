# Testfälle für Objekt **EMailAdresse**

Im folgendem Dokument werden die Testfälle für das Objekt **EMailAdresse** beschrieben.

## Testfall 1: **ValidEMailAdresse**

### 1.1 Beschreibung

Dieser Testfall testet die E-Mail-Adresse `test@test.de`auf ihre Gültigkeit.

### 1.2 Art

**Unit-Test** (Positiv-Test)

### 1.3 Implementierung

```csharp
EMailAdresse adresse = new EMailAdresse();
adresse.Adresse = "test@test.de";
Assert.True(adresse.IsValid);
```

## Testfall 2: **InvalidEMailAdresse**

### 2.1 Beschreibung

Dieser Testfall testet die E-Mail-Adresse `test-test.de` auf ihre Ungültigkeit.

### 2.2 Art

**Unit-Test** (Negativ-Test)

### 2.3 Implementierung

```csharp
EMailAdresse adresse = new EMailAdresse();
adresse.Adresse = "test-test.de";
Assert.False(adresse.IsValid);
```