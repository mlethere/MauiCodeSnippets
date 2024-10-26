using MauiCodeSnippets.Views;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiCodeSnippets.ViewModels
{
    internal partial class NumberPadDataEntryViewModel : INotifyPropertyChanged
    {
        private readonly char[] _specialChars = { '*', '#' };
        private string _displayText = "";
        private string _inputString = "";

        public NumberPadDataEntryViewModel()
        {
            // Command to add the key to the input string
            AddCharCommand = new Command<string>((key) => InputString += key);

            // Command to delete a character from the input string when allowed
            // Interesting here is that the 2nd parameter is a where clause
            DeleteCharCommand =
                new Command(
                    // Command will strip a character from the input string
                    () => InputString = InputString.Substring(0, InputString.Length - 1),

                    // CanExecute is processed here to return true when there's something to delete
                    () => InputString.Length > 0
                );

            ClearNumberCommand =
                new Command(
                    () => ClearStringByMark(),
                    () => InputString.Length > 0
                    );

            DialNumberCommand = new Command(
                () => DialNumberByMark(),
                () => CanDialNumberByMark()
                );
        }

        private bool CanDialNumberByMark()
        {
            // Changed it up - dial number if we only have numbers and it is equal to 10 characters
            bool result = 
                _inputString.IndexOfAny(_specialChars) == -1 &&
                _inputString.Length >= 10;

            return result ;
        }

        private void DialNumberByMark()
        {
            // Create a new page and Pop is pretending to dial a number .....

            ContentPage newPage = new NumberDialPadCallPage(_inputString);
            // Use the Navigation property to push the new page onto the navigation stack
            Application.Current?.MainPage?.Navigation.PushAsync(newPage);

        }

        public void SetNumberToDial(string numberToDial)
        {
            // Not sure that this is the best way to do this ..... when I cover passing view models I may come back to this.
            InputString = numberToDial;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand AddCharCommand { get; private set; }

        /// <summary>
        /// I added this command, so that I extend this functionality
        /// </summary>
        public ICommand ClearNumberCommand { get; private set; }
        public ICommand DeleteCharCommand { get; private set; }

        /// <summary>
        /// I added this number so that I could extend the functionality
        /// </summary>
        public ICommand DialNumberCommand { get; private set; }

        public string DisplayText
        {
            get => _displayText;
            private set
            {
                if (_displayText != value)
                {
                    _displayText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string InputString
        {
            get => _inputString;
            private set
            {
                // Only update if the value of _inputString <> InputString
                if (_inputString != value)
                {
                    _inputString = value;
                    OnPropertyChanged();

                    // Set the property DisplayText to a formatted version of the input string
                    DisplayText = FormatText(_inputString);

                    // ml / 14/10/2024:
                    // Interesting here is that we appear to be refreshing the Delete Command
                    // If I disable this line, the Delete button never gets enabled.
                    ((Command)DeleteCharCommand).ChangeCanExecute();

                    // ml / 14/10/2024: Added these two lines
                    ((Command)ClearNumberCommand).ChangeCanExecute();
                    ((Command)DialNumberCommand).ChangeCanExecute();
                }
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        // ********************************************************************************
        /// <summary>
        /// Clears the Input String. I didn't need a Method to do this, but I thought I would try it.
        /// </summary>
        /// <returns></returns>
        // <created>MarkyL,2024-10-14</created>
        // <changed>MarkyL,2024-10-14</changed>
        // ********************************************************************************
        private void ClearStringByMark()
        {
            // What's interesting here, is that I thought I would have to do more than set the string to empty. As the whole CanExecute is handled by InputString I did not.
            InputString = string.Empty;
        }

        private string FormatText(string str)
        {
            // Does the string have any special characters defined in the _specialChars array? Different method than using contains ...
            bool hasNonNumbers = str.IndexOfAny(_specialChars) != -1;
            string formatted = str;

            // Format the string based on the type of data and the length
            if (hasNonNumbers || str.Length < 4 || str.Length > 10)
            {
                // Special characters exist, or the string is too small or large for special formatting
                // Do nothing
            }
            else if (str.Length < 8)
                // If string is less than 8 characters, format as (XXX) XXXX
                formatted = string.Format("{0}-{1}", str.Substring(0, 3), str.Substring(3));
            else

                // if string is 8 characters or longer, format as (XXX) XXX-XXXXXXXXXX
                formatted = string.Format("({0}) {1}-{2}", str.Substring(0, 3), str.Substring(3, 3), str.Substring(6));

            return formatted;
        }
    }
}