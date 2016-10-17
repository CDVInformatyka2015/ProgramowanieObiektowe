using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wisielec.Views
{
    /// <summary>
    /// Interaction logic for getHasloDialog.xaml
    /// </summary>
    public partial class getHasloDialog : Window
    {
        private MainWindow _main;

        public getHasloDialog(MainWindow parent)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _main = parent;
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            _main.setHaslo(textBox.Text);
            _main.Show();
            _main.restartButton.Content = "Start";
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _main.Show();
        }
    }
}
