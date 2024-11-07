namespace MauiCodeSnippets.GlobalViewModelExample;

public partial class GlobalViewModelPage2 : ContentPage
{
	public GlobalViewModelPage2()
	{
		InitializeComponent();
        BindingContext = App.MyGlobalViewModel;
    }
}