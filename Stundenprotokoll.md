# Stundenprotokoll

## 1. Teil des Projekts (Zeit bis 04.04.23)

<details>
    <summary>Übersicht der Stunden vom 16.01. bis zum 14.02.</summary>
    <table align=center>
    <tr>
            <td>
                <a href="#1">1. Stunde, 16/01/2023</a>
            </td>
            <td>
                <a href="#2">2. Stunde, 19/01/2023</a>
            </td>
            <td>
                <a href="#3">3. Stunde, 13/02/2023</a>
            </td>
            <td>
                <a href="#4">4. Stunde, 14/02/2023</a>
            </td>
    </tr><br>
    </table>


## Unterrichtsstunde am Montag, den 16.01.2023 <a name="1"></a>

Heute haben wir uns in der ersten Stunde damit beschäftigt, welches neue Projekt wir im zweiten Halbjahr in Angriff nehmen wollen. 
Wir haben uns im vorhinein schon ein wenig abgesprochen und sind uns ziemlich einig, dass wir eine App programmieren wollen. Diese App soll im finalen Release eine sogenannte First Aid App sein, die einem Ersthelfer an z.B. einer Unfallstelle unterstützen soll. Wir müssen uns nur noch entscheiden, mit welcher Umgebung und welcher Programmiersprache wir dieses Projekt umsetzen werden.
Zuerst einmal werden wir uns mit Xamarin Forms und C# auseinander setzen. Dies ist eine Möglichkeit Cross Platform Apps zu erstellen.

## Unterrichtsstunde am Donnerstag, den 19.01.2023 <a name="2"></a>

Heute haben wir uns in den letzen Minuten, die uns nach den Vorstellungen der anderen Projekte aus dem ersten Halbjahr übrig blieben, mit der Einrichtung von Visual Studio mit Xamarin Forms auseinander gesetzt.

## Unterrichtsstunde am Montag, den 13.02.2023 <a name="3"></a>

Heute haben wir uns nochmal nach der längeren Pause über unser Projekt verständigt und waren uns einig, dass wir bei der Idee einer FirstAid-App bleiben werden. Danach haben wir uns weiter mit dem Kennenlernen von XamarinForms beschäftigt. Dabei ging es vor allem um das Erkunden, wo man das Design und später den Code dahinter programmieren kann. Morgen wird Louis in der Doppelstunde unsere Idee mit Herrn Buhl absprechen und dann am Nachmittag, bzw. für Louis auch schon anteilig am Vormittag, werden wir uns wieder zusammensetzen, um alle Ideen zu sammeln, was genau wir in der App implementieren wollen.

## Unterrichtsstunde am Dienstag, den 14.02.2023 <a name="4"></a>

Heute hat Louis unsere Idee in der Doppelstunde mit Herrn Buhl besprochen und dieser hat sein Go gegeben, sodass wir uns nun voll auf die Umsetzung dieses Projektes fokussieren werden. Weitergehend hat Louis schon mal Ideen gesammelt, und sich damit beschäftigt mit welcher Software man sich einen detaillierten Plan von der App machen kann.

</details>

<details>
<summary>Zeit vom 14.02. bis 04.04.</summary>

In dieser Zeit hat leider keine gemeinsame und auch keine regelmäßige Arbeit an dem Projekt stattgefunden.

Louis hat zwar anhand eines Tutorials einen Taschenrechner programmiert, um sich so erste Programmiertechniken von Xamarin Forms und C# anzueignen. Jan hat auch immer mal wieder im Internet Tutorials geguckt, um sich erstmal mit C# vertraut zu machen.
</details>    

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 2. Teil des Projekts ab dem 04.04.<br>

### Fachtag am 04.04.23

