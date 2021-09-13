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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCeasar
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
        private void Click_OK(Object sender, RoutedEventArgs e)
        {
            string input = rutaTexten.Text;
            int nyckel = 0;
           
            if (!int.TryParse( rutaNyckel.Text, out nyckel))
            {
                MessageBox.Show("Du måste mata in ett tal (1-9). Försök igen: ");
            }else
            {
                string krypteradText = "";
            for (int i = 0; i < input.Length; i++)
            {
                char bokstav = input[i];
                int ascii = (int)bokstav;

                int kryptadAscii = ascii + nyckel;
                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);

                krypteradText += kryptadBokstav.ToString();

                rutaKryptoText.Text = krypteradText;
            }

            
           }
        }
    }
    
}
