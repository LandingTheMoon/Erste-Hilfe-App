using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Erste_Hilfe_App;
using Xamarin.Forms;

//Algemeine Sachen sind in MainPage.xaml.cs commentiert

namespace Erste_Hilfe_App
{
    public partial class MetronomPage : ContentPage
    {
        private int tempo_bpm = 110;
        private double interval;                                                                //Hier werden ein paar Variabeln erstellt
        private int i = 0;
        public string v;

        public MetronomPage()
        {
            InitializeComponent();
        }

        void BtnMetro_Clicked(System.Object sender, System.EventArgs e)                         //Das hier ist die Funktion vom Metronom
        {
            interval = 60000.0 / tempo_bpm;                                                     //Hier wird das Intervall zwischen den Tönen anhand des vorher definierten Tempos bestimmt
            i++;
            if (i % 2 == 0)                                                                     //Diese When funktion schaut ob der Rest von "i/2" gelich null ist, um zu bestimmen ob i gerade oder ungerade ist
            {                                                                                   //Die Information über gerade und ungerade benutzten wir um zu schauen ob der Knopf nochmal gedrückt wurde
                BtnMetro.Text = "Start";
                BtnMetro.BackgroundColor = Color.Green;
            }
            else
            {
                BtnMetro.BackgroundColor = Color.Red;
                BtnMetro.Text = "STOP";


                Device.StartTimer(TimeSpan.FromMilliseconds(interval), () =>                    //Hier mit wird der Timer anhand des Intervals gestarted
                {
                    DependencyService.Get<ISound>().playBeepSound();                            //Die Zeile spielt den Ton ab über die Zeile in ISound.cs

                    if (BtnMetro.Text == "Start")                                               //Hier wird geschaut ob der Knopf nochmal gedrückt würde mit den Folgen vom gerade oder ungerade
                    {
                        return false;                                                           //Diese Zeile stopt den Timer
                    }
                    Page currentPage = Application.Current.MainPage.Navigation.NavigationStack.LastOrDefault();         //Hier wird eine Variable festgelegt mit der aktuellen Seite, die offen ist
                    if (currentPage is MainPage)                                                //Hier wird geschaut ob die aktuelle Seite die Hauptseite ist
                    {
                        return false;
                    }
                    return true;
                });

            }


        }

        async void AlertBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Definition", "HLW = Herz-Lungen-Wiederbelebung", "OK");         //Hier mit wird ein Pop-Up-Fenster aufgerufen beim drücken des Knopfes
        }
    }
}