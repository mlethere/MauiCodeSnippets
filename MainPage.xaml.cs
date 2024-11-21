using CommunityToolkit.Maui.Views;
using MauiCodeSnippets.ApiClientExample;
using MauiCodeSnippets.Crud.Views;
using MauiCodeSnippets.DateTimePickerExamples;
using MauiCodeSnippets.GlobalViewModelExample;
using MauiCodeSnippets.InternetConnectivity;
using MauiCodeSnippets.MvvmExample;
using MauiCodeSnippets.MvvmExample2;
using MauiCodeSnippets.Popups;
using MauiCodeSnippets.RoutingWithParameters;
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

        /// <summary>
        /// Version 2 of MVVM example
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBirthdays2Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BirthdayPage2(new BirthdayPage2ViewModel()));
        }

        private async void OnInternetConnectivity(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(IsConnectedPage));
        }

        private async void OnDateTimeExamples(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DT_ExamplePage));
        }

        private async void OnApiClientExampleClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ApiClientExamplePage));
        }

        private async void OnCrudExampleClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CrudMainPage));
        }

        private async void OnGlobalDataExampleClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GlobalViewModelPage1));
        }

        private async void OnGlobalDataExample2Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GlobalViewModelPage2));
        }

        private async void OnRoutingWithParametersClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(LandingPage));
        }

        private void OnPopupClicked(object sender, EventArgs e)
        {
            var popup = new SimplePopup();

            this.ShowPopup(popup);
        }
    }
}