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

namespace BibliotaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Biblioteca biblioteca = new Biblioteca();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnCargarLibro_Click(object sender, RoutedEventArgs e)
        {
            CargarLibros iniciarCargaLibros = new CargarLibros(biblioteca);
            iniciarCargaLibros.Show();
          
        }

        private void btnListarLibro_Click(object sender, RoutedEventArgs e)
        {
            ListarLibro verListaLibros = new ListarLibro(biblioteca);
            verListaLibros.Show();  
        }

        private void btnAltaLector_Click(object sender, RoutedEventArgs e)
        {
            altaLector inicializarLectorNuevo = new altaLector(biblioteca);
            inicializarLectorNuevo.Show();
        }
        private void btnPrestar_Click(object sender, RoutedEventArgs e)
        {
            PedirPrestamo solicitarPrestamo = new PedirPrestamo(biblioteca);
            solicitarPrestamo.Show();
        }

        private void btnLectores_Click(object sender, RoutedEventArgs e)
        {
            ListarLector verListaLectores = new ListarLector(biblioteca);
            verListaLectores.Show();
        }
    }
}
