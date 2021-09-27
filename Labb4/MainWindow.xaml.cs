using System;
using System.IO;
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

namespace Labb4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] rader = new string[193];
        static int antal = 1;
        public MainWindow()
        {
            InitializeComponent();
            // Läs in alla rader från textfilen countries.csv
             rader = File.ReadAllLines("./Resurser/countries.csv");
        }
        private void ClickSök(object sender, RoutedEventArgs e)
    {
        
        //Läs in sökterm
        string sökterm = rutaSökterm.Text;

        //Hitta matchande länder 
         foreach (var rad in rader)
        {
            
            // Dela upp raden
            string[] delar = rad.Split(',');

            // Plocka ut land
            string land = delar[1];

            // Plocka ut landskod
            string landskod = delar[2];

            // Hitta land som innehåller sökterm se https://www.geeksforgeeks.org/c-sharp-string-contains-method/
            if (land.ToLower().Contains(sökterm.ToLower()))
            {
                // Skriv ut matchande land och dess landskod
                 rutaResultat.Text += $"{antal} {land}: {landskod} \n";
                 antal++;
            }
            
    }
            // Summering
        rutaStatus.Text = $"Hittade {antal-1} länder.";
}
 
}
}