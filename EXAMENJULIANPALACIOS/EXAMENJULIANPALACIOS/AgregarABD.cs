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
    public partial class AgregarABD : Form
    {
        public AgregarABD()
        {
            InitializeComponent();
        }

        Conexion agrDatosCon = new Conexion();
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                PrincipalBD principalBD = new PrincipalBD();
                int edad = Convert.ToInt32(txtIngEdad.Text);
                float promeEncu = Convert.ToSingle(txtPromEncu.Text);
                agrDatosCon.agregarDatos(txtIngRut.Text, txtIngNombre.Text, edad, txtIngProf1.Text, txtIngProf2.Text, promeEncu);
                txtIngRut.Text = txtIngNombre.Text = txtIngEdad.Text = txtIngProf1.Text = txtIngProf2.Text = txtPromEncu.Text = "";
                principalBD.dgvMostrarDatos.DataSource = agrDatosCon.actualizarDgv();
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error de formato de los numeros\n" + ex.Message);
                
            }
            catch (SystemException se)
            {
                MessageBox.Show("Error\n" + se.Message);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

    }
}
