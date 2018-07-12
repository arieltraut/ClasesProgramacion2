using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class GrupoDAO
    {

        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion


        #region Constructores
        static GrupoDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            GrupoDAO._conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=mundial-sp-2018;Integrated Security=True"); //Properties.Settings.Default.conexion
            // CREO UN OBJETO SQLCOMMAND"
            GrupoDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            GrupoDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            GrupoDAO._comando.Connection = GrupoDAO._conexion;
        }
        #endregion


        #region Métodos

        //#region Obtiene primer Elemento
        //public static Equipo ObtieneEquipo()
        //{
        //    bool TodoOk = false;
        //    Equipo equipo = null;

        //    try
        //    {
        //        // LE PASO LA INSTRUCCION SQL
        //        GrupoDAO._comando.CommandText = "SELECT TOP 1 id,nombre,apellido FROM Equipos";

        //        // ABRO LA CONEXION A LA BD
        //        GrupoDAO._conexion.Open();

        //        // EJECUTO EL COMMAND                 
        //        SqlDataReader oDr = GrupoDAO._comando.ExecuteReader();

        //        // MIENTRAS TENGA REGISTROS...
        //        if (oDr.Read())
        //        {
        //            // ACCEDO POR NOMBRE O POR INDICE
        //            equipo = new Equipo(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString(), oDr["apellido"].ToString());
        //        }

        //        //CIERRO EL DATAREADER
        //        oDr.Close();

        //        TodoOk = true;
        //    }

        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (TodoOk)
        //            GrupoDAO._conexion.Close();
        //    }
        //    return equipo;
        //}
        //#endregion

        #region Obtiene toda la Tabla
        public static List<Equipo> ObtieneEquiposDelGrupo(Letras letraGrupo)
        {
            bool TodoOk = false;
            List<Equipo> lista = new List<Equipo>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                GrupoDAO._comando.CommandText = "SELECT id,nombre FROM Equipos WHERE grupo = " + letraGrupo.ToString();

                // ABRO LA CONEXION A LA BD
                GrupoDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = GrupoDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    lista.Add(new Equipo(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString()));
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
                    GrupoDAO._conexion.Close();
            }
            return lista;
        }
        #endregion

        #region Obtiene por ID
        public static Equipo ObtieneEquipoDelGrupo(Letras letraGrupo)
        {
            bool TodoOk = false;
            Equipo Equipo = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                GrupoDAO._comando.CommandText = "SELECT id,nombre FROM Equipos WHERE grupo = " + letraGrupo;

                // ABRO LA CONEXION A LA BD
                GrupoDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = GrupoDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    Equipo = new Equipo(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString());
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
                    GrupoDAO._conexion.Close();
            }
            return Equipo;
        }
        #endregion

        //#region Insertar
        //public static bool Insertar(Equipo p)
        //{
        //    string sql = String.Format("INSERT INTO Equipos (nombre,apellido) VALUES('{0}','{1}');",
        //        p.Nombre, p.Apellido);

        //    return EjecutarNonQuery(sql);
        //}
        //#endregion

        //#region Modificar
        //public static bool ModificaEquipo(Equipo p)
        //{
        //    string sql = String.Format("UPDATE Equipos SET nombre = '{0}', apellido = '{1}' WHERE id = {2}",
        //        p.Nombre, p.Apellido, p.Id.ToString());

        //    return EjecutarNonQuery(sql);
        //}
        //#endregion

        //#region Eliminar
        //public static bool EliminaEquipo(Equipo p)
        //{

        //    string sql = "DELETE FROM Equipos WHERE id = " + p.Id.ToString();

        //    return EjecutarNonQuery(sql);
        //}
        //#endregion



        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                GrupoDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                GrupoDAO._conexion.Open();

                // EJECUTO EL COMMAND
                GrupoDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    GrupoDAO._conexion.Close();
            }
            return todoOk;
        }
        #endregion
    }
}
