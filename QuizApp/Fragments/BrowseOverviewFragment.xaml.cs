using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for BrowseOverviewFragment.xaml
    /// </summary>
    public partial class BrowseOverviewFragment : UserControl
    {
        BrowseOverviewVM mBrowseOverviewVM;
        public BrowseOverviewFragment()
        {
            InitializeComponent();
            mBrowseOverviewVM = new BrowseOverviewVM();
            DataContext = mBrowseOverviewVM;
        }

        private  async void StackPanel_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            await mBrowseOverviewVM.populateFeaturedCourses();
            await mBrowseOverviewVM.populateTopCategories();
            await mBrowseOverviewVM.populateTopInstructorsGrid();
        }
    }
}
