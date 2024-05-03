using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LetterCaseChanger.Controls;

namespace LetterCaseChanger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == string.Empty)
            {
                var notification = new Notification("The text field cannot be empty", Brushes.Red);
                notification.Margin = new Thickness(5,-90,0,-100);
                notification.Style = (Style)FindResource("Notification");
                MyPanel.Children.Add(notification);

                return;
            }

            if (ToUpperCase.IsChecked == true)
            {
                Clipboard.SetText(TextBox.Text.ToUpper());
                var notification = new Notification("The text was successfully converted to uppercase and copied to the clipboard", Brushes.Lime);
                notification.Margin = new Thickness(5,-90,0,-100);
                notification.Style = (Style)FindResource("Notification");
                MyPanel.Children.Add(notification);
                return;
                
            }
            if (ToLowerCase.IsChecked == true)
            {
                Clipboard.SetText(TextBox.Text.ToLower());
                var notification = new Notification("The text was successfully converted to lowercase and copied to the clipboard", Brushes.Lime);
                notification.Margin = new Thickness(5,-90,0,-100);
                notification.Style = (Style)FindResource("Notification");
                MyPanel.Children.Add(notification);
                return;
            }

        }
        
    }
}