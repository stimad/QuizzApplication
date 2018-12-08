using System.Windows.Input;

namespace QuizApp
{
    public class BrowseFragmentVM : BaseViewModel
    {
        public BaseViewModel ViewModel { get; set; }

        public ICommand SetCoursesContainerFragment { get; set; }
        public ICommand SetBrowseOverviewFragment { get; set; }
        public ICommand SetCategoriesFragment { get; set; }
        public ICommand SetInstructorsFragment { get; set; }
        public ICommand SetSchoolsFragment { get; set; }
        public ICommand SetLibraryFragment { get; set; }

        public BrowseFragmentVM()
        {
            SetCoursesContainerFragment = new ActionCommand(setCoursesContainterFragment, canExecuteMethod);
            SetBrowseOverviewFragment = new ActionCommand(setBrowseOverviewFragment, canExecuteMethod);
            SetCategoriesFragment = new ActionCommand(setCategoriesFragment, canExecuteMethod);
            SetInstructorsFragment = new ActionCommand(setInstructorsFragment, canExecuteMethod);
            SetSchoolsFragment = new ActionCommand(setSchoolsFragment, canExecuteMethod);
            SetLibraryFragment = new ActionCommand(setLibraryFragment, canExecuteMethod);
        }

        private bool canExecuteMethod(object parameter) => true;
        private void setCoursesContainterFragment(object parameter)
        {
            ViewModel = new CourseCardsContainerVM();
        }
        private void setBrowseOverviewFragment(object parameter)
        {
            ViewModel = new BrowseOverviewVM();
        }
        private void setCategoriesFragment(object parameter)
        {
            ViewModel = new CategoriesCardContainerVM();
        }
        private void setInstructorsFragment(object parameter)
        {
            ViewModel = new InstructorsCardContainerVM();
        }
        private void setSchoolsFragment(object parameter)
        {
            ViewModel = new SchoolsFragmentVM();
        }
        private void setLibraryFragment(object parameter)
        {
            ViewModel = new LibraryFragmentVM();
        }
    }
}
