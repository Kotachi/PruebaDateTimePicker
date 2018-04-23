using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace EXAMENJULIANPALACIOS
{
    class Conexion
    {
        private SqlCommand command = new SqlCommand();
        private SqlConnection con;
        String urlCon= "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\CURSOS\\PROGRAMACION\\CODIGOS FUENTE\\EXAMENJULIANPALACIOS\\EXAMENJULIANPALACIOS\\LEONESEXAMEN.mdf;Integrated Security = True";
        
        public Conexion()
        {
            try
            {
                con = new SqlConnection(urlCon);
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error de conexion\n" + se);
            }
        }      

        public void abrirConexion()
        {
            try
            {
                con.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error de conexion\n" + se);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                con.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error\n" + se);
            }
        }

        public void agregarDatos (String Rut,String nombres, int edad, String prof1, String prof2, float promEncu)
        {
           
            try
            {
                abrirConexion();
                command.Connection = con;
                command.CommandText = "INSERT INTO profesores (RutProfesor,Nombre,Edad,Profesion1,Profesion2,PromedioEncuesta) VALUES (@rut, @nombre, @edad, @prof1, @prof2, @promEncu)";
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@rut", Rut);
                command.Parameters.AddWithValue("@nombre",nombres);
                command.Parameters.AddWithValue("@edad",edad);
                command.Parameters.AddWithValue("@prof1",prof1);
                command.Parameters.AddWithValue("@Prof2",prof2);
                command.Parameters.AddWithValue("@promEncu",promEncu);
          
		  int insertOK = command.ExecuteNonQuery();
                if (insertOK > 0)
                {
                    MessageBox.Show("Datos agregados");
                }
                else
                {
                    MessageBox.Show("Datos no agregados");
                }
                command.Dispose();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            cerrarConexion();
        }

        public void eliminarDatos(String rut)
        {
            abrirConexion();
            command.Connection = con;
            try
            {
                command.CommandText = "DELETE FROM profesores WHERE RutProfesor = @rut";
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@rut", rut);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK > 0)
                {
                    MessageBox.Show("Datos eliminados");
                }
                else
                {
                    MessageBox.Show("Datos no eliminados");
                }
                command.Dispose();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            cerrarConexion();
        }

        public void modificarDatos (String Rut, String nombres, int edad, String prof1, String prof2, float promEncu)
        {
           
            try
            {
                abrirConexion();
                command.Connection = con;
                command.CommandText = "UPDATE profesores SET Nombre =@nombre, Edad = @edad, Profesion1 = @prof1, Profesion2 = @prof2, PromedioEncuesta = @promEncu WHERE RutProfesor = @Rut";
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@rut", Rut);
                command.Parameters.AddWithValue("@nombre", nombres);
                command.Parameters.AddWithValue("@edad", edad);
                command.Parameters.AddWithValue("@prof1", prof1);
                command.Parameters.AddWithValue("@Prof2", prof2);
                command.Parameters.AddWithValue("@promEncu", promEncu);
                int insertOK = command.ExecuteNonQuery();
                if (insertOK > 0)
                {
                    MessageBox.Show("Datos modificados");
                }
                else
                {
                    MessageBox.Show("Datos no modificados");
                }
                command.Dispose();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            cerrarConexion();
        }

        public DataTable actualizarDgv()
        {
            try
            {
                PrincipalBD princBD = new PrincipalBD();
                DataTable dt1 = new DataTable();
                abrirConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM profesores", con);
                dt1.Clear();
                adapter.Fill(dt1);
               
                cerrarConexion();
                return dt1;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                cerrarConexion();
                return null;
            }
        }

    }
}
