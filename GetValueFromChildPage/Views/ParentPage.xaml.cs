namespace MauiCodeSnippets.GetValueFromChildPage.Views;

public partial class ParentPage : ContentPage
{
	public ParentPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Call the Child Page and wait for result.
        string result = await ChildPageAsync();
        await DisplayAlert("Result", $"You entered: {result}", "OK");
    }

    private async Task<string> ChildPageAsync()
    {
        // Initializes a TaskCompletionSource<string>.
        var tcs = new TaskCompletionSource<string>();

        // Create a new instance of the ChildPage and pass the TaskCompletionSource.
        var childPage = new ChildPage(tcs);
        await Navigation.PushAsync(childPage);

        // Wait for the result from the InputPage
        return await tcs.Task; 
    }
}