using CommunityToolkit.Mvvm.ComponentModel;
using MauiCodeSnippets.Models;
using System.Collections.ObjectModel;

namespace MauiCodeSnippets.ViewModels
{
    public class BirthdayListViewModel : ObservableObject
    {
        // TODO: Add buttons for adding
        // TODO: Remove an item from the list and see if it automatically refreshes this ObservableCollection
        // TODO: Edit an item
        
        /// <summary>
        /// I am not sure of the purpose of this. Is it literally monitoring any changes to this view model (ListView) and refreshes the list?
        /// </summary>
        public ObservableCollection<BirthdayViewModel> BirthdayList { get; set; } = new ObservableCollection<BirthdayViewModel>();

        /// <summary>
        /// Called from the BirthdayPage C# code to load the list of birthdays
        /// </summary>
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
