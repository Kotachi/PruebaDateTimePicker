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
    public partial class ModificarBD : Form
    {
        public ModificarBD()
        {
            InitializeComponent();
        }

        private void btnCancelMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModProfesor_Click(object sender, EventArgs e)
        {
            Conexion modDatosBD = new Conexion();
            try
            {
                PrincipalBD principalBD = new PrincipalBD();
                int edad = Convert.ToInt32(txtModEdad.Text);
                float promeEncu = Convert.ToSingle(txtModPromEncu.Text);
                 modDatosBD.modificarDatos(txtModRut.Text,txtModNombres.Text,edad,txtModProf1.Text,txtModProf2.Text,promeEncu);
                txtModRut.Text = txtModNombres.Text = txtModEdad.Text = txtModProf1.Text = txtModProf2.Text = txtModPromEncu.Text = "";
                principalBD.dgvMostrarDatos.DataSource = modDatosBD.actualizarDgv();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error de formato de los numeros\n" + ex.Message);


            }
            catch (SystemException se)
            {
                MessageBox.Show("Error\n" + se.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
