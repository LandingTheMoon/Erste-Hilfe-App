using Erste_Hilfe_App.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

//Algemeine Sachen sind in MainPage.xaml.cs commentiert

namespace Erste_Hilfe_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotrufPage : ContentPage
	{
        public List<Class_Template> tempdata;
		public NotrufPage()
		{
            InitializeComponent();


            tempdata = new List<Class_Template>                             //Hier wird eine List erstellt mit dem "Class_Template.cs"
            {
                new Class_Template                                          //Alle Einträge der List sind nach Class_Template.cs aufgebaut
                {
                    Land = "Belgien",                                       //Erst wird das Land definiert
                    Flag = "Resources/drawable/belgien.png"                 //Dann wird der Dateipfad für die Flagge definiert
                },
                new Class_Template
                {
                    Land = "Bulgarien",
                    Flag = "Resources/drawable/bulgarien.png"
                },
                new Class_Template
                {
                    Land = "Deutschland",
                    Flag = "Resources/drawable/deutschland.png"
                },
                new Class_Template
                {
                    Land = "Dänemark",
                    Flag = "Resources/drawable/daenemark.png"
                },
                new Class_Template
                {
                    Land = "Estland",
                    Flag = "Resources/drawable/estland.png"
                },
                new Class_Template
                {
                    Land = "Finnland",
                    Flag = "Resources/drawable/finnland.png"
                },
                new Class_Template
                {
                    Land = "Frankreich",
                    Flag = "Resources/drawable/frankreich.png"
                },
                new Class_Template
                {
                    Land = "Griechenland",
                    Flag = "Resources/drawable/griechenland.png"
                },
                new Class_Template
                {
                    Land = "Großbritannien",
                    Flag = "Resources/drawable/grossbritannien.png"
                },
                new Class_Template
                {
                    Land = "Irland",
                    Flag = "Resources/drawable/irland.png"
                },
                new Class_Template
                {
                    Land = "Italien",
                    Flag = "Resources/drawable/italien.png"
                },
                new Class_Template
                {
                    Land = "Kroatien",
                    Flag = "Resources/drawable/kroatien.png"
                },
                new Class_Template
                {
                    Land = "Lettland",
                    Flag = "Resources/drawable/lettland.png"
                },
                new Class_Template
                {
                    Land = "Liechtenstein",
                    Flag = "Resources/drawable/liechtenstein.png"
                },
                new Class_Template
                {
                    Land = "Litauen",
                    Flag = "Resources/drawable/litauen.png"
                },
                new Class_Template
                {
                    Land = "Luxemburg",
                    Flag = "Resources/drawable/luxemburg.png"
                },
                new Class_Template
                {
                    Land = "Malta",
                    Flag = "Resources/drawable/malta.png"
                },
                new Class_Template
                {
                    Land = "Mazedonien",
                    Flag = "Resources/drawable/mazedonien.png"
                },
                new Class_Template
                {
                    Land = "Montenegro",
                    Flag = "Resources/drawable/montenegro.png"
                },
                new Class_Template
                {
                    Land = "Niederlande",
                    Flag = "Resources/drawable/niederlande.png"
                },
                new Class_Template
                {
                    Land = "Norwegen",
                    Flag = "Resources/drawable/norwegen.png"
                },
                new Class_Template
                {
                    Land = "Österreich",
                    Flag = "Resources/drawable/oesterreich.png"
                },
                new Class_Template
                {
                    Land = "Polen",
                    Flag = "Resources/drawable/polen.png"
                },
                new Class_Template
                {
                    Land = "Portugal",
                    Flag = "Resources/drawable/portugal.png"
                },
                new Class_Template
                {
                    Land = "Rumänien",
                    Flag = "Resources/drawable/rumaenien.png"
                },
                new Class_Template
                {
                    Land = "Russland",
                    Flag = "Resources/drawable/russland.png"
                },
                new Class_Template
                {
                    Land = "Schweden",
                    Flag = "Resources/drawable/schweden.png"
                },
                new Class_Template
                {
                    Land = "Schweiz",
                    Flag = "Resources/drawable/schweiz.png"
                },
                new Class_Template
                {
                    Land = "Serbien",
                    Flag = "Resources/drawable/serbien.png"
                },
                new Class_Template
                {
                    Land = "Slowakische Republik",
                    Flag = "Resources/drawable/slowakei.png"
                },
                new Class_Template
                {
                    Land = "Slowenien",
                    Flag = "Resources/drawable/slowenien.png"
                },
                new Class_Template
                {
                    Land = "Spanien",
                    Flag = "Resources/drawable/spanien.png"
                },
                new Class_Template
                {
                    Land = "Tschechien",
                    Flag = "Resources/drawable/tschechien.png"
                },
                new Class_Template
                {
                    Land = "Türkei",
                    Flag = "Resources/drawable/tuerkei.png"
                },
                new Class_Template
                {
                    Land = "Ungarn",
                    Flag = "Resources/drawable/ungarn.png"
                },
                new Class_Template
                {
                    Land = "Zypern",
                    Flag = "Resources/drawable/zypern.png"
                },
            };

            NotrufList.ItemsSource = tempdata;                                  //Hier wird dann noch mal die erstellte Liste als Quelle für die angezeigte Liste gesetzt
        }

        private void NotrufList_ItemTapped(object sender, ItemTappedEventArgs e)            //Diese Aktion wird ausgeführt wenn auf ein Element der Liste gedrückt wird egal ob Landname oder Flagge
        {
            var Selected = e.Item as Class_Template;                            //Diese Variable wird so definiert, dass sie in der tempdata Liste das Land lesen kann welches gedrückt wurde 

            switch (Selected.Land)                                              //Hier wird dann unterschieden was bei den einzelnen Ländern passiert
            {
                case "Belgien":                                                 //When das Land was gedrückt wurde dem Land im "case" übereinstimmt dann wird die Aktion aus diesem "case" ausgefürht
                    PhoneDialer.Open("112");                                    //Diese Zeile öffent die Telefonnummereingabeapp mit der angegeben Nummer schon eingegeben
                    break;                                                      //Diese Zeile bricht dann das vorgehen ab damit das Program weiß das es fertig ist
                case "Bulgarien":
                    PhoneDialer.Open("112");
                    break;
                case "Deutschland":
                    PhoneDialer.Open("112");
                    break;
                case "Dänemark":
                    PhoneDialer.Open("112");
                    break;
                case "Estland":
                    PhoneDialer.Open("112");
                    break;
                case "Finnland":
                    PhoneDialer.Open("112");
                    break;
                case "Frankreich":
                    PhoneDialer.Open("112");
                    break;
                case "Griechenland":
                    PhoneDialer.Open("112");
                    break;
                case "Großbritannien":
                    PhoneDialer.Open("112");
                    break;
                case "Irland":
                    PhoneDialer.Open("112");
                    break;
                case "Italien":
                    PhoneDialer.Open("118");
                    break;
                case "Kroatien":
                    PhoneDialer.Open("112");
                    break;
                case "Lettland":
                    PhoneDialer.Open("112");
                    break;
                case "Liechtenstein":
                    PhoneDialer.Open("144");
                    break;
                case "Litauen":
                    PhoneDialer.Open("112");
                    break;
                case "Luxemburg":
                    PhoneDialer.Open("112");
                    break;
                case "Malta":
                    PhoneDialer.Open("112");
                    break;
                case "Mazedonien":
                    PhoneDialer.Open("194");
                    break;
                case "Montenegro":
                    PhoneDialer.Open("94");
                    break;
                case "Niederlande":
                    PhoneDialer.Open("112");
                    break;
                case "Norwegen":
                    PhoneDialer.Open("113");
                    break;
                case "Österreich":
                    PhoneDialer.Open("112");
                    break;
                case "Polen":
                    PhoneDialer.Open("112");
                    break;
                case "Portugal":
                    PhoneDialer.Open("112");
                    break;
                case "Rumänien":
                    PhoneDialer.Open("112");
                    break;
                case "Russland":
                    PhoneDialer.Open("03");
                    break;
                case "Schweden":
                    PhoneDialer.Open("112");
                    break;
                case "Schweiz":
                    PhoneDialer.Open("144");
                    break;
                case "Serbien":
                    PhoneDialer.Open("94");
                    break;
                case "Slowakische Republik":
                    PhoneDialer.Open("112");
                    break;
                case "Slowenien":
                    PhoneDialer.Open("112");
                    break;
                case "Spanien":
                    PhoneDialer.Open("061");
                    break;
                case "Tschechien":
                    PhoneDialer.Open("112");
                    break;
                case "Türkei":
                    PhoneDialer.Open("112");
                    break;
                case "Ungarn":
                    PhoneDialer.Open("112");
                    break;
                case "Zypern":
                    PhoneDialer.Open("112");
                    break;
            }
            ((ListView)sender).SelectedItem = null;                                 //Hier wird die gedrückte Zeile aus der List wieder zurück zu nichts gesetzt
        }

        private void LandSearch_TextChanged(object sender, TextChangedEventArgs e)      //Dieser Bereich wird durch die Suchleiste aktiviert und beinhaltet die Suchfunktion
        {
            string input = e.NewTextValue.ToString().ToLower();                     //Hiermit wird der eingegebene Inhalt aus dem Suchfeld gespeichert und alles wird zu klein Buchstaben verwandelt

            if (string.IsNullOrEmpty(input) )                                       //Hier wird geschaut ob der eingebebene Inhalt leer ist, was dazufürht, dass die ganze Liste angeziegt wird
            {
                NotrufList.ItemsSource = tempdata;
            }
            else
            {
                NotrufList.ItemsSource = tempdata.Where(x => x.Land.StartsWith(input[0].ToString().ToUpper() + input.Substring(1)));            //Diese Ziele sorgt dafür, dass nur die Länder in der Liste angezeigt werden die mit der Sucheingabe übereinstimmen
            }
        }
    }
}