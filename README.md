<h1 align=center>Erste Hilfe App - Projektseite</h1>

<div align=center>
    <img src='images/icon.png', height="250", border="5"></img>
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
                <a href="#xamarin">Xamarin Forms (Framework)</a>
            </li>
            <li>
                <a href="#c#">C# (Programmiersprache)</a>
            </li>
            <li>
                <a href="#visualstudio">VisualStudio 2022 (Programmierumgebung)</a>
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

Im ersten Abschnitt unserer Projektseite werden wir zuerst einmal unsere Gruppe, sowie unsere Projektidee erklären.

### 1. Die Gruppe <a name="gruppe"></a>

Unsere Gruppe besteht aus Jan Drewes und Louis Lemberg, wir gehen beide in das Physikprofil der 11. Klasse. Für uns war von Anfang an klar, dass wir wieder zusammenarbeiten wollen, da die Zusammenarbeit im ersten Halbjahr während des ersten Informatik.-Projekts schon sehr gut funktioniert hat. Dadurch dass wir letztes Halbjahr schon zusammengearbeitet, sind wir vom Kenntnisstand auch ungefähr auf einem Level.

### 2. Die Idee <a name="idee"></a>

Für uns beide war von Anfang an klar, dass wir nicht wie im letzten Jahr mit Python programmieren wollen, sondern uns eine neue Herausforderung suchen wollen. Dabei sind wir relativ schnell auf die Idee gestoßen, eine eigene App zu programmieren. Auch das Thema der App war uns durch Jans Leidenschaft durch die Arbeit bei der DLRG und beim Schulsanitätsdienst für das Rettungswesen klar, somit entschieden wir uns dazu eine Erste-Hilfe-App zu programmieren, die jedoch nur die wichtigsten Funktionen, wie eine Notrufseite mit den Nummern für den Rettungsdienst aus fast allen erupäischen Ländern, ein Metronom, dass bei der Herz-Lungen-Wiederbelebung unterstützt und eine Seite, die dir hilft den Puls zu berechnen, umfasst.

## Die verwendeten Programme <a name="programme"></a>

In diesem Abschnitt erklären wir die verwendeten Programme, sowie die verwendten Programmiersprachen und warum wir diese verwendet haben.

### 1. Xamarin Forms (Framework) <a name="xamarin"></a>

Als Framwork für unsere App haben wir uns für Xamarin Forms entschieden, das uns dies die Möglichkeit bot eine Cross-Plattform App zu programmieren. Xamarin Forms hat seine eigene Programmiersprache zum Designen der Bestandteile der App.

### 2. C# (Programmiersprache) <a name="c#"></a>

Für den Code der Funktionen in der App verwendet Xamarin Forms die Programmiersprache C#. Dies ist eine objektorientierte plattformunabhängige Programmiersprache, die universiell einsetzbar ist. Wir beide mussten uns diese Programmiersprache erstmal aneignen aber nach anfänglichen kleineren Schwierigkeiten beherrschten wir auch sicher die Grundlagen von C#.

### 3. Visual Studio 2022 (Programmierumgebung) <a name="visualstudio"></a>

Als Programmierumgebung haben wir uns mehr oder weniger freiwillig für Visual Studio 2022 entschieden. Wir waren an Visual Studio gebunden, da diese Programmierumgebung für Xamarin Forms empfohlen wird und auch sehr einfach zu bedienen ist. Aber auch ansonsten ist Visual Studio 2022 eine sehr übersichtliche IDE, die sich abseits von Visual Studio für zahlreiche umfangreiche und plattformübergreifende Anwendungen empfiehlt.

## Erste Hilfe App - Coderklärung <a name="firstaid"></a>

Im folgenden Abschnitt werden wir den Code unserer App erklären. Dafür wird jeweils in die vier Seiten, welche zu unser App gehören, unterschieden. Für jede Seite gibt es zum einen eine '.xaml'-Datei, in welcher wir die jeweilige Seite mit Code designen, und zum anderen gibt es die dazugehörige '.xaml.cs'-Datei, in welcher wir den ganzen Code geschrieben, der der Seite ihre jeweilige Funktion gibt.

