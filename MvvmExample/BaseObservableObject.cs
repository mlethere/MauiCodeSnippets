using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiCodeSnippets.MvvmExample
{
    /// <summary>
    /// Base class that supports property change notifications.
    /// </summary>
    public partial class BaseObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>/>
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        /// <summary>
        /// Raised when the value of a property has changed.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
