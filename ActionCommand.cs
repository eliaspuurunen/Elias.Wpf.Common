using System.Windows.Input;

namespace Elias.Wpf.Common.Commands;
    
public class ActionCommand : ICommand
{
    private readonly Action action;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? _)
    {
        return true;
    }

    public void Execute(object? _)
    {
        this.action.Invoke();
    }

    public ActionCommand(Action action)
    {
        this.action = action;
    }
}