### Startseite <a name="mainpage"></a>

Anfangen werde ich mich mit unserer Startseite, die gleichzeitig auch die "Schaltzentrale" für unsere App ist, und von welcher aus man auch zu allen anderen drei Seiten gelangt.

<details>
<summary>Design ('.xaml'-Datei)</summary>

Genau deshalb ist diese Seite auch sehr simpel gehalten, denn man soll ja im Notfall so schnell wie möglich zu der Funktion gelangen, die man gerade benötigt. Somit besteht die auch nur aus 3 Buttons.

Zu erst einmal haben wir aber die Leiste am oberen Bildschirmrand designt. Diese Leiste ist bereits standardmäßig vorhanden, da wir diese Seite als 'NavigationPage' festgelegt haben. Dazu aber später mehr.

```
<NavigationPage.TitleView>
    <Label Text="Startseite"
            FontSize="Large"
            FontAttributes="Bold"
            TextColor="#FFFFFF"
            HorizontalTextAlignment="Start"
            VerticalTextAlignment="Center"/>
</NavigationPage.TitleView>
```

Wir erzeugen zunächst einmal ein Label innerhalb dieser Leiste. Dann geben wir diesem Label ein Inhalt, einen Text, anschließend legen wir für diesen die Größe, die Eigenschaft (also in diesem Fall, dass die Schrift "fett" sein soll) und die Farbe. Danach sagen wir noch wo dieser Text stehen soll, also horizontal am Start (ganz links) des Labels und vertikal in der Mitte vom Label.

Für die 3 Buttons erzeugen wir nun erst einmal eine Tabelle, in welcher die Buttons dann angeordnet werden.

```
<Grid BackgroundColor="#052A2F"
        RowSpacing="30">
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="Auto"/>
        <RowDefinition Height="Auto"/>
    </Grid.RowDefinitions>
    <Grid.ColumnDefinitions>
        <ColumnDefinition/>
    </Grid.ColumnDefinitions>
</Grid>
```

Zu aller erst legen wir dafür die Hintergrundfarbe der Tabelle und die Größe der Reihen fest. Dann bestimmen wir viele Reihen und Spalten unsere Tabelle haben soll. In unserem Fall sind es 3 Reihen und 1 Spalte.

```
<Button Grid.Row="2"
        Grid.Column="0"
        Grid.ColumnSpan="2"
        Text="Puls"
        FontSize="Large"
        Padding="50"
        x:Name="BtnTest"
        Clicked="BtnTest_Clicked"
        HeightRequest="160"/>
```

Der Code für die 3 Buttons sieht jeweils so aus (beispielhaft am Code für den ersten Button). Als erstes sagen wir jeweils, wo in der Tabelle der Button platziert werden soll. Also in der wie vielten Reihe bzw. Spalte, wobei die Zählung jeweils immer bei "0" beginnt. Dann geben wir auch diesem Button wieder einen Text und eine dazugehörige Größe. Außerdem bekommt unser Button auch noch ein Padding von 50px. Daraufhin geben wir dem Button noch einen Namen mit welchem wir dann in anderen Dateien wieder auf diesen Button zugreifen können. Die darauf folgende Zeile erzeugt eine Funktion in der '.xaml.cs'-Datei, welche beim Klicken des Buttons aufgerufen wird. Zu guter letzt geben wir dem Button noch eine Höhe.
</details>

<details>
<summary>'.xaml.cs'-Datei</summary>
Zuerst werden wie bei allen Dateien auch hier erstmal alle Librarys importiert, welche wir für die jeweilige Datei benötigen. In diesem Fall sind das:

```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
```

Darauf folgt der eigentliche Code:

```
namespace Erste_Hilfe_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void BtnTest_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PulsRechner());
        }

        async void BtnCall_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NotrufPage());
        }

        async void BtnMetro_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MetronomPage());
        }

    }
}
```
Die Zeile 'InitializeComponent();' sorgt dafür, dass alles was wir vorher in der '.xaml'-Datei geschrieben haben, nun auch erzeugt wird. 

