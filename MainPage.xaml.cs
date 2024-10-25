using MauiCodeSnippets.MvvmExample;
using MauiCodeSnippets.Views;

namespace MauiCodeSnippets
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCoolButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CoolButtonPage());
        }

        private void OnNavigationMenuClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationMenuPage());
        }

        private void OnNumberPaidClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumberPadDataEntryPage());
        }

        private void OnSimpleMvvm_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleVVMwithTimerPage());
        }

        private void OnBirthdaysClicked(object sender, EventArgs e)
        {
            // Next : https://learn.microsoft.com/en-us/training/modules/design-mvvm-viewmodel/2-what-is-mvvm

            // Just demonstrating how to pass in a new model. This would come from another source like an API or Database Table.
            Navigation.PushAsync(
                new BirthdayPage(
                    new BirthdayModel
                    {
                        Name = "Mark",
                        BirthDate = new DateTime(1967, 9, 7)
                    }));
        }


    }
}