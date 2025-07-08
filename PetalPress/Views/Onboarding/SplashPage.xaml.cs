using System;
using Microsoft.Maui.Controls;

namespace PetalPress.Views.Onboarding
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            StartTimer();
        }

        private async void StartTimer()
        {
            await Task.Delay(2000); // 2 second splash screen
            await Shell.Current.GoToAsync("//OnboardingPage");
        }
    }
}