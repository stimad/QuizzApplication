using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for InstructorExpandedFragment.xaml
    /// </summary>
    public partial class InstructorExpandedFragment : UserControl
    {
        public InstructorExpandedFragment()
        {
            InitializeComponent();
            DataContext = new InstructorExpandedFragmentVM();
        }
    }
}
