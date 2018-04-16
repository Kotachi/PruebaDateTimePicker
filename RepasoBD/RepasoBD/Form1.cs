using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionBD conBD = new ConexionBD();
            conBD.agregarDatos(txtAgrNombre.Text,txtAgrDescr.Text);
            dgvMostrarDatos.DataSource = conBD.actualizarDGV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD conBD = new ConexionBD();
                int id = Convert.ToInt32(txtElimDatos.Text);
                conBD.eliminar(id);
                dgvMostrarDatos.DataSource = conBD.actualizarDGV();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("formato no incorrecto,\nIngrese solo numeros.\n"+fe.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtElimDatos_MouseEnter(object sender, EventArgs e)
        {
            lbEliminarDatos.Text = "Usar solo para eliminar datos";
        }

        private void txtElimDatos_MouseLeave(object sender, EventArgs e)
        {
            lbEliminarDatos.Text = "ID";
        }
    }
}
