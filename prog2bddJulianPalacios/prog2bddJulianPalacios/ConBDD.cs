using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace prog2bddJulianPalacios
{
    class ConBDD
    {
        private SqlCommand comando = new SqlCommand();
        private SqlConnection conBDD;
        String urlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\CURSOS\\PROGRAMACION\\CODIGOS FUENTE\\prog2bddJulianPalacios\\prog2bddJulianPalacios\\EstudianteJulianPalacios.mdf;Integrated Security=True";

        public ConBDD()
        {
            try
            {
                conBDD = new SqlConnection(urlCon);
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error de conexion\n" + se.Message);
            }
        }

        public void abrirConexion()
        {
            try
            {
                conBDD.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error de conexion\n" + se.Message);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conBDD.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error\n" + se.Message);
            }
        }

        public void agregar(String Nombres,String apPat, String apMat,String Rut,int Edad, DateTime fNac,float Nota,String Asignatura)
        {
            try
            {
                abrirConexion();
                comando.Connection = conBDD;
                comando.CommandText = "INSERT INTO tablajulianpalacios (nombre,appat,apmat,rut,edad,fnac,nota,asignatura) VALUES (@nombres,@appat,@apmat,@rut,@edad,@fnac,@nota,@asignatura)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombres",Nombres);
                comando.Parameters.AddWithValue("@appat",apPat);
                comando.Parameters.AddWithValue("@apmat",apMat);
                comando.Parameters.AddWithValue("@rut",Rut);
                comando.Parameters.AddWithValue("@edad",Edad);
                comando.Parameters.AddWithValue("@fnac",fNac);
                comando.Parameters.AddWithValue("@nota",Nota);
                comando.Parameters.AddWithValue("@asignatura",Asignatura);
                int comOk = comando.ExecuteNonQuery();
                if(comOk > 0)
                {
                    MessageBox.Show("Datos ingresados");
                }
                else
                {
                    MessageBox.Show("Datos no ingresados");
                }
                cerrarConexion();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error" + se.Message);
            }
        }

    }
}
