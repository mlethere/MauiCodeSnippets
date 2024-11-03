namespace MauiCodeSnippets.ApiClientExample;

public partial class ApiClientExamplePage : ContentPage
{
	public ApiClientExamplePage(ApiClientExampleViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}