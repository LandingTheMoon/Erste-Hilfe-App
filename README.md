# Erste Hilfe App 

<div align=center>
    <img src='images/icon.png', height="200", border="5"></img>
</div>

<h3 align=center>von Jan Drewes (@LandingTheMoon) & 
Louis Lemberg (@MindOfUs)</h3>

## Übersicht

<ol>
    <li>
        <a href="#einfuehrung">Einführung</a>
        <ol>
            <li>
                <a href="#gruppe">Die Gruppe</a>
            </li>
            <li>
                <a href="#idee">Die Idee</a>
            </li>
        </ol>
    </li>
    <li>
        <a href="#programme">Die verwendeten Programme</a>
        <ol>
            <li>
                <a href="#visualstudio">VisualStudio 2022 (Programmierumgebung)</a>
            </li>
            <li>
                <a href="#xamarin">Xamarin Forms (Framework)</a>
            </li>
            <li>
                <a href="#c#">C# (Programmiersprache)</a>
            </li>
        </ol>
    </li>
    <li>
        <a href="#firstaid">Erste Hilfe App - Coderklärung</a>
        <ol>
            <li>
                <a href="#mainpage">Startseite</a>
            </li>
            <li>
                <a href="#notruf">Notrufseite</a>
            </li>
            <li>
                <a href="#reanimation">Reanimationsseite</a>
            </li>
            <li>
                <a href="#puls">Pulsseite</a>
            </li>
        </ol>
    </li>
    <li>
        <a href="Design von der App.md">Design von der App und vom Code</a>
    </li>
    <li>
        <a href="Stundenprotokoll.md">Stundenprotokoll</a>
    </li>
    <li>
        <a href="#sources">Quellen</a>
    </li>
    <li>
        <a href="#eigen">Eigenständigkeitserklärung</a>
    </li>
</ol>

## Einführung <a name="einfuehrung"></a>

### 1. Die Gruppe <a name="gruppe"></a>

### 2. Die Idee <a name="idee"></a>

## Die verwendeten Programme <a name="programme"></a>

In diesem Abschnitt erklären wir die verwendeten Programme, sowie die verwendten Programmiersprachen und warum wir diese verwendet haben.

### 1. Visual Studio 2022 (Programmierumgebung) <a name="visualstudio"></a>

### 2. Xamarin Forms (Framework) <a name="xamarin"></a>

### 3. C# (Programmiersprache) <a name="c#"></a>

## Erste Hilfe App - Coderklärung <a name="firstaid"></a>

### Startseite <a name="mainpage"></a>

### Notrufseite <a name="notruf"></a>

Drückt man nun den Notruf-Knopf auf der Startseite der App landet man auf der Notrufseite. Hier sind mehrere Knöpfe zusehen die jewals den Notruf führ das auf den knopf stehende Land auslösen. Man muss hierzu erwähnen das der anruf nicht dirket gestartet wird sondern sich nur Wählapp vom Gerät öffnet. Dies haben wir so implementiert damit ein nicht gewohlter Anruf vermieden wird. Um die Telefonnummer nun mit der Wählerapp zu öffnen wird die "PhoneDialer" Class von Xamarin Essentials benutzt. Mit hilfe von einer zwei zusatz Zeilen Code in der AndroidManifest.xml, damit "PhoneDialer" auch mit neueren Versionen von Android funktioniert, reicht es letzendlich bei einem Knopf druck in der C# Datei die Zeile einzufügen:

```
PhoneDialer.Open("Die Telefonnummer die geöffnet werden soll");
```

### Reanimationseite <a name="reanimation"></a>

### Pulsseite <a name="puls"></a>

## Quellen <a name="sources"></a>

<ol>
    <li>
        <a href="https://www.python-engineer.com/posts/chatbot-pytorch/">https://www.python-engineer.com/posts/chatbot-pytorch/</a>
    </li>
</ol>

Alle Links wurden zuletzt erfolgreich am II.06.2023 um II.II Uhr geöffnet.

## Eigenstädnigkeitserklärung <a name="eigen"></a>

Wir bestätigen hiermit, dass unser Ergebnis, ein von uns eigens erschaffenes Produkt ist, und wir uns bei der Umsetzung einzig durch die angegebenen Quellen geholfen haben.