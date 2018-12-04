using System.Windows;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for SecondSignUp.xaml
    /// </summary>
    public partial class SecondSignUp : Window
    {
        public SecondSignUp()
        {
            InitializeComponent();
            Title.Text = $" Hi {Constants.USERNAME}, Welcome to MyAjarn. Please Create Your Profile";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
