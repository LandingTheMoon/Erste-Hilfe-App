using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;
using System.Threading.Tasks;

//Algemeine Sachen sind in MainPage.xaml.cs commentiert

namespace Erste_Hilfe_App
{
    public partial class PulsRechner : ContentPage
    {
        private bool TimerRunning = false;                                      //Hier werden wieder ein paar Variabeln festgelegt für den Timer
        private int seconds = 15;

        public PulsRechner()
        {
            InitializeComponent();
        }

        void entry_Completed(object sender, EventArgs e)                        //Dieser Berech für ausgeführt wenn der Nutzer die Eingabe im Eingabefeld bestätigen
        {
            var input = entry.Text;                                             //Hiermit wird der Inhalt vom Eingabefeld gespeichert
            if (input == "" || input == "-")                                    //Hier würd geschaut ob die eingabe leer oder nur aus einem Minus besteht
            {
                lbl.Text = "";                                                  //Fals die Eingabe leer oder aus einem Minus besteht so wird das Feld zurückgestzt und dervorgang abgebrochen
                return;
            }
            else
            {
                int number1 = int.Parse(input);                                 //Die Eingabe wird mit dieser Ziele von einem String in einen Integer konvertiert damit damit gerechnet werden kann
                int number2 = Math.Abs(number1);                                //Mit dieser Zeile wird der Betrag von der Zahl genommen
                int puls = number2 * 4;                                         //Hier wird die Zahl mal 4 genommen
                lbl.Text = "Der errechnete Puls beträgt: " + "\n" + puls.ToString() + " BPM";           //Hier wird die errechnete Zahl dann angezeigt als String
            }
        }

        void stop_Clicked(System.Object sender, System.EventArgs e)             //Hier wird die Anzeige vom Timer die Sekundenanzahl zurückgestetzt, so wie gesagt das der timer nicht mehr läuft
        {
            TimerRunning = false;
            seconds = 15;
            Timer.Text = "00:00:15";
        }

        void start_Clicked(System.Object sender, System.EventArgs e)            //Mit drücken des Knopfes wird dann der Timer gestarted
        {
            if (!TimerRunning)                                                  //Hier wird geschaut ob der Timer schon läuft
            {
                Device.StartTimer(TimeSpan.FromSeconds(1), TimerTick);          //Hier wird der Timer mit "TimerTick" angefangen
                TimerRunning = true;                                            //Hier wird gesetzt das der Timer läuft
            }
        }

        private bool TimerTick()
        {
            if (!TimerRunning | Timer.Text == "00:00:00")                       //Hier wird geschaut ob der Timer schon fertig ist, worauf hin nicht weiter gemacht wird
                return false;

            seconds--;                                                          //Hiermit werden die Sekunden verringert
            TimeSpan time = TimeSpan.FromSeconds(seconds);                      //Diese Zeile setzt die Zeitspanne vom Timer
            Timer.Text = time.ToString();                                       //Diese Zeile zeigt die Zeit auf der Seite an

            return true;                                                        //Hier wird dafür gesort das es wieter geht
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)           //Bei drüken des Knopfes werden alle Sachen die zurückgesetzt werden können zurückgesetzt
        {
            TimerRunning = false;
            Timer.Text = "00:00:15";
            seconds = 15;
            entry.Text = "";
            lbl.Text = "";
        }
    }
}