Die drei Funktionen danach sind die bereits schon angesprochen, welche nach dem Klicken des jeweiligen Buttons ausgeführt werden. In diesem Fall sorgt der Code innerhalb dieser Funktion einfach nur für das Weiterleiten zur nächsten Seite.

<details>
<summary>Exkurs 'NavigationPage'</summary>
Um dieses Weiterleiten überhaupt möglich zu machen, müssen wir unsere Startseite als 'NavigationPage' festlegen. Dafür mussten wir in die 'App.xaml.cs'-Datei gehen, welche einfach nur dafür sorgt, dass die App überhaupt gestartet wird, und folgende Zeile Code einfügen:

```
MainPage = new NavigationPage(new MainPage())
    {
        BarBackgroundColor = Color.FromHex("#D43B37"),
        BarTextColor = Color.FromHex("#FFFFFF")
    };
```

Nebenbei haben wir dann auch noch die Farbe und Text von der oben ansässigen Leiste festgelegt, über welche wir bereits schon geredet haben.
</details>
</details>


### Notrufseite <a name="notruf"></a>

Drückt man nun den Notruf-Button auf der Startseite der App landet man auf der Notrufseite. Hier sind mehrere Knöpfe innerhalb einer Liste zu sehen, die jeweils den Notruf für das aufgelistete Land auslösen. Bei den Ländern haben wir uns zunächst einmal auf alle europäischen Länder beschränkt.

<details>
<summary>Design ('.xaml'-Datei)</summary>
Auch auf dieser Seite designen wir zunächst einmal wieder die Leiste am oberen Bildschirmrand. Dabei gehen wir genauso vor wie bei der Startseite, außer dass wir den Text natürlich geändert haben.

Danach fügen wir unserer Seite direkt unter der Leiste eine Searchbar ein, mit welcher man dann auf alle Elemente innerhalb der Liste zugreifen kann.

```
<SearchBar Placeholder="Suche Land"
    x:Name="LandSearch"
    TextChanged="LandSearch_TextChanged"
    TextColor="White"
    PlaceholderColor="White"
    CancelButtonColor="White"/>
```

Erstmal geben wir der Searchbar einen Placeholder-Text, welcher angezeigt wird, wenn sich kein Text im Textfeld befindet. Dann legen wir wie bei den Buttons einen Namen fest, um später wieder auf die Liste zugreifen zu können. Um später die Suchfunktion zu ermöglichen, erzeugen wir eine Funktion, wenn sich der Text durch die Eingabe des Users geändert hat. Dann geben wir den Texten sowie dem Cancel-Button, welcher automatisch bei einer Searchbar vorhanden ist, die Farbe weiß.

Im nächsten Schritt erzeugen wir die Liste in welcher später die ganzen Länder und ihre Flaggen enthalten sind.

<details>
<summary>Kompletter Code für die Liste</summary>

```
<ListView x:Name="NotrufList"
            HasUnevenRows="True"
            ItemTapped="NotrufList_ItemTapped"
            VerticalOptions="FillAndExpand"
            HorizontalOptions="FillAndExpand"
            IsVisible="True">
    <ListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <Grid BackgroundColor="#052A2F"
                        RowSpacing="0"
                        ColumnSpacing="10"
                        Padding="10">
                        <Grid.RowDefinitions>
                            <RowDefinition Height="Auto"/>
                            <RowDefinition Height="Auto"/>
                        </Grid.RowDefinitions>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="Auto"/>
                            <ColumnDefinition Width="Auto"/>
                        </Grid.ColumnDefinitions>
                        <Image Grid.Row="0"
                                Grid.Column="0"
                                x:Name="FlagImage"
                                Source="{Binding Flag}"
                                WidthRequest="60"
                                HeightRequest="38"
                                BackgroundColor="#052A2F"/>
                        <Label Grid.Row="0"
                            Grid.Column="1"
                            Text="{Binding Land}"
                            FontSize="Large"
                            WidthRequest="270"
                            HeightRequest="38"
                            Padding="0"
                            HorizontalTextAlignment="Center"
                            VerticalTextAlignment="Center"
                            BackgroundColor="#5b5a5f"/>
                    </Grid>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```
