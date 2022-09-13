using System.Collections.Generic;
using System.Windows;

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
            Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<dynamic> cars = new List<dynamic>
            {
                new {CarName="A6",Color="White",Brand="Audi"},
                new {CarName="A7",Color="White1",Brand="Audi1"},
                new {CarName="A8",Color="White2",Brand="Audi2"},
            };

            dgCarList.ItemsSource = cars;
        }
    }
}
