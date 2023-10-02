using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotaWPF
{
    public class Libro
    {
        private string nombre;
        private string autor;
        private string editorial;
        public Libro(string nombre, string autor, string editorial)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.editorial = editorial;
        }
        public string getTitulo()
        {
            return Nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }


        public override string ToString()
        {
            return $"El nombre del libro es {nombre}, su autor es {autor} y su editorial es {editorial}";
        }
    }
}
