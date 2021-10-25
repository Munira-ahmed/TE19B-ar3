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

namespace WpfLabb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Skriv ut en varning
            rutaMeddelande.Text = "Servern är nere!";
            //lägg till text i TextBox#2
           // textruta.Text = "Här ska det stå grejer";
        }

        private void Click_OK(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(rutaText.Text);

            //En variabel för innehållet i inputrutan
            string texten = "";
           
            //Läs in texten från inputrutan
           texten = rutaText.Text;

            //skriv ut det i textrutan
            rutaMeddelande.Text += texten + "\n";

            rutaText.Text = "";
        }
    }
}
