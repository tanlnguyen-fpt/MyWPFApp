using System.Text;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new();
            foreach (CheckBox item in lst.Items)
            {
                if (item.IsChecked == true)
                {
                    sb.Append(item.Content + " is checked");
                    sb.Append("\r\n");
                }
            }

            txtSelection.Text = sb.ToString();
        }
    }
}
