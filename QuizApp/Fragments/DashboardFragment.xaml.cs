using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for DashboardFragment.xaml
    /// </summary>
    public partial class DashboardFragment : UserControl
    {
        public DashboardFragment()
        {
            InitializeComponent();
            DataContext = new DashboardFragmentVM();
        }
    }
}
