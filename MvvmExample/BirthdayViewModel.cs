using MauiCodeSnippets.BaseClasses;

namespace MauiCodeSnippets.MvvmExample
{
    public class BirthdayViewModel : BaseViewModel
    {
        private BirthdayModel _birthdayRecord;
        private int _myInt;

        public BirthdayViewModel()
        {
            // TODO: Remove this line
            // TODO: Use the Model
            // TODO: ADD a list?
            // TODO: https://www.youtube.com/watch?v=H59lHvg4Cik
            _birthdayRecord = new BirthdayModel
            {
                Name = "Mark",
                BirthDate = new DateTime(1967, 9, 7)
            };

            _myInt = 42;
        }

        public int MyInt
        {
            get => _myInt;
            set
            {
                _myInt = value;
                OnPropertyChanged();
            }
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
