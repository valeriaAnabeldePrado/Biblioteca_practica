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
    /// Lógica de interacción para ListarLector.xaml
    /// </summary>
    public partial class ListarLector : Window
    {
        public Biblioteca biblioteca;
        public ListarLector(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }
        private void ListarLector_Loaded(object sender, RoutedEventArgs e)
        {
            List<Lector> lista = biblioteca.getLectores();
            dgvListaLibros.ItemsSource = lista;
        }
        private void btnVolverListarLector_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCerrarListarLector_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
