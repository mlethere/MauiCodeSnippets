using MauiCodeSnippets.BaseClasses;

namespace MauiCodeSnippets.MvvmExample
{
    public partial class BirthdayViewModel : BaseViewModel
    {
        private BirthdayModel _birthdayRecord = new();

        public BirthdayViewModel()
        {
            // TODO: ADD a list? --> Another example .. 
            // TODO: https://www.youtube.com/watch?v=H59lHvg4Cik
            // TODO: Add in Cancel and Update buttons
            // TODO: log that we "saved" the data
            // TODO: Add a number so that we can "pick"
        }

        public BirthdayModel BirthdayRecord
        {
            get => _birthdayRecord;
            set
            {
                _birthdayRecord = value;
                OnPropertyChanged();
            }
        }
    }
}
