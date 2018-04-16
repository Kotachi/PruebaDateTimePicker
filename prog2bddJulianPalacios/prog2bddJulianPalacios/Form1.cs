using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2bddJulianPalacios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConBDD con = new ConBDD();
            int edad = Convert.ToInt32(txtEdad.Text);
            float nota = Convert.ToSingle(txtNotas.Text);
            con.agregar(txtNombre.Text,txtApPat.Text,txtApMat.Text,txtRut.Text,edad,dtpFNac.Value,nota,txtAsignatura.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConBDD con = new ConBDD();
            int edad = Convert.ToInt32(txtEdad.Text);
            float nota = Convert.ToSingle(txtNotas.Text);
            con.agregar(txtNombre.Text, txtApPat.Text, txtApMat.Text, txtRut.Text, edad, dtpFNac.Value, nota, txtAsignatura.Text);
        }

        private void pnlAgregar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
