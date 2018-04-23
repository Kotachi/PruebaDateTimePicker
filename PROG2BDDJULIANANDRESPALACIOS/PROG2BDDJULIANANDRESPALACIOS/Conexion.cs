using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace PROG2BDDJULIANANDRESPALACIOS
{
    class Conexion : IDisposable
    {
        private SqlCommand comando = new SqlCommand();
        private SqlConnection con;
        private String urlConBd = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\CURSOS\\PROGRAMACION\\CODIGOS FUENTE\\PROG2BDDJULIANANDRESPALACIOS\\PROG2BDDJULIANANDRESPALACIOS\\EstudianteJULIANPALACIOS.mdf;Integrated Security = True";

        public Conexion()
        {
            try
            {
                con = new SqlConnection(urlConBd);
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR\n"+se.Message);
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
                MessageBox.Show("ERROR\n" + se.Message);
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
                MessageBox.Show("ERROR\n" + se.Message);
            }
        }

        public void agregarDatos(String rut, String nombre, String apPat, String apMat, String asign, DateTime fNac, int edad, float nota)
        {
            try
            {
                abrirConexion();
                comando.Connection = con;
                comando.CommandText = " INSERT INTO TablaJULIANPALACIOS (nombre, apPaterno, apMaterno, rut, edad, fNac, nota, asignatura) VALUES (@Nombre, @ApPat, @ApMat, @Rut, @Edad, @FNac, @Nota, @Asignatura)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre",nombre);
                comando.Parameters.AddWithValue("@ApPat",apPat);
                comando.Parameters.AddWithValue("@ApMat",apMat);
                comando.Parameters.AddWithValue("@Rut",rut);
                comando.Parameters.AddWithValue("@Edad",edad);
                comando.Parameters.AddWithValue("@FNac",fNac);
                comando.Parameters.AddWithValue("@Nota",nota);
                comando.Parameters.AddWithValue("@Asignatura",asign);

                int ResultOk = comando.ExecuteNonQuery();
                if (ResultOk > 0)
                {
                    MessageBox.Show("Datos Ingresados");
                }
                comando.Dispose();
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR\n" + se.Message);
            }
            finally
            {
                cerrarConexion();
                Dispose();
            }

        }

        public void eliminarDatos(int ID)
        {
            try
            {
                abrirConexion();
                comando.Connection = con;
                comando.CommandText = "DELETE FROM TablaJULIANPALACIOS WHERE id = @ID";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ID",ID);

                int ResultOk = comando.ExecuteNonQuery();
                if (ResultOk > 0)
                {
                    MessageBox.Show("Datos Eliminados");
                }
                comando.Dispose();
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR\n" + se.Message);
            }
            finally
            {
                cerrarConexion();
                Dispose();
            }
        }

        public DataTable actualizarDT()
        {
            try
            {
                DataTable dt = new DataTable();
                String inst = "SELECT * FROM TablaJULIANPALACIOS";
                abrirConexion();
                SqlDataAdapter adaptador = new SqlDataAdapter(inst,con);
                dt.Clear();
                adaptador.Fill(dt);
                adaptador.Dispose();
                return dt;
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR\n" + se.Message);
                return null;
            }
            finally
            {
                cerrarConexion();
                Dispose();
            }
        }

        public DataTable menorEdad()
        {
            try
            {
                abrirConexion();
                DataTable dt = new DataTable();
                String inst = "SELECT * FROM TablaJULIANPALACIOS WHERE edad = (SELECT min(edad) FROM TablaJULIANPALACiOS)";
                SqlDataAdapter adaptador = new SqlDataAdapter(inst, con);
                dt.Clear();
                adaptador.Fill(dt);
                adaptador.Dispose();
                return dt;
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR"+se.Message);
                return null;
            }
            finally
            {
                cerrarConexion();
                Dispose();
            }
        }

        public DataTable promEdad()
        {
            try
            {
                abrirConexion();
                DataTable dt = new DataTable();
                String inst = "SELECT avg(DISTINCT edad) AS promEdad FROM TablaJULIANPALACIOS";
                SqlDataAdapter adaptador = new SqlDataAdapter(inst, con);
                dt.Clear();
                adaptador.Fill(dt);
                adaptador.Dispose();
                return dt;
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error"+se.Message);
                return null;
            }
            finally
            {
                cerrarConexion();
                Dispose();
            }
        }

        public DataTable promNotasEstud(String rut, String asign)
        {
            try
            {
                abrirConexion();
                DataTable dt = new DataTable();
                SqlDataAdapter adaptador;
          
                comando.Connection = con;
                comando.CommandText = "SELECT nombre, apMaterno, apPaterno, rut, asignatura, CAST(avg(nota) AS decimal(3,2)) as promedioNotas FROM TablaJULIANPALACIOS WHERE rut = @rut AND asignatura = @asign  GROUP BY nombre, apMaterno, apPaterno, rut, asignatura";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@rut",rut);
                comando.Parameters.AddWithValue("@asign",asign);
                comando.ExecuteNonQuery();

                    adaptador = new SqlDataAdapter(comando);
                    dt.Clear();
                    adaptador.Fill(dt);
                    adaptador.Dispose();

                return dt;
            }
            catch (SqlException se)
            {
                MessageBox.Show("ERROR"+se.Message);
                return null;
            }
            finally
            {
                cerrarConexion();
                Dispose();
            }
        }

        public void Dispose()
        {
            comando.Dispose();
            con.Dispose();
        }
    }
}
