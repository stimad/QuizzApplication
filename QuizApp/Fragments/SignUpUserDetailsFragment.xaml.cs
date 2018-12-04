using System.Windows;
using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for SignUpUserDetailsFragment.xaml
    /// </summary>
    public partial class SignUpUserDetailsFragment : UserControl
    {
        SecondSignUp parentWindow;

        public SignUpUserDetailsFragment()
        {
            InitializeComponent();
        }
        public SignUpUserDetailsFragment(SecondSignUp parentWindow)
        {
            InitializeComponent();
            this.parentWindow = parentWindow;
        }

        private void teacherSingUP_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Grid parentGrid = (Grid)this.Parent;
            parentGrid.Children.Remove(this);
            InstructorPlanFragmentVM mInstructorPlanFragmentVM = new InstructorPlanFragmentVM()
            {
                //TODO get instructor offers from internet
                InstructorCost = "$149/month",
                BusinessCost = "$599/month",
                TrainingCenterCost = "$299/month"
            };
            parentGrid.Children.Add(new InstructorPlanFragment(mInstructorPlanFragmentVM));
        }

        private void studentSignUp_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Window.GetWindow(this).Close();
            main.Show();
        }
    }
}
