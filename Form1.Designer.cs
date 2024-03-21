namespace LabRepaso3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.buttonIngresarPropitario = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNoCasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDpi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCuota = new System.Windows.Forms.TextBox();
            this.buttonPropiedades = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.buttonMayor = new System.Windows.Forms.Button();
            this.buttonMenor = new System.Windows.Forms.Button();
            this.labelDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Datos de Propietario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DPl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(88, 60);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDPI.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(88, 91);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(88, 128);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 6;
            // 
            // buttonIngresarPropitario
            // 
            this.buttonIngresarPropitario.Location = new System.Drawing.Point(29, 154);
            this.buttonIngresarPropitario.Name = "buttonIngresarPropitario";
            this.buttonIngresarPropitario.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresarPropitario.TabIndex = 7;
            this.buttonIngresarPropitario.Text = "Ingresar";
            this.buttonIngresarPropitario.UseVisualStyleBackColor = true;
            this.buttonIngresarPropitario.Click += new System.EventHandler(this.buttonIngresarPropitario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese Datos de las Propiedades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Numero de casa";
            // 
            // textBoxNoCasa
            // 
            this.textBoxNoCasa.Location = new System.Drawing.Point(160, 218);
            this.textBoxNoCasa.Name = "textBoxNoCasa";
            this.textBoxNoCasa.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoCasa.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "DPI del dueño";
            // 
            // comboBoxDpi
            // 
            this.comboBoxDpi.FormattingEnabled = true;
            this.comboBoxDpi.Location = new System.Drawing.Point(160, 249);
            this.comboBoxDpi.Name = "comboBoxDpi";
            this.comboBoxDpi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDpi.TabIndex = 12;
            this.comboBoxDpi.SelectedIndexChanged += new System.EventHandler(this.comboBoxDpi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cuota de Matenimiento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxCuota
            // 
            this.textBoxCuota.Location = new System.Drawing.Point(160, 313);
            this.textBoxCuota.Name = "textBoxCuota";
            this.textBoxCuota.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuota.TabIndex = 14;
            // 
            // buttonPropiedades
            // 
            this.buttonPropiedades.Location = new System.Drawing.Point(29, 349);
            this.buttonPropiedades.Name = "buttonPropiedades";
            this.buttonPropiedades.Size = new System.Drawing.Size(93, 23);
            this.buttonPropiedades.TabIndex = 15;
            this.buttonPropiedades.Text = "Ingresar Datos";
            this.buttonPropiedades.UseVisualStyleBackColor = true;
            this.buttonPropiedades.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 154);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(307, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(341, 150);
            this.dataGridView2.TabIndex = 17;
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(26, 282);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(96, 13);
            this.labelPropietario.TabIndex = 18;
            this.labelPropietario.Text = "Nombre propietario";
            // 
            // buttonMayor
            // 
            this.buttonMayor.Location = new System.Drawing.Point(128, 349);
            this.buttonMayor.Name = "buttonMayor";
            this.buttonMayor.Size = new System.Drawing.Size(138, 23);
            this.buttonMayor.TabIndex = 19;
            this.buttonMayor.Text = "Ordenar Mayor Cuota";
            this.buttonMayor.UseVisualStyleBackColor = true;
            this.buttonMayor.Click += new System.EventHandler(this.buttonMayor_Click);
            // 
            // buttonMenor
            // 
            this.buttonMenor.Location = new System.Drawing.Point(29, 378);
            this.buttonMenor.Name = "buttonMenor";
            this.buttonMenor.Size = new System.Drawing.Size(125, 23);
            this.buttonMenor.TabIndex = 20;
            this.buttonMenor.Text = "Ordenar Menor Cuota ";
            this.buttonMenor.UseVisualStyleBackColor = true;
            this.buttonMenor.Click += new System.EventHandler(this.buttonMenor_Click);
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Location = new System.Drawing.Point(304, 359);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(86, 13);
            this.labelDatos.TabIndex = 21;
            this.labelDatos.Text = "Datos Propiedad";
            this.labelDatos.Click += new System.EventHandler(this.labelDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.buttonMenor);
            this.Controls.Add(this.buttonMayor);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPropiedades);
            this.Controls.Add(this.textBoxCuota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxDpi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNoCasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonIngresarPropitario);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Button buttonIngresarPropitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNoCasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDpi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCuota;
        private System.Windows.Forms.Button buttonPropiedades;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.Button buttonMayor;
        private System.Windows.Forms.Button buttonMenor;
        private System.Windows.Forms.Label labelDatos;
    }
}

