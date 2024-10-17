using CommunityToolkit.Mvvm.ComponentModel;
using MauiCodeSnippets.Models;
using System.Collections.ObjectModel;

namespace MauiCodeSnippets.ViewModels
{
    public class BirthdayListViewModel : ObservableObject
    {
        public ObservableCollection<BirthdayViewModel> BirthdayList { get; set; } = new ObservableCollection<BirthdayViewModel>();

        public BirthdayListViewModel()
        {
            LoadBirthdayList();
        }

        public void LoadBirthdayList()
        {
            IEnumerable<Models.BirthdayModel> birthdayListFromRepo = Models.BirthdayModelRepository.Get();
            
            foreach (Models.BirthdayModel birthdayRecord in birthdayListFromRepo)
                BirthdayList.Add(new BirthdayViewModel(birthdayRecord));
        }
    }
}
