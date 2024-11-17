using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiCodeSnippets.RoutingWithParameters
{
    public partial class LandingViewModel : ObservableObject
    {
        [ObservableProperty]
        private string sName = "Mark";

        [ObservableProperty]
        private int iInt = 57;

        [RelayCommand]
        private async Task SendToDetailsPage()
        {
            var newModel = new MyModel
            {
                MyString = SName,
                MyInt = IInt
            };

            // I find this finickity, but get the PassedModel name correct and it seems to all work 
            var navigationParameters = new Dictionary<string, object>
            {
                { "PassedModel", newModel }
            };

            await Shell.Current.GoToAsync(nameof(DetailsPage), navigationParameters);
        }
    }
}
