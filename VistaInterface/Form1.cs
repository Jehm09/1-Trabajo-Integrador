using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaInterface
{
    public partial class Form1 : Form
    {
        private model.Biblioteca biblioteca;

        public Form1()
        {
            InitializeComponent();
            biblioteca = new Biblioteca("Biblioteca");
            biblioteca.cargar();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void lbAutor_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text)))
            {
                biblioteca.guardar(textBox1.Text, Int32.Parse(textBox5.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            }
        }

        private void btLibros_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2(biblioteca.Libro);
            f.Show();
        }
    }
}
