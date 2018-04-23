using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG2BDDJULIANANDRESPALACIOS
{
    public partial class frmPromNotasEstu : Form
    {
        public frmPromNotasEstu()
        {
            InitializeComponent();
        }

        private void btnPromNotaEst_Click(object sender, EventArgs e)
        {
            Conexion conPromNotasEst = new Conexion();
            dgvPromNotasEstu.Visible = true;
            dgvPromNotasEstu.DataSource =  conPromNotasEst.promNotasEstud(txtIngRut.Text, txtIngAsignatura.Text);
        }

        private void btnPromNotaEst_MouseEnter(object sender, EventArgs e)
        {
            lbAyudaProm.Visible = true;
        }

        private void btnPromNotaEst_MouseLeave(object sender, EventArgs e)
        {
            lbAyudaProm.Visible = false;
        }

        private void frmPromNotasEstu_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Para ver el promedio por asignatura rellene\n los campos y luego pulse \"Promedio\".");
        }
    }
}
