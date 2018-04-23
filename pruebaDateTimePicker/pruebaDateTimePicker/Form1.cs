using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace pruebaDateTimePicker
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand comando;
        String urlBD = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\CURSOS\\PROGRAMACION\\CODIGOS FUENTE\\pruebaDateTimePicker\\pruebaDateTimePicker\\PruebaDTP.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(urlBD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(urlBD);
            con.Open();
            //comando = new 
            try
            {
                comando = new SqlCommand("INSERT INTO PRUEBA1 (nombre, fecha) VALUES ('" + txtNombre.Text + "','" + dtpFecha.Value + "')", con);
                comando.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            
            con.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter("INSERT INTO prueba1 (nombre,fecha) VALUES ('"+txtNombre.Text+"',"+dtpFecha.Text+")",con);
            tabla.Clear();
            adaptador.Fill(tabla);
            

        }
    }
}
