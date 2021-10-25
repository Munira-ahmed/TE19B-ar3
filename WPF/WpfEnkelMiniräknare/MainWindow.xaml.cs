using System;
using System.Windows;

namespace WpfEnkelMiniräknare
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

        private void knappPlusClick(Object sender, RoutedEventArgs e)
        {   //Flagga
            bool ärKorrektInmattat = true;

            //Töm resultat rutan
            resultatRuta.Text = ""; 

            float tal1 = 0;
            float tal2 = 0;
            //float tal1 = float.Parse(tal1Ruta.Text);
            //Försöker konvertera tal 1 till en float
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }      
          // float tal2 = float.Parse(tal2Ruta.Text);
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal2 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }    
            if(ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            } 

            
        }

        private void knappMinusClick(Object sender, RoutedEventArgs e)
        {
           //Flagga
            bool ärKorrektInmattat = true;

            //Töm resultat rutan
            resultatRuta.Text = ""; 

            float tal1 = 0;
            float tal2 = 0;
            //float tal1 = float.Parse(tal1Ruta.Text);
            //Försöker konvertera tal 1 till en float
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }      
          // float tal2 = float.Parse(tal2Ruta.Text);
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal2 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }    
            if(ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            } 
        }

        private void knappGångerClick(Object sender, RoutedEventArgs e)
        {
            //Flagga
            bool ärKorrektInmattat = true;

            //Töm resultat rutan
            resultatRuta.Text = ""; 

            float tal1 = 0;
            float tal2 = 0;
            //float tal1 = float.Parse(tal1Ruta.Text);
            //Försöker konvertera tal 1 till en float
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }      
          // float tal2 = float.Parse(tal2Ruta.Text);
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal2 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }    
            if(ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            } 
        }

        private void knappDivideraClick(Object sender, RoutedEventArgs e)
        {
            //Flagga
            bool ärKorrektInmattat = true;

            //Töm resultat rutan
            resultatRuta.Text = ""; 

            float tal1 = 0;
            float tal2 = 0;
            //float tal1 = float.Parse(tal1Ruta.Text);
            //Försöker konvertera tal 1 till en float
            if (!float.TryParse(tal1Ruta.Text, out tal1))
            {
                MessageBox.Show("Tal1 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }      
          // float tal2 = float.Parse(tal2Ruta.Text);
            if (!float.TryParse(tal2Ruta.Text, out tal2))
            {
                MessageBox.Show("Tal2 fel inmatning.\n Tex 2,5");
                ärKorrektInmattat = false;
              
            }    
            if(ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
            } 
        }
    }
}

