using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiCodeSnippets.GlobalViewModelExample;

/// <summary>
/// This view model is defined at the App.xaml.cs level
/// I can load a page that references this viewmodel, and the data will remain as long as the App stays open
/// </summary>
public partial class GlobalViewModel : ObservableObject
{
    public GlobalViewModel()
    {
        // I needed to initialize the "array".
        MyDateTimes =[];
    }

    [ObservableProperty]
    ObservableCollection<DateTime> myDateTimes;

    [RelayCommand]
    void Add()
    {
        DateTime dateTime = DateTime.Now;
        MyDateTimes.Add(dateTime);
    }

}
