using CommunityToolkit.Mvvm.ComponentModel;
using MauiCodeSnippets.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCodeSnippets.ViewModels
{
    public class BirthdayViewModel : ViewModelBaseClass
    {
        public BirthdayViewModel()
        {
            Name = "unknown";
        }

        private string _name = string.Empty;
        private DateTime _birthDate = DateTime.Now;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
    }
}
