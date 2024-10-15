using MauiCodeSnippets.ViewModels;

namespace MauiCodeSnippets.Views;

public partial class NumberDialPadCallPage : ContentPage
{
	// ********************************************************************************
	/// <summary>
	/// Passes a string from calling viewModel. Re-displays it here using the same view model
	/// </summary>
	/// <param name="_inputString"></param>
	/// <returns></returns>
	// <created>MarkyL,2024-10-15</created>
	// <changed>MarkyL,2024-10-15</changed>
	// ********************************************************************************
	public NumberDialPadCallPage(string _inputString)
	{
		InitializeComponent();

		var newViewModel = new NumberPadDataEntryViewModel();
		newViewModel.SetNumberToDial(_inputString);

        BindingContext = newViewModel;

        
    }
}