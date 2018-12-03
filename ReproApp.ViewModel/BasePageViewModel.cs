using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReproApp.ViewModels
{
    public abstract class BasePageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}