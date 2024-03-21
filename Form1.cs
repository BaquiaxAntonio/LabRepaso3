using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRepaso3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedades> propiedades = new List<Propiedades>();

        public void MostrarPropietarios()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propietarios;
            dataGridView1.Refresh();
        }

        public void MostrarPropiedades()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = propiedades;
            dataGridView2.Refresh();
        }

        public void limpiar()
        {
            textBoxNombre.Text = "";
            textBoxDPI.Text = "";
            textBoxApellido.Text = "";
        }

        public void limpiar1()
        {
            textBoxNoCasa.Text= "";
            comboBoxDpi.Text = "";
            textBoxCuota.Text = "";
        }

        public void cargarPropietario()
        {
            string fileName = "Propietarios.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            propietarios.Clear();
            comboBoxDpi.Items.Clear();

            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.Dpi = reader.ReadLine();
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();
                propietarios.Add(propietario);
                comboBoxDpi.Items.Add(propietario.Dpi);
            }
            reader.Close();
            MostrarPropietarios();
        }

        public void cargarPropiedades()
        {
            string fileName = "Propiedades.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            propiedades.Clear();

            while (reader.Peek() > -1)
            {
                Propiedades propiedad = new Propiedades();
                propiedad.NoCasa= reader.ReadLine();
                propiedad.DpiDueño = reader.ReadLine();
                propiedad.CuotaMatenimiento = Convert.ToInt16(reader.ReadLine());
                propiedades.Add(propiedad);
            }
            reader.Close();
            MostrarPropiedades();
        }

        public void MostrarTresCuotasMasAltas()
        {
            var tresCuotasMasAltas = propiedades.OrderByDescending(prop => prop.CuotaMatenimiento).Take(3).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Las tres cuotas de mantenimiento más altas son:");

            foreach (var propiedad in tresCuotasMasAltas)
            {
                sb.AppendLine($"No. Casa: {propiedad.NoCasa}, Cuota de mantenimiento: {propiedad.CuotaMatenimiento}");
            }

            MessageBox.Show(sb.ToString(), "Cuotas más altas de mantenimiento");
        }

        public void MostrarTresCuotasMasBajas()
        {
            var tresCuotasMasBajas = propiedades.OrderBy(prop => prop.CuotaMatenimiento).Take(3).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Las tres cuotas de mantenimiento más bajas son:");

            foreach (var propiedad in tresCuotasMasBajas)
            {
                sb.AppendLine($"No. Casa: {propiedad.NoCasa}, Cuota de mantenimiento: {propiedad.CuotaMatenimiento}");
            }

            MessageBox.Show(sb.ToString(), "Cuotas más bajas de mantenimiento");
        }

        private void mostrarMaxCuota()
        {
            Propiedades propiedadMasAlta = propiedades[0]; 
            foreach (var propiedad in propiedades)
            {
                if (propiedad.CuotaMatenimiento > propiedadMasAlta.CuotaMatenimiento)
                {
                    propiedadMasAlta = propiedad; 
                }
            }

            Propietario propietarioConCuotaMasAlta = propietarios.Find(prop => prop.Dpi == propiedadMasAlta.DpiDueño);
            labelDatos.Text = $"El propietario con la cuota más alta es {propietarioConCuotaMasAlta.Nombre} {propietarioConCuotaMasAlta.Apellido}.\n" +
                    $"La cuota más alta es {propiedadMasAlta.CuotaMatenimiento}.";
        }

            private void buttonIngresarPropitario_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();
            propietario.Dpi = textBoxDPI.Text;
            propietario.Nombre = textBoxNombre.Text;
            propietario.Apellido = textBoxApellido.Text;
            propietarios.Add(propietario);

            string fileName = "Propietarios.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var dueño in propietarios)
            {
                writer.WriteLine(dueño.Dpi);
                writer.WriteLine(dueño.Nombre);
                writer.WriteLine(dueño.Apellido);
                
            }
            writer.Close();

            limpiar();
            MessageBox.Show("Propietario Regsitrado");
            cargarPropietario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Propiedades propiedad = new Propiedades();
            propiedad.NoCasa = textBoxNoCasa.Text;
            propiedad.DpiDueño = comboBoxDpi.Text;
            propiedad.CuotaMatenimiento = Convert.ToInt16(textBoxCuota.Text);
            propiedades.Add(propiedad);
            string fileName = "Propiedades.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var propiedad1 in propiedades)
            {
                writer.WriteLine(propiedad1.NoCasa);
                writer.WriteLine(propiedad1.DpiDueño);
                writer.WriteLine(propiedad1.CuotaMatenimiento);

            }
            writer.Close();

            limpiar1();
            MessageBox.Show("Propiedad Regsitrada");
            cargarPropiedades();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonMayor_Click(object sender, EventArgs e)
        {
            MostrarTresCuotasMasAltas();
            mostrarMaxCuota();
        }

        private void labelDatos_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDpi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dpiCliente = comboBoxDpi.SelectedItem.ToString().Trim();

            Propietario propietarioEncontrado = propietarios.Find(c => c.Dpi == dpiCliente);

            if (propietarioEncontrado != null)
            {
                labelPropietario.Text = propietarioEncontrado.Nombre;
            }
        }

        private void buttonMenor_Click(object sender, EventArgs e)
        {
            MostrarTresCuotasMasBajas();
        }
    }
}
