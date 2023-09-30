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
    /// Lógica de interacción para ListarLibro.xaml
    /// </summary>
    public partial class ListarLibro : Window
    {
        public Biblioteca biblioteca;
        public ListarLibro(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void ListarLibro_Loaded(object sender, RoutedEventArgs e)
        {
            List<Libro> lista = biblioteca.getLibros();
            dgvListaLibros.ItemsSource = lista;
        }

        private void btnCerrarLista_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
