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
using System.Windows.Shapes;


namespace BibliotaWPF
{
    /// <summary>
    /// Lógica de interacción para CargarLibros.xaml
    /// </summary>
    public partial class CargarLibros : Window
    {

        private Biblioteca biblioteca;
        public CargarLibros(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAgregarLibro_Click(object sender, RoutedEventArgs e)
        {
            String nombre = txbNombreLibro.Text.Trim();
            String autor = txbAutorLibro.Text.Trim();   
            String editorial = txbEditorialLibro.Text.Trim();

            bool status = biblioteca.agregarLibro(nombre, autor, editorial);
            if (status)
            {
                MessageBox.Show("Se cargó el libro correctamente", "LIBRO", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Ups! Este libro ya existe", "LIBRO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
    }

        private void txbNombreLibro_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txbNombreLibro.Text == "Titulo")
            {
                txbNombreLibro.Text = "";
            }
        }

        private void txbAutorLibro_GotFocus(object sender, RoutedEventArgs e)
        {
            if(txbAutorLibro.Text == "Autor")
            {
                txbAutorLibro.Text = "";
            }
        }

        private void txbEditorialLibro_GotFocus(object sender, RoutedEventArgs e)
        {
            if(txbEditorialLibro.Text == "Editorial")
            {
                txbEditorialLibro.Text = "";
            }
        }
    }
}
