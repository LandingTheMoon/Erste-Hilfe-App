using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Erste_Hilfe_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();                                                          //Diese Zeile erstellt die Seite
        }

        async void BtnTest_Clicked(System.Object sender, System.EventArgs e)                //Dies wird aktiviert wenn der entsprechende Knopf gedrückt wird
        {
            await Navigation.PushAsync(new PulsRechner());                                  //Hiermit wird die neue Seite der App aufgerufen
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