</details>

Wichtig bei dem Code ist, dass wenn ein Item berührt worden ist (das ganze funktioniert wie bei einem Button), wieder eine Funktion erzeugt und dann aufgerufen wird. Zudem sei zu den zwei Elementen (Image und Label), die innerhalb einer Tabelle, zu einem Item zusammengefasst sind gesagt, dass der Inhalt dieser Elemente noch nicht festgelegt ist sondern gleich erst in der '.xaml.cs'-Datei definiert werden.

</details>

<details>
<summary>'.xaml.cs'-Datei</summary>
Auch bei dieser Seite werden natürlich zuerst einmal die ganzen Librarys importiert und das Grundgerüst für den Code geschaffen.

```
public List<Class_Template> tempdata;
public NotrufPage()
{
    InitializeComponent();


    tempdata = new List<Class_Template>
    {
        new Class_Template
        {
            Land = "Belgien",
            Flag = "Resources/drawable/belgien.png"
        },
    };

    NotrufList.ItemsSource = tempdata;
}
```

Dies ist der erste Teile vom Code, welcher automatisch beim Öffnen der Seite abgerufen wird. Um dies zu verstehen müssen wir jedoch erstmal wieder einen kleinen Exkurs machen.

<details>
<summary>Exkurs 'Class_Template'</summary>

Denn für das Erzeugen der Liste haben wir auf Grund der hohen Anzahl an Items eine Class erstellt, die uns das Leben vereinfacht beim Einfügen. Die Class sieht wie folgt aus:

```
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Erste_Hilfe_App.Classes
{
    public class Class_Template
    {
        public string Land { get; set; }
        public string Flag { get; set; }

    }
}
```

Sie sorgt dafür, dass wir nur zwei Dinge angeben müssen, nämlich zum einen wie unser Land heißt und zum anderen wo das Programm die Flagge des Landes findet. Mit diesen Informationen wird dann das Item innerhalb der Liste erstellt.

</details>

Damit lässt sich der Code nun leichter verstehen. Zunächst einmal erstellen wir eine 'public'-Variable tempdata, die unsere Liste mit Hilfe unserer Class enthält. Dann erzeugen wir wieder alle Elemente, welche wir in der '.xaml'-Datei definiert haben. Daraufhin erzeugen wir die ganzen Items für unsere Liste mit Hilfe unserer Class_Template. Beispielhaft für alle Items stehen hier nur die Zeilen für Belgien. Die letzte Zeile des Codes sorgt dafür, dass alle Items angezeigt werden sollen.

Nun folgt die Funktion, welche aufgerufen wird, wenn ein Item ausgewählt worden ist.

```
private void NotrufList_ItemTapped(object sender, ItemTappedEventArgs e)
{
    var Selected = e.Item as Class_Template;

    switch (Selected.Land)
    {
        case "Belgien":
            PhoneDialer.Open("112");
            break;
    }
}
```

Erst einmal wird das aufgerufene Item als Class_Template (dies wird gemacht, damit wir das Label und das Image getrennt voneinander angucken können) innerhalb einer Variable gespeichert. Dann folgt der eigentliche Code. Es wird anhand des Labels mit dem Ländernamen geguckt, welches Land aufgerufen wurde und dann wird mit Hilfe der internen Funktion von Xamarin Essentials 'PhoneDialer.Open("112");' direkt der Notruf gewählt. 

Hierbei sei erwähnt, dass der Anruf nicht direkt startet sondern sich erstmal nur die normale Telefonapp vom Gerät öffnet. Jedoch ist dann die Nummer bereits schon eingegeben. Dies haben wir so implementiert damit nicht gewollte Anrufe vermieden werden können.

Zu guter letzt folgt nun noch die Funktion der Searchbar, um die Suchfunktion zu ermöglichen.

```
private void LandSearch_TextChanged(object sender, TextChangedEventArgs e)
{
    string input = e.NewTextValue.ToString().ToLower();

    if (string.IsNullOrEmpty(input) )
    {
        NotrufList.ItemsSource = tempdata;
    }
    else
    {
        NotrufList.ItemsSource = tempdata.Where(x => x.Land.StartsWith(input[0].ToString().ToUpper() + input.Substring(1)));
    }
}
```

