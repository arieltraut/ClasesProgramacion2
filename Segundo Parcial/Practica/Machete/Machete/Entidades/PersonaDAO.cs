using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    class PersonaDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion


        #region Constructores
        static PersonaDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PersonaDAO._conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True"); //Properties.Settings.Default.conexion
            // CREO UN OBJETO SQLCOMMAND"
            PersonaDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PersonaDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PersonaDAO._comando.Connection = PersonaDAO._conexion;
        }
        #endregion


        #region Métodos

        #region Obtiene primer Elemento
        public static Persona ObtienePersona()
        {
            bool TodoOk = false;
            Persona persona = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = "SELECT TOP 1 id,nombre,apellido FROM TablaPersonas";

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = PersonaDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    persona = new Persona(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString(), oDr["apellido"].ToString());
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
            return persona;
        }
        #endregion

        #region Obtiene toda la Tabla
        public static List<Persona> ObtienePersonas()
        {
            bool TodoOk = false;
            List<Persona> lista = new List<Persona>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = "SELECT * FROM TablaPersonas";

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = PersonaDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    lista.Add(new Persona(int.Parse(oDr["ProductID"].ToString()), oDr["Name"].ToString(), oDr["Apellido"].ToString()));
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
        public static Persona ObtienePersona(int id)
        {
            bool TodoOk = false;
            Persona Persona = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                PersonaDAO._comando.CommandText = "SELECT ProductID,Name,Apellido FROM TablaPersonas WHERE ProductID = " + id;

                // ABRO LA CONEXION A LA BD
                PersonaDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = PersonaDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    Persona = new Persona(int.Parse(oDr["ProductID"].ToString()), oDr["Name"].ToString(), oDr["Apellido"].ToString());
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
        public static bool Insertar(Persona p)
        {
            string sql = String.Format("INSERT INTO TablaPersonas (nombre,apellido) VALUES('{0}','{1}');",
                p.Nombre, p.Apellido);

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Modificar
        public static bool ModificaPersona(Persona p)
        {
            string sql = String.Format("UPDATE TablaPersonas SET nombre = '{0}', apellido = '{1}' WHERE id = {2}",
                p.Nombre, p.Apellido, p.Id.ToString());

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Eliminar
        public static bool EliminaPersona(Persona p)
        {

            string sql = "DELETE FROM TablaPersonas WHERE id = " + p.Id.ToString();

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


//On SQL Server Management Studio

//Right click Databases on left pane (Object Explorer)
//Click Restore Database...
//Choose Device, click ..., and add your .bak file
//Click OK, then OK again
//Done.