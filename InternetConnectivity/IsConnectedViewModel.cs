using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiCodeSnippets.InternetConnectivity;

/// <summary>
/// An internet connectivity test class that calls a 3rd party class with Microsoft.
/// I followed the ViewModel pattern and registered the page and the IConnectivity interface.
/// </summary>
public partial class IsConnectedViewModel(IConnectivity connectivity) : ObservableObject
{
    private readonly IConnectivity connectivity = connectivity;

    [RelayCommand]
    async Task CheckConnection()
    {
        if (this.connectivity.NetworkAccess != NetworkAccess.Internet)
            await Shell.Current.DisplayAlert("You are not connected!", "Internet Connectivity Test", "Okay");
        else
            await Shell.Current.DisplayAlert("All good with the World!", "Internet Connectivity Test", "Okay");

        return;
    }
}
