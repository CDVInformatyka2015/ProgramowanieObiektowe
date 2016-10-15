using System.Windows;

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //System.Threading.Thread.Sleep(5000);
            MessageBox.Show("SYSTEM ERROR!", "Error!");
        }
    }
}
