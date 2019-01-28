using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace model
{
    

    class Biblioteca
    {
        // Atributos
        private string nombre;
        private ArrayList libro;
        private int numeroLibros;


        // Constructor
        public Biblioteca(string nombre) {
            this.nombre = nombre;
            numeroLibros = 0;
            libro = new ArrayList();
        }
        
        public void guardar(string nombre, int peso, string autor, string fecha, string edicion) {
            // Creando el archivo
            StreamWriter escritura = File.CreateText("Libros");
            // Escribiendo el archivo y creación del archivo
            Libro temp = new Libro(nombre, peso, fecha, autor, edicion);
            escritura.WriteLine(temp.toString(), true);
            // Cerrar el archivo
            escritura.Close();
        }

        public void cargar(){
            // Leyendo los archivos
            TextReader leer = new StreamReader("Libros");
            
            string m = leer.ReadLine();

            while(m!="") {
                string[] temp = m.Split();
                string nombre = temp[0];
                int peso = int.Parse(temp[4]);
                string fecha = temp[3];
                string autor = temp[1];
                string edicion = temp[2];
                // Creación del objeto
                Libro a = new Libro(nombre, peso, fecha, autor, edicion);
                libro.Add(a);
                m = leer.ReadLine();
            }
            // Cerrar lectura
            leer.Close();
        }
        // Métodos

    }
}
