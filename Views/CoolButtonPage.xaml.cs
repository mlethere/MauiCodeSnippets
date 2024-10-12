using System.Data.Common;

namespace MauiCodeSnippets.Views;

public partial class CoolButtonPage : ContentPage
{
	public CoolButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("I got clicked", "I like the look of this button", "OK");
    }
}