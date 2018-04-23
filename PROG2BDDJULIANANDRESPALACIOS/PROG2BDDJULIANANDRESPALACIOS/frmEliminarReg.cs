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
    public partial class frmEliminarReg : Form
    {
        public frmEliminarReg()
        {
            InitializeComponent();
        }

        private void btnElimReg_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtElimReg.Text);
                Conexion conElim = new Conexion();
                conElim.eliminarDatos(ID);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Ingrese solo numeros\n"+fe.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnElimReg_MouseEnter(object sender, EventArgs e)
        {
            lbAyudaElim.Visible = true;
        }

        private void btnElimReg_MouseLeave(object sender, EventArgs e)
        {
            lbAyudaElim.Visible = false;
        }

        private void frmEliminarReg_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Para eliminar un dato ingrese el ID del registro y presione \"Eliminar\".");
        }
    }
}
