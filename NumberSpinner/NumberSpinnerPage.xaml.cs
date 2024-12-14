namespace MauiCodeSnippets.NumberSpinner;

public partial class NumberSpinnerPage : ContentPage
{
	public NumberSpinnerPage()
	{
		InitializeComponent();
		NumberLabel.Text = "0";
		NumberStepper.ValueChanged += (s,e) => NumberLabel.Text = e.NewValue.ToString();
    }
}