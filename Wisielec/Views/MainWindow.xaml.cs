namespace Wisielec.Views
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Windows;
    using ViewModels;

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        private readonly MainWindowVm mainWindowVm;
        private static byte _szanseCounter = 11;
        private static string _haslo = null;
        private static string[] _hasloArray;
        private static string[] _hasloEncoded;
        private bool runned = false;

        public MainWindow(MainWindowVm mainWindowVm)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.mainWindowVm = mainWindowVm;

            DataContext = mainWindowVm;
            Closing += (sender, e) => { Dispose(); };
            InitializeComponent();
        }

        public void Dispose()
        {
            mainWindowVm.Dispose();
        }

        public void setHaslo(string haslo)
        {
            _haslo = haslo;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            if (_haslo != null & _szanseCounter > 1)
            {
                restartButton.Content = "Restart";
                textBox.IsEnabled = true;
                sendClick.IsEnabled = true;
                startGame();
            }
            else
            {
                this.Hide();
                getHasloDialog dialog = new getHasloDialog(this);
                dialog.Show();
            }
        }

        private void startGame()
        {
            wisielec.Text = "";
            _szanseCounter = 11;
            _hasloArray = splitHaslo(_haslo);
            _hasloEncoded = encodeHaslo(_hasloArray);
            writeInfo();
        }

        private void checkTrue(string text)
        {
            bool yay = false;
            for (int i = 0; i < _hasloArray.Length; i++)
            {
                if (text == _hasloArray[i])
                {
                    _hasloEncoded[i] = _hasloArray[i];
                    yay = true;
                }
            }
            string test = "", test2 = "";
            for (int i = 0; i < _hasloArray.Length; i++)
            {
                test += _hasloEncoded[i];
                test2 += _hasloArray[i];
            }
            writeInfo(yay);
        }

        private void writeInfo(bool status = false)
        {
            if (Enumerable.SequenceEqual(_hasloArray, _hasloEncoded))
            {
                hasloTitle.Text = "Gratulacje! Hasło to: " + _haslo;
                renderWisielec(_szanseCounter);
                endGame();
            }
            if (!status)
            {
                if (_szanseCounter <= 1)
                {
                    endGame();
                }
                _szanseCounter--;
            }
            szanse_counter.Text = _szanseCounter.ToString();
            hasloTitle.Text = "";
            foreach (var item in _hasloEncoded)
            {
                hasloTitle.Text += item + " ";
            }
            renderWisielec(_szanseCounter);
        }

        private void endGame()
        {
            if (_szanseCounter <= 1)
            {
                MessageBox.Show("Koniec gry! Przegrałeś/aś\nHasło to: " + _haslo, "Przegrałeś!");
            } else
            {
                MessageBox.Show("Koniec gry! Wygrałeś/aś\nHasło to: " + _haslo, "Wygrałęś!");
            }
            MainWindow main = new MainWindow(mainWindowVm);
            main.Show();
            this.Close();
            hasloTitle.Text = "Przegrałeś!";
            renderWisielec(0);
            textBox.IsEnabled = false;
            sendClick.IsEnabled = false;
            _szanseCounter = 11;
            _haslo = null;
        }

        private void renderWisielec(byte _szanseCounter)
        {
            switch (_szanseCounter)
            {
                case 0: wisielec.Text = " _______\n |     |\n |     O\n |    /|\\\n |    / \\\n/|\\"; break;
                case 1: wisielec.Text = " _______\n |     |\n |     O\n |    /|\\\n |    /\n/|\\"; break;
                case 2: wisielec.Text = " _______\n |     |\n |     O\n |    /|\\\n |\n/|\\"; break;
                case 3: wisielec.Text = " _______\n |     |\n |     O\n |    /|\n |\n/|\\"; break;
                case 4: wisielec.Text = " _______\n |     |\n |     O\n |     |\n |\n/|\\"; break;
                case 5: wisielec.Text = " _______\n |     |\n |     O\n |\n |\n/|\\"; break;
                case 6: wisielec.Text = " _______\n |     |\n |\n |\n |\n/|\\"; break;
                case 7: wisielec.Text = " _______\n |\n |\n |\n |\n/|\\"; break;
                case 8: wisielec.Text = "\n |\n |\n |\n |\n/|\\"; break;
                case 9: wisielec.Text = "\n\n\n\n\n/|\\"; break;
                case 10: wisielec.Text = "\n\n\n\n\n"; break;
            }
        }

        private static string[] encodeHaslo(string[] hasloArray)
        {
            string[] enc = new string[hasloArray.Count()];
            Array.Copy(hasloArray, enc, hasloArray.Count());
            for (int i = 0; i < hasloArray.Count(); i++)
            {
                enc[i] = "_";
                if (_hasloArray[i]==" ")
                {
                    enc[i] = " ";
                }
            }
            return enc;
        }

        private static string[] splitHaslo(string haslo)
        {
            return haslo.ToCharArray().Select(c => c.ToString()).ToArray();
        }

        private void sendClick_Click(object sender, RoutedEventArgs e)
        {
            if (!runned)
            {
                checkTrue(textBox.Text);
            }
            textBox.Text = null;
        }

        private void isTextValidation(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
