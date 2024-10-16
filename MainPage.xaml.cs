﻿using MauiCodeSnippets.Views;

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

        private void OnSimpleMvvm_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleVVMwithTimerPage());
        }

        private void OnNumberPaidClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NumberPadDataEntryPage());
        }

        // Next : Create a Dial a Number Pop Up Page
    }

}
