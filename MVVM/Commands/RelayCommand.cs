using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVM.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;

        

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            

            this.canExecute = canExecute;
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
         {
            return canExecute == null || canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
