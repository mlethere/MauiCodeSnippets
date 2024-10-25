namespace MauiCodeSnippets.MvvmExample;

public partial class BirthdayPage : ContentPage
{
	// ********************************************************************************
	/// <summary>
	/// BirthdayPage Constructor, and manually setting up the Binding Context with the passed Model
	/// </summary>
	/// <param name="birthdayModel"></param>
	/// <returns></returns>
	// <created>MarkyL,2024-10-25</created>
	// <changed>MarkyL,2024-10-25</changed>
	// ********************************************************************************
	public BirthdayPage(BirthdayModel birthdayModel)
	{
		InitializeComponent();

        var vm = new BirthdayViewModel
        {
            BirthdayRecord = birthdayModel
        };
        BindingContext = vm;
    }
}