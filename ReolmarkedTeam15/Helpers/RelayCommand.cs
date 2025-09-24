using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReolmarkedTeam15.Helpers
{
    public class RelayCommand : ICommand
    
    {
      
     // Action to execute when the command is triggered without parameters
        private readonly Action _execute;

        // Action to execute when the command is triggered with a parameter
        private readonly Action<object> _executeWithParam;

        // Optional method to determine if the command can execute (e.g. enabled/disabled logic)
        private readonly Func<bool> _canExecute;

        // Constructor for commands that don't take parameters
        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            // Store the parameterless action and the canExecute condition (if any)
            _execute = execute;
            _canExecute = canExecute;
        }

        // Constructor for commands that take parameters
        public RelayCommand(Action<object> executeWithParam)
        {
            // Store the action that takes an object as a parameter
            _executeWithParam = executeWithParam;
        }

        // Determines if the command can execute (returns true/false)
        public bool CanExecute(object parameter)
        {
            // If there's no specific condition, return true (allow command to execute)
            return _canExecute == null || _canExecute();
        }

        // Executes the appropriate action (parameterless or with parameter)
        public void Execute(object parameter)
        {
            // If the parameterless action is set, execute it
            if (_execute != null)
                _execute();
            // If the action with parameters is set, execute it with the passed parameter
            else
                _executeWithParam(parameter);
        }

        // Event triggered when CanExecute changes (helps WPF know when the command's enabled state changes)
        public event EventHandler CanExecuteChanged
        {
            // Add a handler for CanExecuteChanged (this gets triggered when we call CommandManager.RequerySuggested)
            add { CommandManager.RequerySuggested += value; }
            // Remove the handler for CanExecuteChanged
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
