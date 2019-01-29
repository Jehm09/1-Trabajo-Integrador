using model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaInterface {
    public partial class Form2 : Form {
        public Form2(List<Libro> libro) {
            InitializeComponent();

            for (int i = 0; i < libro.Count; i++) {
                Libro l = libro[i];
                ListViewItem lista = new ListViewItem(l.Nombre);
                lista.SubItems.Add(l.Autor);
                lista.SubItems.Add(l.Fecha);
                lista.SubItems.Add(l.Edicion);
                lista.SubItems.Add(l.Peso+"");
                listView1.Items.Add(lista);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form2_Load(object sender, EventArgs e) {

        }
    }
}
