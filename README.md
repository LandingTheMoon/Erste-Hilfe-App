# Informatik-Projekt-2

## Verwendete Programme

In diesem Abschnitt erklären wir die verwendeten Programme, sowie die verwendten Programmiersprachen und warum wir diese verwendet haben.

### 1. Die Sprachen

### 2. Xamarin Forms

### 3. Visual Studio 2022

## Coderklärung

### Startseite

### Notrufseite

Drückt man nun den Notruf-Knopf auf der Startseite der App landet man auf der Notrufseite. Hier sind mehrere Knöpfe zusehen die jewals den Notruf führ das auf den knopf stehende Land auslösen. Man muss hierzu erwähnen das der anruf nicht dirket gestartet wird sondern sich nur Wählapp vom Gerät öffnet. Dies haben wir so implementiert damit ein nicht gewohlter Anruf vermieden wird. Um die Telefonnummer nun mit der Wählerapp zu öffnen wird die "PhoneDialer" Class von Xamarin Essentials benutzt. Mit hilfe von einer zwei zusatz Zeilen Code in der AndroidManifest.xml, damit "PhoneDialer" auch mit neueren Versionen von Android funktioniert, reicht es letzendlich bei einem Knopf druck in der C# Datei die Zeile einzufügen:

```
PhoneDialer.Open("Die Telefonnummer die geöffnet werden soll");
```

### Reanimationseite