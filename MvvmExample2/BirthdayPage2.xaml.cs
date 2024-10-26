namespace MauiCodeSnippets.MvvmExample2;

public partial class BirthdayPage2 : ContentPage
{
	public BirthdayPage2(BirthdayPage2ViewModel vm)
	{
        // I am using DI to inject the view model
        InitializeComponent();
        BindingContext = vm;
    }
}