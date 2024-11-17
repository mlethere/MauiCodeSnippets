using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiCodeSnippets.RoutingWithParameters
{
    /// <summary>
    /// I could not change these values from the exact same value. I guess we keep them the same as the Property
    /// </summary>
    [QueryProperty("PassedModel", "PassedModel")]
    public partial class DetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private MyModel passedModel = new MyModel();
    }
}