Dafür konvertieren wir den Input vom User erstmal zu einem String und zu nur Kleinbuchstaben. Dies machen wir damit wir später einfach und einheitlich die Suche gewährleisten können. Wenn der Input nun leer ist, dann sollen weiterhin alle Items der Liste angezeigt werden. Falls dies aber nicht der Fall ist, sollen nur die Items bzw. auch nur das einzige Item angezeigt werden, die zu dem Input passen. Die etwas kompliziert aussehende Zeile Code sorgt auch dafür, dass jeweils der erste Buchstabe aus dem Input groß geschrieben wird, somit können wir den Input überhaupt erst mit unseren Items abgleichen.

</details>

### Reanimationseite <a name="reanimation"></a>

Wählt man jedoch auf der Startseite den Reanimationsbutton landet man auf dieser Seite, welche quasi ein Metronom ist, um bei der Reanimation bzw. der Herz-Lungen-Wiederbelebung zu unterstützen.

<details>
<summary>Design ('.xaml'-Datei)</summary>
Auch auf dieser Seite designen wir zunächst wieder die Leiste am oberen Bildschirmrand. Ansonsten ist die Seite sehr simpel gehalten. Die Seite enthält nur zwei Elemente zum einen einen Info-Text, inform eines Buttons, um beim Klicken eine Erklärung zu ermöglichen, und zum anderen einen großen Button, welcher nach dem Klicken auch wieder eine Funktion erzeugt bzw. aufruft.

```
<Button Grid.Row="1"
        Grid.Column="0"
        WidthRequest="300"
        HeightRequest="450"
        Text="Start"
        FontSize="75"
        FontAttributes="Bold"
        TextColor="#FFFFFF"
        Margin="10"
        BackgroundColor="Green"
        x:Name="BtnMetro"
        Clicked="BtnMetro_Clicked"/>
<Button Grid.Row="0"
        Grid.Column="0"
        WidthRequest="300"
        HeightRequest="90"
        FontSize="19"
        TextTransform="None"
        BackgroundColor="#052A2F"
        x:Name="AlertBtn"
        Clicked="AlertBtn_Clicked"
        TextColor="#FFFFFF"
        Text="HLW nach angegebenen Rhythmus"/>
```
</details>

<details>
<summary>'.xaml.cs'-Datei</summary>
Zunächst einmal werden auch hier wieder die nötigen Librarys importiert und die Elemente aus der Designdatei erzeugt, darüber hinaus definieren wir einige Variablen, welche wir im weiteren Verlauf gebrauchen werden:

```
private int tempo_bpm = 110;
private double interval;
private int i = 0;
```

Beim Klicken das Buttons mit dem Info-Text wird ein PopUp-Fenster erzeugt, welches die Abkürzung HLW erklärt.

```
async void AlertBtn_Clicked(object sender, EventArgs e)
{
    await DisplayAlert("Definition", "HLW = Herz-Lungen-Wiederbelebung", "OK");
}
```

Es folgt nun die Erklärung für den Code, wenn der große Button auf dieser Seite geklickt wird.

<details>
<summary>Kompletter Code für die Funktion beim Klicken</summary>

```
void BtnMetro_Clicked(System.Object sender, System.EventArgs e)
{
    interval = 60000.0 / tempo_bpm;
    i++;
    if (i % 2 == 0)
    {
        BtnMetro.Text = "Start";
        BtnMetro.BackgroundColor = Color.Green;
    }
    else
    {
        BtnMetro.BackgroundColor = Color.Red;
        BtnMetro.Text = "STOP";

        Device.StartTimer(TimeSpan.FromMilliseconds(interval), () =>
        {
            DependencyService.Get<ISound>().playBeepSound();

            if (BtnMetro.Text == "Start")
            {
                return false;
            }
            Page currentPage = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
            if (currentPage is MainPage)
            {
                return false;
            }
            return true;
        });
    }
}
```
</details>

