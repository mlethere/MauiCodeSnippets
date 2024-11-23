namespace MauiCodeSnippets.GetValueFromChildPage.Views;

public partial class ChildPage : ContentPage
{
    private readonly TaskCompletionSource<string> _tcs;

    public ChildPage(TaskCompletionSource<string> tcs)
	{
        // Store the TaskCompletionSource for later use
        InitializeComponent();
        _tcs = tcs; // Store the TaskCompletionSource for later use
    }

    private async void OnSubmitButtonClicked(object sender, EventArgs e)
    {

        // Retrieve the user input from the Entry control
        string userInput = InputEntry.Text; // Assuming there's an Entry named InputEntry in XAML

        // Set the result of the TaskCompletionSource
        _tcs.SetResult(userInput); // Complete the Task with the user input

        // Remove the page from the Navigation Stack
        await Navigation.PopAsync(); // Navigate back
    }
}