using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LumememmBasharov
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void on_Clicked(object sender, EventArgs e)
        {
            hed.Opacity = 1;
            bod1.Opacity = 1;
            bod2.Opacity = 1;
            lbl.Text = "Снеговик появился";
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            hed.Opacity = 0;
            bod1.Opacity = 0;
            bod2.Opacity = 0;
            lbl.Text = "Снеговик исчез";
        }
        Random rnd = new Random();
        private void rndd_Clicked(object sender, EventArgs e)
        {
            lbl.Text = "Случайный цвет";
            hed.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            bod1.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            bod2.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private async void Sul_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                hed.Opacity = 0.5;
                bod1.Opacity = 0.5;
                bod2.Opacity = 0.5;


                await Task.Run(() => Thread.Sleep(1000));

            }
        }
    }
}