Zunächst einmal wird der Intervall festgelegt in welchem Abstand nachher unser Metronom den Ton abspielen soll. Denn dafür brauchen wir einen Wert in Millisekunden. Dann rechnen wir anschließend auf die Variable i einen Wert dazu, um dann zugucken ob nach der Modulo-Operation mit 2 der Wert von i gleich 0 ist. Wenn dies so ist soll, der Button grün bleiben und weiterhin "Start" sagen. Falls dies jedoch nicht der Fall ist, soll der Button rot werden und sich der Text zu "Stop" ändern. Außerdem soll das genannte Metronom starten.

```
Device.StartTimer(TimeSpan.FromMilliseconds(interval), () =>
{
    DependencyService.Get<ISound>().playBeepSound();

    if (BtnMetro.Text == "Start")
    {
        return false;
    }
    Page currentPage = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
    if (currentPage is MainPage)
    {
        return false;
    }
    return true;
});
```

Dafür starten wir einen Timer mit Intervall in Millisekunden, welchen wir bereits schon festgelegt haben. Dann soll immer der BeepSound abgespielt werden. Für diese 'playBeepSound'-Funktion verwenden wir den MediaPlayer von Android. Dieser Timer würde nun theoretisch endlos weiter laufen. Deshalb gucken wir zum einen, ob der Text des Buttons "Start" ist, und zum anderen, ob die aktuelle Seite die Startseite ist. In diesen Fällen soll der Timer dann stoppen.s

</details>

### Pulsseite <a name="puls"></a>

Zu guter letzt kann man nun nach Klicken des Puls-Button auf der Startseite auf unsere letzte Seite kommen, mit welcher man den ungefähren Puls ermittlen kann. Dafür muss der Erst-Helfende nur den Puls für 15 Sekunden messen und das Programm rechnet die Anzahl der Schläge dann auf eine Minute hoch.

<details>
<summary>Design ('.xaml'-Datei)</summary>
Auch bei der letzten Seite haben wir zunächst einmal wieder die Leiste angepasst und eine Tabelle erstellt, in welcher wir all unsere Elemente angeordnet haben.

Zum einen haben wir ein Label mit einem kleinen Info-Text. Dann folgt ein selbst erstellter Timer aus einer Anzeige und zwei Buttons für Start und Stop. Dann kommt noch ein Entry-Feld, bei welchem der User nur Zahlen eingeben kann (dafür mussten wir festlegen, dass nur das 'numeric'-Keyboard geöffnet werden soll.). Darunter liegt das Label, in welchem später das Ergebnis der Berechnung erscheint. Ganz unten auf der Seite folgt noch ein Button der alles zurücksetzt.

<details>
<summary>Kompletter Code des Designs</summary>

```
<NavigationPage.TitleView>
    <Label Text="Puls"
            FontSize="Large"
            FontAttributes="Bold"
            TextColor="#FFFFFF"
            HorizontalTextAlignment="Start"
            VerticalTextAlignment="Center"/>
</NavigationPage.TitleView>

<ContentPage.Content>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition/>
            <RowDefinition Height="Auto"/>
            <RowDefinition/>
            <RowDefinition/>
            <RowDefinition Height="Auto"/>
            <RowDefinition/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition/>
            <ColumnDefinition/>
        </Grid.ColumnDefinitions>

        <Label Text="Miss den Puls für 15 Sekunden!"
                FontSize="18"
                Grid.Row="0"
                TextColor="#FFFFFF"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                Grid.ColumnSpan="2"/>
        <Label x:Name="Timer"
                FontSize="24"
                HorizontalOptions="Center"
                VerticalOptions="Center"
                TextColor="#FFFFFF"
                Text="00:00:15"
                Grid.Row="1"
                Grid.ColumnSpan="2"
                HeightRequest="70"/>
        <Button Text="Start"
                x:Name="start"
                Grid.Row="2"
                Grid.Column="0"
                Clicked="start_Clicked"/>
        <Button Text="Stop"
                x:Name="stop"
                Grid.Row="2"
                Grid.Column="1"
                Clicked="stop_Clicked"/>
        <Entry Placeholder="Puls für 15sec"
                Text=""
                Grid.Row="3"
                x:Name="entry"
                Completed="entry_Completed"
                TextColor="#FFFFFF"
                Keyboard="Numeric"
                Grid.ColumnSpan="2"/>
        <Label Text=""
                HorizontalTextAlignment="Center"
                TextColor="#FFFFFF"
                Grid.Row="4"
                x:Name="lbl"
                Grid.ColumnSpan="2"
                FontSize="20"
                Padding="0,20,0,0"
                HeightRequest="90"/>
        <Button Text="Zurücksetzen"
                Grid.Row="5"
                Grid.ColumnSpan="2"
                Clicked="Button_Clicked"/>
    </Grid>
</ContentPage.Content>
```
</details>
</details>

