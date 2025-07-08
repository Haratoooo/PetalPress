using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace PetalPress.ViewModels
{
    public class OnboardingItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class OnboardingViewModel
    {
        public ObservableCollection<OnboardingItem> OnboardingItems { get; set; }
        public ICommand GetStartedCommand { get; set; }

        public OnboardingViewModel()
        {
            OnboardingItems = new ObservableCollection<OnboardingItem>
            {
                new OnboardingItem
                {
                    Title = "Write Daily Entries!",
                    Description = "Reflect on your thoughts and emotions, one entry at a time."
                },
                new OnboardingItem
                {
                    Title = "Let's write your Journal!",
                    Description = "Connect with yourself and document your journey today."
                }
            };

            GetStartedCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("//GetStartedPage");
            });
        }
    }
}