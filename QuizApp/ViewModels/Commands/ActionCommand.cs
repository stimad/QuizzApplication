using System;
using System.Windows.Input;

namespace QuizApp
{
    class ActionCommand : ICommand
    {
        public BaseViewModel ViewModel { get; set; }

        Action<object> executeMethod;
        Func<object, bool> canExecuteMethod;
        public ActionCommand(Action<object> executeMethod, Func<object, bool> canExecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canExecuteMethod = canExecuteMethod;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}
