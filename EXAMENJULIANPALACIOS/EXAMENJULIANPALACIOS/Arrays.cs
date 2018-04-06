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
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }
        int[] num;
        int largoNum,suma=0;
        float prom = 0;
        String numeros;

        private void btnVolver5_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            this.Close();
            principal.Show();
        }

        private void btnCalcular5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIngNum5.Text == "") { }
                else
                {
                    numeros = txtIngNum5.Text;
                    largoNum = txtIngNum5.TextLength;
                    num = new int[largoNum];
                    for (int i = 0; i < largoNum; i++)
                    {
                        num[i] = Convert.ToInt32(Convert.ToString(numeros.ElementAt(i)));
                        suma += num[i];
                    }
                    
                    Array.Sort(num);
                    prom = (float) suma / (float)largoNum;

                    lbSuma.Text = "La suma total es: " + suma;
                    lbMayor.Text = "El numero mayor es: " + num[largoNum - 1];
                    lbMenor.Text = "El numero menor es: " + num[0];
                    lbPromedio.Text = "El promedio es: " + prom;

                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error, Ingrese solo numeros enteros\n" + ex.Message);
                txtIngNum5.Text = "";

            }
            catch (SystemException se)
            {
                MessageBox.Show("Ingrese solo numeros enteros\n" + se.Message);
                txtIngNum5.Text = "";
            }
        }

      

        private void txtIngNum5_TextChanged(object sender, EventArgs e)
        {
            suma = 0;
            prom = 0;
        }
    }
}
