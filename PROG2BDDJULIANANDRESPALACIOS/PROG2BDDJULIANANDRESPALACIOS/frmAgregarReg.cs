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
    public partial class frmAgregarReg : Form
    {
        public frmAgregarReg()
        {
            InitializeComponent();
        }

        private void btnGuardarReg_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conAgr = new Conexion();
                int edad = Convert.ToInt32(txtIngEdad.Text);
                float nota = Convert.ToSingle(txtIngNota.Text);
                conAgr.agregarDatos(txtIngRut.Text, txtIngNombres.Text, txtIngApPat.Text, txtIngApMat.Text, txtIngAsign.Text, dtpIngFNac.Value, edad, nota);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Formato incorrecto\n"+fe.Message);
            }
            catch(SystemException se)
            {
                MessageBox.Show("ERROR\n"+se.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnGuardarReg_MouseEnter(object sender, EventArgs e)
        {
            lbAyuda.Visible = true;
        }

        private void btnGuardarReg_MouseLeave(object sender, EventArgs e)
        {
            lbAyuda.Visible = false;
        }

        private void frmAgregarReg_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Para guardar un registro en la BD rellene\n los campos y luego pulse \"Guardar\".");
        }

        private void frmAgregarReg_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Para guardar un registro en la BD rellene\n los campos y luego pulse \"Guardar\".");
        }
    }
}