Heute haben wir uns nach längerer Zeit das erste Mal wieder zusammen an Informatik gesetzt. Zusammen mit Herrn Buhl haben wir nach Schilderung unserer Lage überlegt wie wir weiter fortfahren. Dabei war uns relativ schnell klar, dass wir gerne trotz der Unterbrechung an unser Idee festhalten wollen. Auch Herr Buhl hat dieser Idee zugestimmt. Darauf haben wir uns erstmal über unsere Kenntnisse ausgetauscht und haben ein neues Blanko-Projekt für unsere App erstellt. Wir haben dann erstmal entschieden, dass wir zunächst zwei Seiten für unsere App haben wollen. Zum einen eine Seite, die einem mit einem "Metronom" bei der Herz-Lungen-Wiederbelebung unterstützt und zum anderen eine mit der man den Notruf direkt wählen kann. 
Wir haben uns entschieden, dass Louis sich erstmal mit ersterem auseinandersetzt und Jan mit letzterem. 

Nun sind leider erstmal Ferien, in welchen wir uns weiter Grundlagen aneignen wollen, vor allem speziell auch für unsere Seite in der App. Um dann nach den Ferien wieder zusammen weiter zu arbeiten.

### Woche vom 01.05. bis 07.05.

In den Osterferien haben wir viel recherchiert und uns weitere Fähigkeiten im Umgang mit Xamarin und C# angeeignet. Louis ist dabei zum Beispiel auf die Schwierigkeit gestoßen, einen Ton in der App abzuspielen, und muss sich damit weiter auseinandersetzen. Dafür hat er schonmal das Design von der Seite geschaffen, nämlich einfach einen großen Button, der fast über den gesamten Bildschirm reicht. Generell haben wir uns nochmal darauf verständigt die App design technisch sehr simpel zu halten um die Bedienung zu erleichtern. Jan hat sich mit der 'PhoneDialer' Funktion beschäftigt, mit welcher automatisch eine Nummer gewählt werden kann. Dies hat er dann auch beispielhaft mit seiner eigenen Nummer ausprobeirt und in Form eines Buttons in die App eingepflegt.

<details>
<summary>Code-Ausschnitte</summary>
Code für das Design des Buttons auf der Reanimationsseite:

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
```

Code für den PhoneDialer:

```
PhoneDialer.Open("112");
```
</details>

### Woche vom 08.05. bis 14.05.

Diese Woche haben wir sehr viel geschafft, Louis hat das Problem mit Sound gelöst und hat es auch gleich geschafft den Sound in einem regelmäßigen Tempo abspielen zu lassen. Jedoch ist uns bei einem Langzeittest aufgefallen, dass der Sound irgendwann aufhört. Nach einer kurzen Recherche hat Jan herausgefunden, dass wohl ein Speichermedium der App voll war, sodass wir unseren Code um 3 Zeilen Code (s.u.) erweitern mussten. Damit haben wir die erste Seite unserer App vollendet.
Jan hat auf unser Notrufseite angefangen mehrere Buttons hinzuzufügen, jedoch haben wir schnell gemerkt, dass wir eine Liste erstellen müssen. Da wir gerne zumindest alle Notrufnummern der europäischen Länder in der App implementiert hätten. Wir haben uns entschieden uns gemeinsam diesem Problem am Fachtag nächste Woche zu widmen. Weitergehend hat Jan eine Startseite erstellt, von welcher man per Knopfklick jeweils zu den anderen Seiten kommt.

<details>
<summary>Die 3 Zeilen Code als Lösung</summary>
```
_mediaPlayer.Completion += delegate {
    _mediaPlayer.Reset();
};
```
</details>

### Fachtag am 17.05.23

Heute haben wir uns zunächst gemeinsam damit beschäftigt, wie man eine Liste erstellen könnte. Jedoch haben all unsere eigenen Ansätze nicht funktioniert, sodass wir uns wieder einmal an die Recherche setzen mussten. Dort sind wir nach etwas hin und her auf eine Methode gestoßen, die zwar etwas komplizierter schien, aber genau das erfüllt was wir uns vorstellten. Denn wir mussten für die Liste eine eigene Klasse erstellen. Nachdem wir die Liste dann erstellt hatten, fiel uns durch Zufall ein Problem bei der Reanimationsseite auf, denn wenn man das "metronom" anstellte, und dann auf die startseite zurückging, lief das Metronom weiter. Jedoch ließ sich auch das Problem relativ schnell beheben, indem wir noch eine zusätzliche Kontrolle einfügten, bevor das Metronom startet, nämlich auf welcher Seite man sich gerade befindet. 
In der nächsten Woche müssen wir die Liste noch beenden, denn wir haben noch nicht alle Elemente eingesetzt. Zudem wollen wir auch noch die Länderflaggen der einzelnen Ländern einfügen. Darüberhinaus haben wir uns abgesprochen noch eine dritte Seite nämlich einen Pulsrechner, der den Puls von 15 Sekunden auf eine Minute hochrechnet, in unsere App zu implementieren.

<details>
<summary>Code-Ausschnitte</summary>
Design von der Liste ohne Elemente:

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
                    </Grid>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```

