using System.Windows;
using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for BaseCustomControl.xaml
    /// </summary>
    public partial class BaseCustomControl : UserControl
    {
        public BaseCustomControl()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent MyCustomEvent = EventManager.RegisterRoutedEvent(
       "MyCustom", // Event name
       RoutingStrategy.Bubble, // Bubble means the event will bubble up through the tree
       typeof(RoutedEventHandler), // The event type
       typeof(BaseCustomControl)); // Belongs to ChildControlBase

        // Allows add and remove of event handlers to handle the custom event
        public event RoutedEventHandler MyCustom
        {
            add { AddHandler(MyCustomEvent, value); }
            remove { RemoveHandler(MyCustomEvent, value); }
        }
    }
}
