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
        // 20th October 2024.
        // This is being called by the click even but I cannot seem to call the Remove method in the ListViewModel class

        MenuItem menuItem = (MenuItem)sender;

        // Although the Binding Context if BirthdayListViewModel the menu items are of type BirthdayViewModel
        BirthdayViewModel selectedBirthdayItem = (ViewModels.BirthdayViewModel)menuItem.BindingContext;

        // TODO: Next ... let us just find another example ......



    }
}