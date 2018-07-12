using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class PersonaDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion


        #region Constructores
        static PersonaDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PersonaDAO._conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ej61Persona;Integrated Security=True"); //Properties.Settings.Default.conexion
            // CREO UN OBJETO SQLCOMMAND"
            PersonaDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PersonaDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PersonaDAO._comando.Connection = PersonaDAO._conexion;
        }
        #endregion


        #region Métodos

        #region Obtiene toda la Tabla
        public static List<Persona> Leer()
        {
            bool TodoOk = false;
            List<Persona> lista = new List<Persona>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = "SELECT * FROM Persona";

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = PersonaDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    lista.Add(new Persona(int.Parse(oDr["ID"].ToString()), oDr["Nombre"].ToString(), oDr["Apellido"].ToString()));
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (TodoOk)
                    PersonaDAO._conexion.Close();
            }
            return lista;
        }
        #endregion

        #region Obtiene por ID
        public static Persona LeerPorID(int id)
        {
            bool TodoOk = false;
            Persona Persona = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = "SELECT ID,Name,Apellido FROM Persona WHERE ID = " + id;

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = PersonaDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    Persona = new Persona(int.Parse(oDr["ID"].ToString()), oDr["Nombre"].ToString(), oDr["Apellido"].ToString());
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (TodoOk)
                    PersonaDAO._conexion.Close();
            }
            return Persona;
        }
        #endregion

        #region Insertar
        public static bool Guardar(Persona p)
        {
            string sql = String.Format("INSERT INTO Persona (nombre,apellido) VALUES('{0}','{1}');",
                p.Nombre, p.Apellido);

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Modificar
        public static bool Modificar(Persona p)
        {
            string sql = String.Format("UPDATE Persona SET nombre = '{0}', apellido = '{1}' WHERE id = {2}",
                p.Nombre, p.Apellido, p.Id.ToString());

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Eliminar
        public static bool Eliminar(Persona p)
        {

            string sql = "DELETE FROM Persona WHERE id = " + p.Id.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion



        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND
                PersonaDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    PersonaDAO._conexion.Close();
            }
            return todoOk;
        }
        #endregion



    }
}
