namespace MauiCodeSnippets.MvvmExample2;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}