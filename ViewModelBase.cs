using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Elias.Wpf.Common;

public class ViewModelBase : INotifyPropertyChanged
{
    protected virtual void OnPropertyChanged([CallerMemberName] string? propName = null)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
