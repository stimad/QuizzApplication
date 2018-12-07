using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for BrowseFragment.xaml
    /// </summary>
    public partial class BrowseFragment : UserControl
    {

        Grid lastClickedHomeTab;
        Button previousTabButton;
        BrowseFragmentVM mBrowseFragmentVM;
        public BrowseFragment()
        {
            InitializeComponent();
            mBrowseFragmentVM = new BrowseFragmentVM();
            mBrowseFragmentVM.ViewModel = new BrowseOverviewVM();
            DataContext = mBrowseFragmentVM;
            
            lastClickedHomeTab = tabUnderliner0;
            previousTabButton = overviewTabButton;
        }

        private void tabButton_Clicked(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonIndex = int.Parse(clickedButton.Uid);
            lastClickedHomeTab.Visibility = Visibility.Collapsed;
            previousTabButton.Foreground = Brushes.Gray;
            clickedButton.Foreground = (Brush)new BrushConverter().ConvertFrom("#2D3F50");
            previousTabButton = clickedButton;
            switch (buttonIndex)
            {
                case 0:
                    tabUnderliner0.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner0;
                    break;
                case 1:
                    tabUnderliner1.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner1;
                    break;
                case 2:
                    tabUnderliner2.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner2;
                    break;
                case 3:
                    tabUnderliner3.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner3;
                    break;
                case 4:
                    tabUnderliner4.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner4;
                    break;
                case 5:
                    tabUnderliner5.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner5;
                    break;
                case 6:
                    tabUnderliner6.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner6;
                    break;
                default:
                    tabUnderliner0.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner0;
                    break;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
