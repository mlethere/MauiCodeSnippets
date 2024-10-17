using MauiCodeSnippets.ViewModels;

namespace MauiCodeSnippets.Views;

public partial class BirthdayPage : ContentPage
{
	public BirthdayPage()
	{
		InitializeComponent();

		// Removed this from the page, and placed it here so that I could call the constructor to load the birthdays
        BindingContext = new BirthdayListViewModel();
    }

    private void OnEditClicked(object sender, EventArgs e)
    {

    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {

    }
}