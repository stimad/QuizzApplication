using System.Collections.ObjectModel;

namespace QuizApp
{
    public class CategoriesCardGridVM:BaseViewModel
    {
        public ObservableCollection<CategoriesCardVM> Categories { get; set; }

    }
}
