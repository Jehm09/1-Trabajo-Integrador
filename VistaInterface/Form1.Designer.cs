namespace VistaInterface
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbEdicion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbPeso = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbRegistroLibro = new System.Windows.Forms.Label();
            this.btLibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(49, 280);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(107, 32);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(45, 94);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(68, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Click += new System.EventHandler(this.lbNombre_Click);
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(45, 125);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(49, 20);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Autor";
            this.lbAutor.Click += new System.EventHandler(this.lbAutor_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(45, 155);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(55, 20);
            this.lbFecha.TabIndex = 3;
            this.lbFecha.Text = "Fecha";
            // 
            // lbEdicion
            // 
            this.lbEdicion.AutoSize = true;
            this.lbEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdicion.Location = new System.Drawing.Point(45, 184);
            this.lbEdicion.Name = "lbEdicion";
            this.lbEdicion.Size = new System.Drawing.Size(64, 20);
            this.lbEdicion.TabIndex = 4;
            this.lbEdicion.Text = "Edición";
            this.lbEdicion.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(223, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.Location = new System.Drawing.Point(47, 213);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(47, 20);
            this.lbPeso.TabIndex = 9;
            this.lbPeso.Text = "Peso";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(223, 215);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // lbRegistroLibro
            // 
            this.lbRegistroLibro.AutoSize = true;
            this.lbRegistroLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistroLibro.Location = new System.Drawing.Point(31, 28);
            this.lbRegistroLibro.Name = "lbRegistroLibro";
            this.lbRegistroLibro.Size = new System.Drawing.Size(309, 31);
            this.lbRegistroLibro.TabIndex = 11;
            this.lbRegistroLibro.Text = "REGISTRO DE LIBROS";
            // 
            // btLibros
            // 
            this.btLibros.Location = new System.Drawing.Point(223, 280);
            this.btLibros.Name = "btLibros";
            this.btLibros.Size = new System.Drawing.Size(100, 32);
            this.btLibros.TabIndex = 12;
            this.btLibros.Text = "Lista de libros";
            this.btLibros.UseVisualStyleBackColor = true;
            this.btLibros.Click += new System.EventHandler(this.btLibros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 342);
            this.Controls.Add(this.btLibros);
            this.Controls.Add(this.lbRegistroLibro);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbEdicion);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbEdicion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbRegistroLibro;
        private System.Windows.Forms.Button btLibros;
    }
}

