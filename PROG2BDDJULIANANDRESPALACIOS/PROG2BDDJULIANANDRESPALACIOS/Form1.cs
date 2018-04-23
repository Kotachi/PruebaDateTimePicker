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
using System.Threading;


namespace PROG2BDDJULIANANDRESPALACIOS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            actualizarDGV();
        }

        public void actualizarDGV()
        {
            Conexion conPpal = new Conexion();
            dgvMostrarDatos.DataSource = conPpal.actualizarDT();
        }

        private void btnAgregarReg_Click(object sender, EventArgs e)
        {
            frmAgregarReg agrReg = new frmAgregarReg();
            agrReg.Show();
            actualizarDGV();
        }

        private void btnEliminarReg_Click(object sender, EventArgs e)
        {
            frmEliminarReg elimReg = new frmEliminarReg();
            elimReg.Show();
            actualizarDGV();
        }

        private void btnCerrarPpal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Enter(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void btnMenorEdad_Click(object sender, EventArgs e)
        {
            Conexion conEdad = new Conexion();
 
            dgvMostrarDatos.DataSource = conEdad.menorEdad();

            lbRutMenorEdad.Visible = true;
            lbMenorEdad.Visible = true;
            lbTitMenorEdad.Visible = true;
            lbMenorEdad.Text = lbRutMenorEdad.Text = "";

            int filas = dgvMostrarDatos.RowCount;

            for (int i = 0;i<filas-1;i++)
            {
                lbRutMenorEdad.Text = lbRutMenorEdad.Text + dgvMostrarDatos.Rows[i].Cells[4].Value.ToString() + "\n";
                lbMenorEdad.Text = lbMenorEdad.Text + dgvMostrarDatos.Rows[i].Cells[5].Value.ToString() + "\n";
            }
            actualizarDGV();
           /* Thread.Sleep(2000);
            */
            
        }

        private void btnPromEdad_Click(object sender, EventArgs e)
        {
            
            Conexion conPromEdad = new Conexion();
            dgvMostrarDatos.DataSource = conPromEdad.promEdad();

            lbPromEdad.Text = "El promedio de edad es: ";
            lbPromEdad.Visible = true;
            lbPromEdad.Text = lbPromEdad.Text + dgvMostrarDatos.Rows[0].Cells[0].Value.ToString();

            actualizarDGV();

           
        }

        private void btnPromNotas_Click(object sender, EventArgs e)
        {
            frmPromNotasEstu frmPromNotas = new frmPromNotasEstu();
            frmPromNotas.Show();
        }

        public void temporizador()
        {
            TimeSpan time = new TimeSpan(0,0,10);
            Task.Delay(10).Wait(time);
            lbPromEdad.Text = "El promedio de edad es: ";
        }
    }
}
