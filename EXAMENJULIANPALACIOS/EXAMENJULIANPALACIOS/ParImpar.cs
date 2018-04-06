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
    public partial class ParImpar : Form
    {
        public ParImpar()
        {
            InitializeComponent();
        }

        int num;
        private void txtIngNumParImpar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtIngNumParImpar.Text == "")
                {
                    lbResultParImpar.Text = "Respuesta";
                }
                else
                {
                    num = Convert.ToInt32(txtIngNumParImpar.Text) ;
                    if (num % 2 == 0)
                    {
                        lbResultParImpar.Text = "Es par";
                    }
                    else
                    {
                        lbResultParImpar.Text = "Es impar";
                    }

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

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }
    }
}
