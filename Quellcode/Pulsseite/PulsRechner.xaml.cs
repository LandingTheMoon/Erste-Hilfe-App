using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Erste_Hilfe_App
{
    public partial class PulsRechner : ContentPage
    {
        private bool TimerRunning = false;
        private int seconds = 15;

        public PulsRechner()
        {
            InitializeComponent();
        }

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

        void stop_Clicked(System.Object sender, System.EventArgs e)
        {
            TimerRunning = false;
            seconds = 15;
            Timer.Text = "00:00:15";
        }

        void start_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!TimerRunning)
            {
                Device.StartTimer(TimeSpan.FromSeconds(1), TimerTick);
                TimerRunning = true;
            }
        }

        private bool TimerTick()
        {
            if (!TimerRunning | Timer.Text == "00:00:00")
                return false;

            seconds--;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            Timer.Text = time.ToString();

            return true;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            TimerRunning = false;
            Timer.Text = "00:00:15";
            seconds = 15;
            entry.Text = "";
            lbl.Text = "";
        }
    }
}