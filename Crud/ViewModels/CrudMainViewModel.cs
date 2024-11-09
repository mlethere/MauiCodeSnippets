using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiCodeSnippets.Crud.Models;
namespace MauiCodeSnippets.Crud.ViewModels;

public partial class CrudMainViewModel : ObservableObject
{

    private CrudModel FamilyModel { get; set; } = new CrudModel();

    public CrudMainViewModel()
    {
        FamilyModel.LoadFromLocalFile();
        familyName = FamilyModel.Family.FamilyName;
    }

    [ObservableProperty]
    private string familyName = string.Empty;

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
}
