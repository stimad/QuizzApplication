using System.Windows;
using QuizApp.DataModels;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for LoginSreen.xaml
    /// </summary>
    public partial class LoginSreen : Window
    {
        public LoginSreen()
        {
            InitializeComponent();
        }

        private void closeButton_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpLayout.Visibility = Visibility.Visible;
            LoginLayout.Visibility = Visibility.Collapsed;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginLayout.Visibility = Visibility.Visible;
            SignUpLayout.Visibility = Visibility.Collapsed;
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Password))
            {
                warningLoginMessage.Visibility = Visibility.Visible;
                return;
            }
            LoginDataModel loginData = new LoginDataModel()
            {
                Username = usernameTextBox.Text,
                Password = passwordTextBox.Password
            };
            ResponseDataModel response = await Constants.sendPostRequest<ResponseDataModel>(Constants.BASE_URL + "/user", loginData);
            if (response == null || response.Response == null || !response.Response.ToLower().Equals("ok"))
            {
                MessageBox.Show("Check internet connection. Server problem.");
                return;
            }
            Constants.LoginData = loginData;
            swithcWindow();
        }

        private void SingUp_Clicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(nameOfUser.Text) || string.IsNullOrEmpty(countryOfUser.Text) ||
                string.IsNullOrEmpty(passwordOfUser.Password) || string.IsNullOrEmpty(emailOfUser.Text) ||
                agreePrivacyPolicy.IsChecked == false)
            {
                signUpWarrningMessage.Visibility = Visibility.Visible;
                return;
            }
            Constants.USERNAME = nameOfUser.Text;
            SecondSignUp mSecondSignUp = new SecondSignUp();
            mSecondSignUp.Show();
            Close();
        }
        private void swithcWindow()
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
