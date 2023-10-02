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
    /// Lógica de interacción para altaLector.xaml
    /// </summary>
    public partial class altaLector : Window
    {
        public Biblioteca biblioteca;
        public altaLector(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnAgregarLector_Click(object sender, RoutedEventArgs e)
        {
            String nombre = txbNombreDelLector.Text.Trim();
            String apellido = txbApellidoLector.Text.Trim();    
            String dni = txbDni.Text.Trim();

            bool status = biblioteca.altaLector(nombre, apellido, dni);
            if (status)
            {
                MessageBox.Show("Se cargó el lector correctamente", "LECTOR", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Ups! Este lector ya existe", "LECTOR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
