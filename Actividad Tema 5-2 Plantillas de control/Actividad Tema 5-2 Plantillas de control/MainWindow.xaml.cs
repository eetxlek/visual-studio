﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Path = System.IO.Path;

namespace Actividad_Tema_5_2_Plantillas_de_control
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string rutaImagenes = @"C:\Users\eetxa\source\repos\Actividad Tema 5-2 Plantillas de control\Actividad Tema 5-2 Plantillas de control";
            InitializeComponent();

            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            listbox.DataContext = lista;

        }


        private void Listbox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;

            nombrePlato.Text = plato.Nombre;
            imagenPlato.Text = plato.Imagen;
            Tipo.SelectedItem = plato.Tipo;

            checkLeche.IsChecked = plato.Leche;
            checkGluten.IsChecked = plato.Gluten;
            checkSoja.IsChecked = plato.Soja;
            checkSulfitos.IsChecked = plato.Sulfitos;
        }

        private void CheckLeche_Unchecked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Leche = false;
        }

        private void CheckLeche_Checked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Leche = true;
        }

        private void CheckSoja_Checked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Soja = true;
        }

        private void CheckSoja_Unchecked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Soja = false;
        }

        private void CheckGluten_Checked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Gluten = true;
        }

        private void CheckGluten_Unchecked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Gluten = false;
        }

        private void CheckSulfitos_Checked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Sulfitos = true;
        }

        private void CheckSulfitos_Unchecked(object sender, RoutedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Sulfitos = false;
        }

        private void NombrePlato_TextChanged(object sender, TextChangedEventArgs e)
        {
            Plato plato = (Plato)listbox.SelectedItem;
            plato.Nombre = nombrePlato.Text;
        }
    }
}
    
