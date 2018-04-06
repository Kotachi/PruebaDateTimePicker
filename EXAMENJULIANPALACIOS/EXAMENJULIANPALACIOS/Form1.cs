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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnMultXTres_Click(object sender, EventArgs e)
        {
            MultXTres multXTres = new MultXTres();
            this.Hide();
            multXTres.Show();
        }

        private void btnParOImpar_Click(object sender, EventArgs e)
        {
            ParImpar parImpar = new ParImpar();
            this.Hide();
            parImpar.Show();
        }

        private void btnTablaMult_Click(object sender, EventArgs e)
        {
            TablaMultiplicar tablaMulti = new TablaMultiplicar();
            this.Hide();
            tablaMulti.Show();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            Arrays array = new Arrays();
            this.Hide();
            array.Show();
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            PrincipalBD principalBD = new PrincipalBD();
            this.Hide();
            principalBD.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
