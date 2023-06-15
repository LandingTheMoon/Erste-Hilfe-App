using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Erste_Hilfe_App;
using Xamarin.Forms;

namespace Erste_Hilfe_App
{
    public partial class MetronomPage : ContentPage
    {
        private int tempo_bpm = 110;
        private double interval;
        private int i = 0;
        public string v;

        public MetronomPage()
        {
            InitializeComponent();
        }

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

        async void AlertBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Definition", "HLW = Herz-Lungen-Wiederbelebung", "OK");
        }
    }
}