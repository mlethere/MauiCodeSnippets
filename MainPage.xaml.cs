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
            Navigation.PushAsync(new BirthdayPage());
        }


    }
}