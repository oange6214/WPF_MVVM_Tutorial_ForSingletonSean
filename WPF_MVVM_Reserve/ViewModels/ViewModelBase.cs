using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_MVVM_Reserve.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public virtual void Dispose()
        {

        }
    }
}
