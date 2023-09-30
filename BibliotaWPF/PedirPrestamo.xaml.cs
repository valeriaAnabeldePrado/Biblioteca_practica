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
    /// Lógica de interacción para PedirPrestamo.xaml
    /// </summary>
    public partial class PedirPrestamo : Window
    {
        public Biblioteca biblioteca;
        private List<Prestamo> prestamos = new List<Prestamo>();
        public PedirPrestamo(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void CargarTabla()
        {
            foreach (Prestamo p in prestamos)
            {
            dgvListarPrestamos.ItemsSource = prestamos;
                
            }
          
        }

        private void PedirPrestamo_Loaded(object sender, RoutedEventArgs e)
        {
            List<Lector> lectores = biblioteca.getLectores();

            foreach (Lector lector in lectores)
            {
                foreach (Libro libro in lector.Libros)
                {
                    prestamos.Add(new Prestamo(lector.Dni, libro.getTitulo()));
                }
            }

            //dgvListarPrestamos.ItemsSource.RowHeadersVisible = false;
            CargarTabla();
        }
        private void btnPedirLibro_Click(object sender, RoutedEventArgs e)
        {
            Libro libro = biblioteca.buscarLibro(txbTitulo.Text);
            Lector lector = biblioteca.buscarLector(txbDni.Text);
            if (libro != null && lector != null)
            {
                lector.Libros.Add(libro);
                biblioteca.eliminarLibro(libro.getTitulo());
                prestamos.Add(new Prestamo(lector.Dni, libro.getTitulo()));
                CargarTabla();
                MessageBox.Show("Se realizó el prestamo correctamente", "PRESTAMO", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Ups! no se pudo realizar el prestamo", "PRESTAMO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LimpiarDataGrid()
        {
            dgvListarPrestamos.ItemsSource = null;
        }
        private void btnDevolver_Click(object sender, RoutedEventArgs e)
        {
            Lector lector = biblioteca.buscarLector(txbDni.Text);
            if (lector != null)
            {
                Libro libro = lector.buscarLibro(txbTitulo.Text);
                if (libro != null)
                {

                    biblioteca.agregarLibro(libro.Nombre, libro.Autor, libro.Editorial);
                    lector.eliminarLibro(libro.Nombre);
                    prestamos.RemoveAll(prestamo => prestamo.LibroNombre == libro.Nombre);
                    prestamos.RemoveAll(prestamo => prestamo.LectorDni == lector.Dni);
                    LimpiarDataGrid();
                    CargarTabla();
                    MessageBox.Show("Se devolvió libro correctamente", "DEVOLUCIÓN", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                {
                    MessageBox.Show("Ups! libro incorrecto", "DEVOLUCIÓN", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Ups! lector incorrecto", "DEVOLUCIÓN", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCerrarPrestamo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    
}
