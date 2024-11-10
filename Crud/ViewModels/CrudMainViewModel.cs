using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiCodeSnippets.Crud.Models;
using System.Collections.ObjectModel;
using static MauiCodeSnippets.Crud.Models.CrudModel;
namespace MauiCodeSnippets.Crud.ViewModels;

public partial class CrudMainViewModel : ObservableObject
{

    private CrudModel FamilyModel { get; set; } = new CrudModel();

    public CrudMainViewModel()
    {
        FamilyModel.LoadFromLocalFile();
        familyName = FamilyModel.Family.FamilyName;
        members = new ObservableCollection<PersonModel>(FamilyModel.Family.FamilyMembers);
        kidsNames = new ObservableCollection<string>(FamilyModel.Family.FamilyMembers.Select(x => x.FirstName));
    }

    [ObservableProperty]
    private string familyName = string.Empty;

    [ObservableProperty]
    ObservableCollection<PersonModel> members;

    [ObservableProperty]
    ObservableCollection<string> kidsNames;

    [ObservableProperty]
    private string newFamilyName = string.Empty;

    [ObservableProperty]
    private DateOnly dateOfBirth = DateOnly.MinValue;

    [RelayCommand]
    async Task UpdateFamilyName()
    {
        FamilyModel.Family.FamilyName = FamilyName;

        FamilyModel.SaveToLocalFile();
        await Shell.Current.DisplayAlert("Family Name Updated", "The family name has been updated", "Okay");
    }

    [RelayCommand]
    async Task GetLocalDbFileName()
    {
        await Shell.Current.DisplayAlert("Local Filename Location", FamilyModel.GetLocalFilename(), "Okay");
    }

    [RelayCommand]
    async Task AddFamilyMember()
    {
        FamilyModel.AddFamilyMember(NewFamilyName, DateOfBirth);
        FamilyModel.SaveToLocalFile();
        KidsNames.Add(NewFamilyName);
        await Shell.Current.DisplayAlert("Family Member Added", "The family member has been added", "Okay");
    }

    [RelayCommand]
    async Task RemoveFamilyMember(string memberName)
    {
        // TODO: Change to be ID #
        // TODO: Add a contains (like below) in Model and then refresh the whole list.
        FamilyModel.RemoveFamilyMember(memberName);
        FamilyModel.SaveToLocalFile();
        if (KidsNames.Contains(memberName))
            KidsNames.Remove(memberName);
        await Shell.Current.DisplayAlert($"Family Member Removed", $"The family member {memberName} has been removed", "Okay");
    }
}
