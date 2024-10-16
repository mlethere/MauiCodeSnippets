using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCodeSnippets.ViewModels
{
    public class BirthdayViewModel : ObservableObject
    {
        private string _name = string.Empty;
        private DateTime _birthDate = DateTime.Now;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set => SetProperty(ref _birthDate, value);
        }

        public BirthdayViewModel(Models.BirthdayModel birthdayRecord)
        {
            _name = birthdayRecord.Name;
            _birthDate = birthdayRecord.BirthDate;
        }

    }
}
