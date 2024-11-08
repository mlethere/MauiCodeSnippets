using MauiCodeSnippets.Crud.ViewModels;

namespace MauiCodeSnippets.Crud.Views;

public partial class CrudMainPage : ContentPage
{
    public CrudMainPage(CrudMainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}