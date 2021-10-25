using System;
using System.Collections.Generic;
using System.IO;
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

namespace Listor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global lista
        List<string> namnLista = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ClickLäggTill(object sender, RoutedEventArgs e)
        {
            
            //Läs av rutaNamn
            string namn = rutaNamn.Text;

            //Om rutaNamn ej tom
            //Lägg till rutaLista
            //och Lagra i en lista
            if (namn != "")
            {
                rutaLista.Text += $"{namn} \n";
                namnLista.Add(namn);
            }else
            {
                rutaFel.Text = "Namn är tomt!";
            }

            rutaNamn.Text = "";
        }
          private void ClickSpara(object sender, RoutedEventArgs e)
          {
              File.WriteAllLines("namnLista.txt", namnLista);
              rutaFel.Text = "Namnen sparade i namnLista.txt!";
          }
    }
}
