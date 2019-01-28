using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{ 

    class Libro
    {
        // Atributos
        private string nombre;
        private int peso;
        private string fecha;
        private string autor;
        private string edicion;

        // Constructor
        public Libro(string nombre, int peso, string fecha, string autor, string edicion) {
            this.nombre = nombre;
            this.peso = peso;
            this.fecha = fecha;
            this.autor = autor;
            this.edicion = edicion;
        }

        // Métodos
        public string Nombre { get => nombre; set => nombre = value; }
        public int Peso { get => peso; set => peso = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Edicion { get => edicion; set => edicion = value; }

        public string toString() {
            return nombre + "," + autor + "," + edicion + "," + fecha + "," + peso;
        }

    }
}
