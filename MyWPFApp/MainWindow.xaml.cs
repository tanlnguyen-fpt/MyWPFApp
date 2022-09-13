using System.Windows;
using System.Windows.Controls;

namespace MyWPFApp
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

        private void cbBoxColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stackPanel = (StackPanel)cbBoxColor.SelectedItem;
            var lable = stackPanel.Children[1] as Label;
            string color = lable.Content.ToString();
            lbMsg.Content = "Your color is " + color;
        }
    }
}
