using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiCodeSnippets.ViewModels
{
    // --------------------------------------------------------------------------------
    /// <summary>
    /// Partial Classbut View Model for the SImple V-VM Example
    /// Bsic Idea was from: https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/mvvm?view=net-maui-8.0
    /// </summary>
    // --------------------------------------------------------------------------------
    internal partial class SimpleVVMwithTimerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler ? PropertyChanged;

        private DateTime _currentDateTime;
        private readonly Timer _timerObject;
        private double _duration;
        private readonly DateTime _startTime = DateTime.Now;

        public DateTime CurrentDateTime
        {
            get => _currentDateTime;
            set
            {
                if (_currentDateTime != value)
                {
                    _currentDateTime = value;

                    // My Universtiy Math Professors would be proud of me for this one.
                    TimeSpan difference = this.CurrentDateTime - _startTime;
                    Duration = difference.TotalSeconds;

                    OnPropertyChanged(); // reports this property
                }
            }
        }

        /// <summary>
        /// This is called in the CurrentDateTime "set" when the timer fires.
        /// </summary>
        public double Duration
        {
            get => _duration;
            set
            {
                if (_duration != value)
                {
                    _duration = value;

                    // This is needed to refresh the object bound to Duration
                    OnPropertyChanged(); 
                }
            }
        }

        /// <summary>
        /// Set up the viewmodel, by initializing the DateTime property and creating the timer to fire every second.
        /// </summary>
        public SimpleVVMwithTimerViewModel()
        {
            this.CurrentDateTime = DateTime.Now;
            
            // Update the DateTime property every second.
            _timerObject = new Timer(new TimerCallback((s) => this.CurrentDateTime = DateTime.Now),
                               null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// Release the timer object when the viewmodel is no longer needed.
        /// </summary>
        ~SimpleVVMwithTimerViewModel() =>
            _timerObject.Dispose();

        /// <summary>
        /// Because this class implements INotifyPropertyChanged, it will raise this event when the value changes. This happens when the timer fires.
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
