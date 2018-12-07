using System.Windows.Input;

namespace QuizApp
{
    public class BrowseFragmentVM : BaseViewModel
    {
        public BaseViewModel ViewModel { get; set; }

        public ICommand SetCoursesContainerFragment { get; set; }
        

        public BrowseFragmentVM()
        {
            SetCoursesContainerFragment = new ActionCommand(setCoursesContainterFragment, canExecuteMethod);
        }

        private bool canExecuteMethod(object parameter) => true;
        private void setCoursesContainterFragment(object parameter)
        {
            ViewModel = new CourseCardsContainerVM();
        }
        
    }
}
