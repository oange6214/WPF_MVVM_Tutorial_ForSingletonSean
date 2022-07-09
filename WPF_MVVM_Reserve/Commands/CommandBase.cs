using System;
using System.Windows.Input;

namespace WPF_MVVM_Reserve.Commands
{
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public abstract void Execute(object? parameter);
    }
}
