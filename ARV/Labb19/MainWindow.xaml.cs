using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
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

namespace Labb19
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Media> samling = new List<Media>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void KlickSparaBok(Object sender, RoutedEventArgs e)
        {
            int sidor = int.Parse(rutaSidor.Text);
            Bok boken = new Bok(rutaBoktitel.Text, rutaFörfattare.Text, sidor);

            //Man använder "Add" för att lägga till det i listbox.
            rutaResultat.Items.Add(boken.TillText());
            samling.Add(boken);

            // Skapa JSON från objekt
            string jsonBok = JsonConvert.SerializeObject(boken, Formatting.Indented);
            //spara i en json-fil
            File.WriteAllText("böcker.json", jsonBok);

            //rutaResultat.Items.Add($"({författare}, {sidor})");

        }
        private void KlickSparaFilm(Object sender, RoutedEventArgs e)
        {
            string regissör = rutaRegissör.Text;
            int längd = int.Parse(rutaLängd.Text);
            string titel = rutaFilmtitel.Text;
            Film filmen = new Film(titel, regissör, längd);


            rutaResultat.Items.Add(filmen.TillText());
            samling.Add(filmen);
            // Skapa JSON från objekt
            string jsonFilm = JsonConvert.SerializeObject(filmen, Formatting.Indented);
            //spara i en json-fil
            File.WriteAllText("böcker.json", jsonFilm);
        }
        private void KlickRadio(Object sender, RoutedEventArgs e)
        {
            //Töm listboxen
            rutaResultat.Items.Clear();
            //Vilken knapp? Läs av radioknappens namn.
            string radioKnapp = ((RadioButton)sender).Name;


            //Alternativ 2 
            foreach (var item in samling)
            {
                switch (radioKnapp)
                {
                    case "allt":
                        if (item is Media)
                        {
                            rutaResultat.Items.Add(item.TillText());
                        }
                        break;

                    case "böcker":

                        if (item is Bok)
                        {
                            rutaResultat.Items.Add(item.TillText());
                        }

                        break;

                    case "filmer":
                        if (item is Film)
                        {
                            rutaResultat.Items.Add(item.TillText());
                        }

                        break;
                }
            }
        }
        void StängFönster(object sender, CancelEventArgs e)
        {
            // Skriv ut JSON
            File.WriteAllText(@"filmer.json", jsonFilm);
            //loopa igenom json och spara det i samlingen
            //loopa igenom alla objekt i samlingen och lägg till dem i rutan
            foreach (var item in samling)
            {
                rutaResultat.Items.Add(item.TillText());
            }

            /*if (item is Bok)
                {
                    // Skapa JSON från objekt
                    string jsonBok = JsonConvert.SerializeObject(item, Formatting.Indented);
                    //spara i en json-fil
                    File.WriteAllText("böcker.json", jsonBok);
                }*/

        }

    }
}
