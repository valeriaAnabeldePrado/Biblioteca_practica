using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ver si falta el de system viejo o no

namespace BibliotaWPF
{

    public class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        public List<Libro> getLibros()
        {
            return libros;
        }

        public List<Lector> getLectores()
        {
            return lectores;
        }

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

        public bool agregarLibro(string nombre, string autor, string editorial)
        {
            bool resp = false;
            Libro l = buscarLibro(nombre);

            if (l == null)
            {

                l = new Libro(nombre, autor, editorial);
                libros.Add(l);
                resp = true;
            }
            return resp;
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

        public Lector buscarLector(string dni)
        {

            Lector l = null;
            int i = 0;
            while (i < lectores.Count)
            {

                if (lectores[i].Dni.Equals(dni))
                {
                    l = lectores[i];
                    i = lectores.Count;
                }
                i++;
            }
            return l;
        }

        public bool altaLector(string nombre, string apellido, string dni)
        {
            bool resp = false;
            Lector l = buscarLector(dni);

            if (l == null)
            {

                l = new Lector(nombre, apellido, dni);
                lectores.Add(l);
                resp = true;
            }
            return resp;
        }

        public bool eliminarLector(string dni)
        {
            bool resp = false;
            Lector l = buscarLector(dni);
            if (l != null)
            {
                lectores.Remove(l);
                resp = true;
            }
            return resp;
        }

    }
}
