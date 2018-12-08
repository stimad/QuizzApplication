using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for CourseCardsGridFragment.xaml
    /// </summary>
    public partial class CourseCardsGridFragment : UserControl
    {

        public CourseCardsGridFragment()
        {
            InitializeComponent();
            DataContext = new CourseCardGridVM();
        }

        public event EventHandler ClickCommand;

        private void FunctionThatRaisesEvent()
        {
            //Null check makes sure the main page is attached to the event
            if (this.ClickCommand != null)
                this.ClickCommand(this, new EventArgs());
        }

        private void Butt_Click(object sender, RoutedEventArgs e)
        {
            FunctionThatRaisesEvent();
        }
    }
}
