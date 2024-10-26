using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiCodeSnippets.MvvmExample2
{
    // --------------------------------------------------------------------------------
    /// <summary>
    /// This is not bound to a View yet; But does demonstrate a different way of binding objects.
    /// The ObservableObject comes from the Mvvm Input and creates automatic coding ... so cool
    /// Instead of generating this code over and over again, "it just works".
    /// If you hover the mouse pointer over the Attributes, you can see the code that it will generate.
    /// What is also cool, is that the two functions Add and Remove have the attributes [RelayCommand] and this auto generates the code in the ViewPage
    /// </summary>
    // --------------------------------------------------------------------------------
    public partial class BirthdayPage2ViewModel : ObservableObject
    {
        public BirthdayPage2ViewModel()
        {
            Items =
            [
                "Mark", "Grizzly", "Marley"
            ];
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text = string.Empty;

        [RelayCommand]
        void Add()
        {
            if (String.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Remove(string item)
        {
            if (Items.Contains(item))
                Items.Remove(item);
        }
    }
}
