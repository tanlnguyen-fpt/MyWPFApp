using System.Windows;

namespace MyWPFApp
{
    /// <summary>
    /// Interaction logic for DemoCanvasPanel.xaml
    /// </summary>
    public partial class DemoCanvasPanel : Window
    {
        public DemoCanvasPanel()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string carInfo = $"Car name: {txtCarName.Text}\nColor: {txtColor.Text}\nBrand: {txtBrand.Text}";
            MessageBox.Show(carInfo, "Car detail");
        }
    }
}
