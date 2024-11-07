namespace MauiCodeSnippets.GlobalViewModelExample;

public partial class GlobalViewModelPage1 : ContentPage
{
	public GlobalViewModelPage1()
	{
		// I did not inject a view model into here, as we are referencing the Global View Model from App.Xaml.cs
		InitializeComponent();
		BindingContext = App.MyGlobalViewModel;
	}
}