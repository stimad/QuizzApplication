using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for InstructorPlanFragment.xaml
    /// </summary>
    public partial class InstructorPlanFragment : UserControl
    {
        public InstructorPlanFragment(InstructorPlanFragmentVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
