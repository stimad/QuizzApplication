using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for InstructorsCardContainer.xaml
    /// </summary>
    public partial class InstructorsCardContainer : UserControl
    {
        InstructorsCardContainerVM vm;
        public InstructorsCardContainer()
        {
            InitializeComponent();
            vm = new InstructorsCardContainerVM();
            DataContext = vm;
        }

        private void Butt_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            vm.ContentVisibility = System.Windows.Visibility.Collapsed;
            vm.ViewModel = new InstructorExpandedFragmentVM();
        }
    }
}
