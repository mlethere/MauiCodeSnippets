namespace MauiCodeSnippets.InternetConnectivity;

public partial class IsConnectedPage : ContentPage
{
	public IsConnectedPage(IsConnectedViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}