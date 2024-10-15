using MauiCodeSnippets.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCodeSnippets.ViewModels
{
    public class BirthdayViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private BirthdayModel _model = new BirthdayModel();

        public string Name
        {
            get => _model.Name;
            set
            {
                if (_model.Name != value)
                {
                    _model.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public DateTime BirthDate
        {
            get => _model.BirthDate;
            set
            {
                if (_model.BirthDate != value)
                {
                    _model.BirthDate = value;
                    OnPropertyChanged(nameof(BirthDate));
                }
            }
        }

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
