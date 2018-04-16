using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace RepasoBD
{
    class ConexionBD
    {
        SqlCommand comando = new SqlCommand();
        SqlConnection conBD;

        public ConexionBD()
        {
            try
            {
                conBD = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\CURSOS\\PROGRAMACION\\CODIGOS FUENTE\\RepasoBD\\RepasoBD\\RepasoBD.mdf;Integrated Security=True");
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error"+se.Message);
            }
        }

        public void abrirConexion()
        {
            try
            {
                conBD.Open();
                
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error\n"+se.Message);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conBD.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error\n"+se.Message);
            }
        }

        public void agregarDatos(String Nomb, String DESCR)
        {
            try
            {
                abrirConexion();
                comando.Connection = conBD;
                comando.CommandText = "INSERT INTO tablaPrueba (nombre,descripcion) VALUES (@nombres,@descripcion)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombres", Nomb);
                comando.Parameters.AddWithValue("@descripcion",DESCR);
                int resultOK = comando.ExecuteNonQuery();
                if (resultOK>0)
                {
                    MessageBox.Show("Datos Agregados");
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error\n"+se.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void eliminar(int ID)
        {
            try
            {
                abrirConexion();
                comando.Connection = conBD;
                comando.CommandText = "DELETE FROM tablaPrueba WHERE Id=@ID";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ID", ID);
                int ResultOK = comando.ExecuteNonQuery();
                if (ResultOK > 0)
                {
                    MessageBox.Show("Datos Eliminados");
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error"+se.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataTable actualizarDGV()
        {
            try
            {
                DataTable dt = new DataTable();
                abrirConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tablaPrueba", conBD);
                adapter.Fill(dt);
                return dt;

            }
            catch (SqlException se)
            {
                MessageBox.Show("Error\n"+se.Message);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }
    }
}
