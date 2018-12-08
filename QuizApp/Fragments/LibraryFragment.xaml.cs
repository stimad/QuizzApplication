using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for LibraryFragment.xaml
    /// </summary>
    public partial class LibraryFragment : UserControl
    {
        public LibraryFragment()
        {
            InitializeComponent();
            DataContext = new LibraryFragmentVM();
        }
    }
}
