using System.Windows.Input;

namespace Elias.Wpf.Common.Commands;

public class ActionCommand<TParam> : ICommand
{
    private readonly Action<TParam> action;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? _)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter is not TParam)
        {
            throw new ArgumentException($"Expected type {typeof(TParam)} for command. Got wrong type.");
        }

        this.action.Invoke((TParam)parameter);
    }

    public ActionCommand(Action<TParam> action)
    {
        this.action = action;
    }
}
