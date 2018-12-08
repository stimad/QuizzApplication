using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for InstructorsCardContainer.xaml
    /// </summary>
    public partial class InstructorsCardContainer : UserControl
    {
        public InstructorsCardContainer()
        {
            InitializeComponent();
            DataContext = new InstructorsCardContainerVM();
        }
    }
}
