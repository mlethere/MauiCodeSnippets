using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiCodeSnippets.Crud.Models;
using System.Collections.ObjectModel;

namespace MauiCodeSnippets.Crud.ViewModels;

public partial class CrudMainViewModel : ObservableObject
{
    /// <summary>
    /// Used when someone wants to add a new family member
    /// </summary>
    [ObservableProperty]
    private DateTime dateOfBirth = DateTime.Now.Date;

    /// <summary>
    /// Allows for us to edit the family name
    /// </summary>
    [ObservableProperty]
    private string familyName = string.Empty;

    /// <summary>
    /// List of family members
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<PersonModel> members;

    /// <summary>
    /// Used when someone wants to add a new family member
    /// </summary>
    [ObservableProperty]
    private string newFamilyName = string.Empty;

    public CrudMainViewModel()
    {
        // Load data from the file repository
        FamilyModel.LoadFromLocalFile();

        // setup the main family name property
        familyName = FamilyModel.Family.FamilyName;

        // load the family members
        members = new ObservableCollection<PersonModel>(FamilyModel.Family.FamilyMembers);
    }

    private CrudModel FamilyModel { get; set; } = new CrudModel();

    [RelayCommand]
    private async Task AddFamilyMember()
    {
        if (!FamilyModel.AddFamilyMember(NewFamilyName, DateOfBirth))
            await Shell.Current.DisplayAlert("Family Member Add", "Unfortunately the family member was not added", "Okay");

        Members = new ObservableCollection<PersonModel>(FamilyModel.Family.FamilyMembers);
    }

    /// <summary>
    /// This was more for fun, than any particular reason Display the file name where the local file repository is.
    /// </summary>
    /// <returns></returns>
    [RelayCommand]
    private async Task GetLocalDbFileName()
    {
        await Shell.Current.DisplayAlert("Local Filename Location", FamilyModel.GetLocalFilename(), "Okay");
    }

    [RelayCommand]
    private async Task RemoveFamilyMember(string memberName)
    {
        // TODO: Change to be ID #
        // TODO: Add a contains (like below) in Model and then refresh the whole list.
        FamilyModel.RemoveFamilyMember(memberName);
        FamilyModel.SaveToLocalFile();
        // TODO: Refresh the list
    }

    /// <summary>
    /// Update's the mail family name
    /// </summary>
    /// <returns></returns>
    [RelayCommand]
    private async Task UpdateFamilyName()
    {
        FamilyModel.Family.FamilyName = FamilyName;
        FamilyModel.SaveToLocalFile();

        await Shell.Current.DisplayAlert("Family Name Updated", "The family name has been updated", "Okay");
    }
}