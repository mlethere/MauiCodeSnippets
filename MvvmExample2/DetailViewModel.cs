
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace MauiCodeSnippets.MvvmExample2;

/// <summary>
/// To get this to work:
/// We called this from the Tap command in the BirthdayPage2ViewModel Tap method and passed the parameter
/// The DetailPage.xaml.cs had the view model passed in the constructor, and then bound the context to the view model
/// In MauiProgram.cs we added the DetailViewModel to the services as a transient
/// In AppShell.xaml.cs we registered the route for the DetailPage
/// </summary>

[QueryProperty("Text", "Text")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text = string.Empty;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}


