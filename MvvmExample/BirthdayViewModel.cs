using MauiCodeSnippets.BaseClasses;

namespace MauiCodeSnippets.MvvmExample
{
    public class BirthdayViewModel : BaseViewModel
    {
        private int _myVar;

        public BirthdayViewModel()
        {
            // TODO: Remove this line
            // TODO: Use the Model
            // TODO: ADD a list?
            _myVar = 50;
        }

        public int MyVar
        {
            get => _myVar;
            set
            {
                _myVar = value;
                OnPropertyChanged();
            }
        }
    }
}
