using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabVoiture : ContentPage
    {
        public TabVoiture()
        {
            InitializeComponent();
            voitureImage.Opacity = 0;
            voitureImage.Scale = 0.5;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            voitureImage.TranslationX = -600;
            voitureImage.Opacity = 0;
            voitureImage.FadeTo(1, 600);
            anim();
        }

        private async void anim()
        {
            await voitureImage.TranslateTo(0, 0, 1000, Easing.CubicOut);
            await voitureImage.ScaleTo(1, 1000, Easing.CubicOut);

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            voitureImage.Opacity = 0;
            voitureImage.TranslationX = -250;
            voitureImage.Scale = 0.5;
        }
    }
}