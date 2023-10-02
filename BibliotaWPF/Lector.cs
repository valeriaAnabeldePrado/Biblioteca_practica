using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotaWPF
{
    public class Lector
    {
        private string nombre;
        private string apellido;
        private string dni;
        private List<Libro> libros;

        public Lector()
        {
        }

        public Lector(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Libros = new List<Libro>();
        }

        public Lector(string nombre, string apellido, string dni, List<Libro> libros)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Libros = libros;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public List<Libro> Libros { get => libros; set => libros = value; }

        public Libro buscarLibro(string nombre)
        {

            Libro? l = null;
            int i = 0;
            while (i < libros.Count)
            {

                if (libros[i].getTitulo().Equals(nombre))
                {
                    l = libros[i];
                    i = libros.Count;
                }
                i++;
            }
            return l;
        }

        public bool eliminarLibro(string nombre)
        {
            bool resp = false;
            Libro l = buscarLibro(nombre);
            if (l != null)
            {
                libros.Remove(l);
                resp = true;
            }
            return resp;
        }
    }
}
