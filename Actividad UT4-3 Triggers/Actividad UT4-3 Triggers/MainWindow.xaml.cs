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

namespace Actividad_UT4_3_Triggers
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> ejemplos = Superheroe.GetSamples();

        public MainWindow()
        {
            InitializeComponent();
            int numero = ejemplos.Count;
            totalNumerador.Text = numero.ToString();

        }

        private void ArrowIzquierdo(object sender, RoutedEventArgs e)
        {
            if (numerador.Text == "1")
            {
                numerador.Text = "1";
            }
            else
            {
                int enumerador = int.Parse(numerador.Text);
                numerador.Text = (enumerador - 1).ToString();
            }
        }
        private void ArrowDerecho(object sender, RoutedEventArgs e)
        {
            if (numerador.Text == totalNumerador.Text)
            {
                numerador.Text = totalNumerador.Text;

            }
            else
            {
                int enumerador = int.Parse(numerador.Text);
                numerador.Text = (enumerador + 1).ToString();
            }
        }
        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {

            ejemplos.Add(new Superheroe(nombreNuevo.Text, imagenUrl.Text, heroe.IsChecked.Value, villano.IsChecked.Value, vengador.IsChecked.Value, xmen.IsChecked.Value));
            MessageBox.Show($"Nuevo heroe creado");

            int totalNumeradorInt = int.Parse(totalNumerador.Text);
            totalNumerador.Text = (totalNumeradorInt + 1).ToString();

        }
        private void numerador_TextChanged(object sender, TextChangedEventArgs e)
        {
            Superheroe x = ejemplos[int.Parse(numerador.Text) - 1];
            datosDockPanel.DataContext = x;

        }

    }
}

