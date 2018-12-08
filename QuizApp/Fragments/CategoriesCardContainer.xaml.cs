using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for CategoriesCardContainer.xaml
    /// </summary>
    public partial class CategoriesCardContainer : UserControl
    {
        public CategoriesCardContainer()
        {
            InitializeComponent();
            DataContext = new CategoriesCardContainerVM();
        }
    }
}
