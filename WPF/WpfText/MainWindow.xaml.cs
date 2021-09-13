﻿using System;
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

namespace WpfText
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
        // Läs in texten från formuläret
        string text = inText.Text;

        // Gammal kod
        string omvändText = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            omvändText += text[i];
        }
        resultatRuta.Text = omvändText;
    }
}
 }

