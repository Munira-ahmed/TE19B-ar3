using System;
using System.IO;
using System.Windows;


namespace Labb4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] rader = new string[193];
        public MainWindow()
        {
            //skapar fönstret och ritar ut elementen
            InitializeComponent();
          
        }
        /// <summary>
        /// Det som händer när användaren trycker på sök
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickSök(object sender, RoutedEventArgs e)
    {
         int antal = 1; 
        rutaResultat.Text = "";

          // Läs in alla rader från textfilen countries.csv
          rader = File.ReadAllLines("./Resurser/countries.csv");

        //Läs in sökterm
         string sökterm = rutaSökterm.Text;   

         if (sökterm != "")
         {
              //Hitta matchande länder 
       //  foreach (var rad in rader)
       for (int i = 1; i < rader.Length; i++)    
        {    
                 
            // Dela upp raden
            string[] delar = rader[i].Split(',');

            // Plocka ut land
            string land = delar[1];

            // Plocka ut landskod
            string landskod = delar[2];

                 // Hitta land som innehåller sökterm
            if (land.ToLower().Contains(sökterm.ToLower()))
            {
                // Skriv ut matchande land och dess landskod

                 rutaResultat.Text += $" {antal} {land}: {landskod} \n";
                 antal++;
                   // Summering
                 rutaStatus.Text = $"Hittade {antal-1} länder.";            
            }          
          } 
            rutaSökterm.Text = "";  
           } else
            {
              rutaStatus.Text = "Ange en sökterm med bokstäver.";
               sökterm = "";
            }          
    }
 
}
}