using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace PetalPress.ViewModels
{
    public class AuthViewModel
    {
        public ICommand NavigateToSignUp { get; set; }
        public ICommand NavigateToSignIn { get; set; }

        public AuthViewModel()
        {
            NavigateToSignUp = new Command(async () =>
            {
                await Shell.Current.GoToAsync("//SignUpPage");
            });

            NavigateToSignIn = new Command(async () =>
            {
                await Shell.Current.GoToAsync("//SignInPage");
            });
        }
    }
}