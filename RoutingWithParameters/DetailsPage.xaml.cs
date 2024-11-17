namespace MauiCodeSnippets.RoutingWithParameters;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}