Behebung des Metronom-Problems:
```
Page currentPage = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
if (currentPage is MainPage)
{
    return false;
}
```

</details>

### Woche vom 22.05. bis 28.05.

Zum Ende der Woche hin haben wir nun die Liste beendet. Das Einfügen der Bilder war etwas kompliziert, da wir die Bilder erstmal an der falschen Stelle gespeichert hatten, sodass die App anfangs nicht darauf zugreifen konnte. Zudem musste Jan die Bilder nochmal alle nachbearbeitet, da es keine passenden Bilder in der von uns benötigten Größe gab. Nachdem wir dann aber herausgefunden haben, dass man sie im 'drawable'-Ordner speichern muss, hat alles sehr gut funktioniert. Außerdem haben wir herausgefunden, dass man mit der Liste auch ganz leicht eine Searchbar einfügen kann, um schneller Items in der Liste zu finden. Diese haben wir dann auch direkt noch dazu implementiert. Außerdem haben wir mit dem Design der letzten und dritten Seite angefangen.

### Woche vom 29.05. bis 04.06.

In dieser Woche haben wir durch viele sich häufende gleichwertigen Leistungen und Präsentationen leider nicht so viel Zeit gefunden wie in den Wochen davor. Jedoch haben wir natürlich dennoch einiges geschafft. Somit haben wir unteranderem nochmal das Design der gesamten App etwas überarbeitet bzw. einfach die Farben etwas angepasst, sowie auch des Design der dritten Seite vervollständigt. Weitergehend haben wir auch schon mit dem Code für die letzte Seite angefangen.

### Woche vom 05.06. bis 11.06.

Heute haben wir die letzte Seite vollendet. Dabei ist uns direkt ein Fehler bzw. ein Problem aufgefallen, denn beim Zurücksetzen, währenddessen nichts im Eingabefeld stand, brach die App einfach ab. Dieses Problem konnten wir aber auch relativ schnell und unkompliziert lösen, indem wir diesen Sonderfall im Code implementierten. Außerdem haben wir diese Woche auch noch eine Icon für unsere App designt und dies auch in unsere App eingepflegt.

<details>
<summary>Lösung des Problems</summary>

```
if (input == "")
{
    lbl.Text = "";
    return;
}
```

</details>

### Fachtag am 15.06.23

An diesem letzten Fachtag haben wir uns voll und ganz auf die Vollendung der gesamten App fokussiert. Dafür haben wir unter anderem nochmal die letzten Kleinigkeiten bezüglich der Farben und Größen der jeweiligen Labels, Buttons, etc. überprüft und gegebenfalls angepasst. Auf der Reanimationsseite haben wir nach Empfehlung eines externen Beurteilers noch ein Infolabel hinzugefügt. Um dem Erst-Helfenden eine kleine Anweisung zu geben. Am Ende des Tages konnten wir zufrieden die Programmierung der App abschließen. Nun müssen wir nur noch die Projektseite gestalten und vervollständigen.

<details>
<summary>Code für das PopUp-Fenster</summary>

```
async void AlertBtn_Clicked(object sender, EventArgs e)
{
    await DisplayAlert("Definition", "HLW = Herz-Lungen-Wiederbelebung", "OK");
}
```

</details>

### Woche vom 19.06. bis 25.06.

In der letzten Woche haben wir uns voll und ganz auf die Projektseite fokussiert. Wir haben alle nötigen Texte und Erklärungen geschrieben, den Code durchkommentiert, Bilder von der App eingefügt und den Quellcode angehängt. Somit haben wir noch alles nötige vor der Abgabe erledigt.