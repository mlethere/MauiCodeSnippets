namespace MauiCodeSnippets.MvvmExample
{
    public partial class BirthdayViewModel : BaseViewModel
    {
        private BirthdayModel _birthdayRecord = new();

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
