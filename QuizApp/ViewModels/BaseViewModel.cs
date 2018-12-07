using System;
using System.ComponentModel;

namespace QuizApp
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event EventHandler CanExecuteChanged;
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

    }
}
