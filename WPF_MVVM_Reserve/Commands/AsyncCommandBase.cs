using System.Threading.Tasks;

namespace WPF_MVVM_Reserve.Commands
{
    public abstract class AsyncCommandBase : CommandBase
    {
        private bool _isExecuting;

        private bool IsExecuting
        {
            get { return _isExecuting; }
            set 
            { 
                _isExecuting = value; 
                OnCanExecutedChanged(); 
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return base.CanExecute(parameter);
        }

        public override async void Execute(object? parameter)
        {
            IsExecuting = true;

            try
            {
                await ExecuteAsync(parameter);
            }
            finally
            {
                IsExecuting = false;
            }
        }

        public abstract Task ExecuteAsync(object parameter);
    }
}
