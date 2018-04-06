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

namespace EXAMENJULIANPALACIOS
{
    public partial class PrincipalBD : Form
    {
        public PrincipalBD()
        {
            InitializeComponent();
            
        }
        Conexion con = new Conexion();
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarABD agreABD = new AgregarABD();
            agreABD.Show();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarBD modBD = new ModificarBD();
            modBD.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarABD elimBD = new EliminarABD();
            elimBD.Show();
        }

        private void PrincipalBD_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lEONESEXAMENDataSet.PROFESORES' Puede moverla o quitarla según sea necesario.
            this.pROFESORESTableAdapter.Fill(this.lEONESEXAMENDataSet.PROFESORES);
        }

       /* public void actualizarDgv()
        {
            try
            {
                Conexion con = new Conexion();
                DataTable dt1 = new DataTable();
                con.abrirConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM profesores", con.con);
                dt1.Clear();
                adapter.Fill(dt1);
                dgvMostrarDatos.DataSource = dt1;
                con.cerrarConexion();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                
            }
        }*/

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          dgvMostrarDatos.DataSource = con.actualizarDgv();
        }

        private void PrincipalBD_Activated(object sender, EventArgs e)
        {
            dgvMostrarDatos.DataSource = con.actualizarDgv();
        }

        private void PrincipalBD_Leave(object sender, EventArgs e)
        {
            dgvMostrarDatos.DataSource = con.actualizarDgv();
        }

        private void PrincipalBD_Deactivate(object sender, EventArgs e)
        {
            dgvMostrarDatos.DataSource = con.actualizarDgv();
        }
    }
}
