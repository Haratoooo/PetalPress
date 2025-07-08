using System.Collections.ObjectModel;
using System.Windows.Input;

public class OnboardingViewModel
{
    public ObservableCollection<OnboardingItem> OnboardingItems { get; set; }

    public ICommand GetStartedCommand { get; }

    public OnboardingViewModel()
    {
        OnboardingItems = new ObservableCollection<OnboardingItem>
        {
            new OnboardingItem
            {
                Title = "Write Daily Entries!",
                Description = "Reflect on your thoughts and emotions.",
                Illustration = "onboard1.png"
            },
            new OnboardingItem
            {
                Title = "Let’s write your Journal!",
                Description = "Connect with yourself today.",
                Illustration = "onboard2.png"
            }
        };

        GetStartedCommand = new Command(async () =>
        {
            await Shell.Current.GoToAsync("//GetStartedPage");
        });
    }
}

public class OnboardingItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Illustration { get; set; }
}
