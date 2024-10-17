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

    /// <summary>
    /// Place holder for an edit function
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnEditClicked(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Place holder for a delete function
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDeleteClicked(object sender, EventArgs e)
    {

    }
}