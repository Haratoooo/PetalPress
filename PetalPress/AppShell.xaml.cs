using PetalPress.Views.Onboarding;
using PetalPress.Views.Auth;

namespace PetalPress;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes
        Routing.RegisterRoute("SplashPage", typeof(SplashPage));
        Routing.RegisterRoute("OnboardingPage", typeof(OnboardingPage));
        Routing.RegisterRoute("GetStartedPage", typeof(GetStartedPage));
        Routing.RegisterRoute("SignInPage", typeof(SignInPage));
        Routing.RegisterRoute("SignUpPage", typeof(SignUpPage));
        Routing.RegisterRoute("WelcomeMessagePage", typeof(WelcomeMessagePage));

        // Navigate to splash screen at startup
        GoToAsync("//SplashPage");
    }
}
