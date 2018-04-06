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
    public partial class TablaMultiplicar : Form
    {
        public TablaMultiplicar()
        {
            InitializeComponent();
        }
        int num = 0;

        private void txtIngNum4_TextChanged(object sender, EventArgs e)
        {
            txtResultado4.Text = "";
        }

        private void btnVolver4_Click(object sender, EventArgs e)
        {
            Principal principal4 = new Principal();
            this.Close();
            principal4.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIngNum4.Text == "")
                {
                    txtResultado4.Text = "";
                }
                else
                {
                    num = Convert.ToInt32(txtIngNum4.Text);
                    for (int i = 1; i < 11; i++)
                    {
                        txtResultado4.AppendText(i + " x " + num + " = " + num * i + "\n");
                    }

                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error, Ingrese solo numeros enteros\n" + ex.Message);
                txtIngNum4.Text = "";

            }
            catch (SystemException se)
            {
                MessageBox.Show("Ingrese solo numeros enteros\n" + se.Message);
                txtIngNum4.Text = "";
            }
        }
    }
}
