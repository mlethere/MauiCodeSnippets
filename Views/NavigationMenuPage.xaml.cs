namespace MauiCodeSnippets.Views;

public partial class NavigationMenuPage : ContentPage
{
	public NavigationMenuPage()
	{
		InitializeComponent();
	}

    // ********************************************************************************
    /// <summary>
    /// OnTapEvent from the grid displayed in NavigrationMenuPage.xaml
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    // <created>MarkyL,2024-10-13</created>
    // <changed>MarkyL,2024-10-13</changed>
    // ********************************************************************************
    private async void OnGridRowTapped(object sender, TappedEventArgs e)
    {
        // Get the tapped element
        var tappedElement = (View)sender;

        // Get the current background color of the tapped element
        var currentBackgroundColor = tappedElement.BackgroundColor;

        // Change the background color of the tapped element so it shows in the background that it is light gray. THis can be changed to a default
        tappedElement.BackgroundColor = Colors.LightGray;

        // Get the row and column indices of the tapped element
        int row = Grid.GetRow(tappedElement);
        int column = Grid.GetColumn(tappedElement);

        // Display an alert and wait for the user to acknowledge it
        // This only works because we are in the XAML Page CS .. doesn't work in a class such as a viewmodel
        await DisplayAlert("Grid Tapped", $"You taped an element in the grid. It was row # {row} and column # {column}!", "OK");

        // Revert the background color of the tapped element to its original color
        tappedElement.BackgroundColor = currentBackgroundColor;
    }
}