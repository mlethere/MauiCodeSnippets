namespace MauiCodeSnippets.RoutingWithParameters;

public partial class LandingPage : ContentPage
{
	public LandingPage(LandingViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}