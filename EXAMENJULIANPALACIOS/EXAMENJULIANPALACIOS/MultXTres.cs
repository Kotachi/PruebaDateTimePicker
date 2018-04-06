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
    public partial class MultXTres : Form
    {
        public MultXTres()
        {
            InitializeComponent();
        }

        int num;

        private void txtIngNumXTres_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtIngNumXTres.Text == "") {
                    lbResultXTres.Text = "Respuesta";
                }
                else{

                    num = 0;
                    num = Convert.ToInt32(txtIngNumXTres.Text);
                    num *= 3;
                    lbResultXTres.Text = "El resultado es: " + num.ToString();
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error, Ingrese solo numeros enteros\n" + ex.Message);
                
            }
            catch (SystemException se)
            {
                MessageBox.Show("Ingrese solo numeros enteros\n" + se.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }
    }
}
