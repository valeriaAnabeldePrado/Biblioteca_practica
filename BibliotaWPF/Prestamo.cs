using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotaWPF
{
    class Prestamo
    {
        private string lectorDni;
        private string libroNombre;

        public Prestamo()
        {
        }

        public Prestamo(string lectorDni, string libroNombre)
        {
            LectorDni = lectorDni;
            LibroNombre = libroNombre;
        }

        public string LectorDni { get => lectorDni; set => lectorDni = value; }
        public string LibroNombre { get => libroNombre; set => libroNombre = value; }
    }
}
