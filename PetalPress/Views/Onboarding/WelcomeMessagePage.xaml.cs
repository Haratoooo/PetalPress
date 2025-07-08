namespace PetalPress.Views.Onboarding;

public partial class WelcomeMessagePage : ContentPage
{
    public WelcomeMessagePage()
    {
        InitializeComponent();
    }

    private async void OnStartWritingClicked(object sender, EventArgs e)
    {
        // Placeholder navigation or message
        Console.WriteLine("Start Writing button clicked");
        // await Shell.Current.GoToAsync("//GetStartedPage");
    }
}
