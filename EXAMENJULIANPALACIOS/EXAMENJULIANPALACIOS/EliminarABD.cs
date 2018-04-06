using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENJULIANPALACIOS
{
    public partial class EliminarABD : Form
    {
        public EliminarABD()
        {
            InitializeComponent();
        }

        Conexion elimBDCon = new Conexion();

        private void btnCancelElim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarBD_Click(object sender, EventArgs e)
        {
            PrincipalBD principalBD = new PrincipalBD();
            elimBDCon.eliminarDatos(txtElimRut.Text);
            txtElimRut.Text = "";
            principalBD.dgvMostrarDatos.DataSource = elimBDCon.actualizarDgv();
        }
    }
}
