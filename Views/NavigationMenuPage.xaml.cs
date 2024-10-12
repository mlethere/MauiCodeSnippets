namespace MauiCodeSnippets.Views;

public partial class NavigationMenuPage : ContentPage
{
	public NavigationMenuPage()
	{
		InitializeComponent();
	}

    private void OnGridRowTapped(object sender, TappedEventArgs e)
    {
        // Get the tapped element
        var tappedElement = (View)sender;

        // Get the row and column indices of the tapped element
        int row = Grid.GetRow(tappedElement);
        int column = Grid.GetColumn(tappedElement);

        // Display the row and column indices
        DisplayAlert("Grid Tapped", $"Tapped element is in row {row} and column {column}!", "OK");
    }
}