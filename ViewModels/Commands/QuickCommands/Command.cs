using System;
using System.Windows.Input;

namespace ViewModels.Commands.QuickCommands
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action _execute;
        private readonly Func<bool>? _canExecute;
        private readonly IErrorHandler? _errorHandler;

        public Command(
            Action execute, 
            Func<bool>? canExecute = null, 
            IErrorHandler? errorHandler = null) 
        {
            _execute = execute;
            _errorHandler = errorHandler;
            _canExecute = canExecute;
        }
        public bool CanExecute() => _canExecute?.Invoke() ?? true;
        public void Execute()
        {
            if(CanExecute()) _execute();
            RaiseCanExecuteChanged();
        }
        public void RaiseCanExecuteChanged() =>
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        
        #region Explicit implementations
        bool ICommand.CanExecute(object? parameter) => CanExecute();

        void ICommand.Execute(object parameter) => Execute();
        #endregion
    }
}
