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

namespace Uppgift6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public float summa = 0;
        public int antalClick = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void knappAdderaClick(object sender, RoutedEventArgs e){
           
            //Variabel för input, läs in text
            float tal = 0;
            if (!float.TryParse(talRuta.Text, out tal))
            {
                MessageBox.Show("fel inmatning.\n formatet tex 2,5");
              
            }else
            {
                 antalClick++;
                summaRuta.Text = $"{summa} + {tal} = {summa+tal}";
               //spara till nästa gng
                summa = summa+tal;
           
             
               //skriv ut medelvärdet
                medelRuta.Text = $"{summa}/{antalClick} = {summa/antalClick}";
                //töm tal rutan
                talRuta.Text="";
            }       
            
    }
    
   }
}
    