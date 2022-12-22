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

namespace Ejercicio13
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MostrarGrid();
        }
        public void MostrarGrid()
        {
            Grid Grid = new Grid();
            ColumnDefinition gridcol0 = new ColumnDefinition();
            Grid.ColumnDefinitions.Add(gridcol0);
            ColumnDefinition gridcol1 = new ColumnDefinition();
            Grid.ColumnDefinitions.Add(gridcol1);
            ColumnDefinition gridcol2 = new ColumnDefinition();
            Grid.ColumnDefinitions.Add(gridcol2);
            RowDefinition gridrow0 = new RowDefinition();
            Grid.RowDefinitions.Add(gridrow0);
            RowDefinition gridrow1 = new RowDefinition();
            Grid.RowDefinitions.Add(gridrow1);
            RowDefinition gridrow2 = new RowDefinition();
            Grid.RowDefinitions.Add(gridrow2);
            RowDefinition gridrow3 = new RowDefinition();
            Grid.RowDefinitions.Add(gridrow3);
            RowDefinition gridrow4 = new RowDefinition();
            Grid.RowDefinitions.Add(gridrow4);

            TextBox pantalla = new TextBox();
            pantalla.Name = "pantalla";
            pantalla.Height = 10;
            pantalla.Width = 10;
            pantalla.Text = "";
            pantalla.FontWeight = FontWeights.Bold;
            Grid.SetRow(pantalla, 0);
            Grid.SetColumn(pantalla, 3);
            Grid.Children.Add(pantalla);

            Button uno = new Button();
            uno.Content = 1;
            uno.FontSize = 20;
            Grid.SetRow(uno, 1);
            Grid.SetColumn(uno, 0);
            Grid.Children.Add(uno);

            Button dos = new Button();
            dos.Content = 2;
            dos.FontSize = 20;
            Grid.SetRow(dos, 1);
            Grid.SetColumn(dos, 1);
            Grid.Children.Add(dos);

            Button tres = new Button();
            tres.Content = 3;
            tres.FontSize = 20;
            Grid.SetRow(tres, 1);
            Grid.SetColumn(tres, 3);
            Grid.Children.Add(tres);

            Button cuatro = new Button();
            cuatro.Content = 4;
            cuatro.FontSize = 20;
            Grid.SetRow(cuatro, 2);
            Grid.SetColumn(cuatro, 0);
            Grid.Children.Add(cuatro);

            Button cinco = new Button();
            cinco.Content = 5;
            cinco.FontSize = 20;
            Grid.SetRow(cinco, 2);
            Grid.SetColumn(cinco, 1);
            Grid.Children.Add(cinco);

            Button seis = new Button();
            seis.Content = 6;
            seis.FontSize = 20;
            Grid.SetRow(seis, 2);
            Grid.SetColumn(seis, 2);
            Grid.Children.Add(seis);

            Button siete = new Button();
            siete.Content = 7;
            siete.FontSize = 20;
            Grid.SetRow(siete, 3);
            Grid.SetColumn(seis, 0);
            Grid.Children.Add(siete);

            Button ocho = new Button();
            ocho.Content = 8;
            ocho.FontSize = 20;
            Grid.SetRow(ocho, 3);
            Grid.SetColumn(ocho, 1);
            Grid.Children.Add(ocho);

            Button nueve = new Button();
            nueve.Content = 9;
            nueve.FontSize = 20;
            Grid.SetRow(nueve, 3);
            Grid.SetColumn(nueve, 2);
            Grid.Children.Add(nueve);

            Button cero = new Button();
            cero.Content = 0;
            cero.FontSize = 20;
            Grid.SetRow(cero, 4);
            Grid.SetColumn(cero, 1);
            Grid.Children.Add(cero);

        }
           
        }

       
    }