<details>
<summary>'.xaml.cs'-Datei</summary>
Wie auch bei den anderen Seiten importieren wir hier auch zunächst die nötigen Librarys und erschaffen die Seite mit allen Elementen aus der '.xaml'-Datei. Weiterführend definieren wir wieder zwei Variablen:

```
private bool TimerRunning = false;
private int seconds = 15;
```

Für den Timer erstellen wir noch eine weitere Variable, die falls der Timer nicht läuft oder die Anzeige gleich 00:00:00 anzeigt falsch ist. Und wenn dies nicht der Fall ist, wird von der Sekunden-Variable immer ein Wert abgezogen, und der Wert wird immer dementsprechend angepasst angezeigt. 

```
private bool TimerTick()
{
    if (!TimerRunning | Timer.Text == "00:00:00")
        return false;

    seconds--;
    TimeSpan time = TimeSpan.FromSeconds(seconds);
    Timer.Text = time.ToString();

    return true;
}
```

Wenn nun der "Start"-Button geklickt wird, wird, sofern der Timer noch nicht läuft, der Timer gestartet und die Variable auf wahr gesetzt. 

```
void start_Clicked(System.Object sender, System.EventArgs e)
{
    if (!TimerRunning)
    {
        Device.StartTimer(TimeSpan.FromSeconds(1), TimerTick);
        TimerRunning = true;
    }
}
```

Beim Blicken des "Stop"-Button wird die 'TimerRunning'-Variable wieder auf False gesetzt, und die Sekunden-Variable, sowie die Anzeige auf ihren Startwert zurückgesetzt.

Wenn der User die Eingabe im Entry-Feld bestätigt, wird ebenfalls eine Funktion abgerufen. Diese speichert zunächst einmal den Inhalt von diesem Feld in einer Variable. Dann wird geguckt, ob der Input entweder leer ist oder ein Bindestrich enthält. In diesem Fall soll nichts ausgrechnet werden, denn dies würde nur zu einem unnötigen Absturz der App führen. Falls keiner dieser beiden Fälle nicht vorhanden ist, wird der Input in eine Zahl verwandelt und dann mit 4 multipliziert, um den Puls für eine Minute zu berechnen. Im Anschluss wird das Ergebnis dann noch in dem dafür vorgesehenen Feld angezeigt.

```
void entry_Completed(object sender, EventArgs e)
{
    var input = entry.Text;
    if (input == "" || input == "-")
    {
        lbl.Text = "";
        return;
    }
    else
    {
        int number1 = int.Parse(input);
        int number2 = Math.Abs(number1);
        int puls = number2 * 4;
        lbl.Text = "Der errechnete Puls beträgt: " + "\n" + puls.ToString() + " BPM";
    }
}
```
</details>

## Quellen <a name="sources"></a>

<ol>
    <li>
        <a href="https://www.python-engineer.com/posts/chatbot-pytorch/">https://www.python-engineer.com/posts/chatbot-pytorch/</a>
    </li>
</ol>

Alle Links wurden zuletzt erfolgreich am 26.06.2023 um 15.00 Uhr geöffnet.

## Eigenständigkeitserklärung <a name="eigen"></a>

Wir bestätigen hiermit, dass unser Ergebnis, ein von uns eigens erschaffenes Produkt ist, und wir uns bei der Umsetzung einzig durch die angegebenen Quellen geholfen haben.