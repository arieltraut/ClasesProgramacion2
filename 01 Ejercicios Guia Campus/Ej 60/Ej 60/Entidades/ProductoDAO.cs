using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class ProductoDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        private static string connectionStr = Properties.Settings.Default.connectionStr;

        #endregion


        #region Constructores
        static ProductoDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            ProductoDAO._conexion = new SqlConnection(connectionStr);
            // CREO UN OBJETO SQLCOMMAND
            ProductoDAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            ProductoDAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            ProductoDAO._comando.Connection = ProductoDAO._conexion;
        }
        #endregion


        #region Métodos

        #region Getters
        public static Producto ObtieneProducto(int id)
        {
            bool TodoOk = false;
            Producto producto = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO._comando.CommandText = "SELECT ProductID,Name,Color FROM TablaProducto WHERE ProductID = " + id;

                // ABRO LA CONEXION A LA BD
                ProductoDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = ProductoDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    producto = new Producto(int.Parse(oDr["ProductID"].ToString()), oDr["Name"].ToString(), oDr["Color"].ToString());
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
                    ProductoDAO._conexion.Close();
            }
            return producto;
        }

        public static List<Producto> ObtieneProductos()
        {
            bool TodoOk = false;
            List<Producto> lista = new List<Producto>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO._comando.CommandText = "SELECT * FROM TablaProducto";

                // ABRO LA CONEXION A LA BD
                ProductoDAO._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = ProductoDAO._comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    lista.Add(new Producto(int.Parse(oDr["ProductID"].ToString()), oDr["Name"].ToString(), oDr["Color"].ToString()));
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
                    ProductoDAO._conexion.Close();
            }
            return lista;
        }
        #endregion

        #region Insertar Producto
        public static bool InsertaProducto(Producto p)
        {
            string sql = "INSERT INTO TablaProducto (Name,Color) VALUES(";
            sql = sql + "'" + p.Name + "','" + p.Color + "')"; //p.DNI.ToString()

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Modificar Producto
        public static bool ModificaProducto(Producto p)
        {
            string sql = "UPDATE TablaProducto SET Name = '" + p.Name + "', Color = '";
            sql = sql + p.Color + " WHERE id = " + p.ProductId.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion

        #region Eliminar Producto
        public static bool EliminaProducto(Producto p)
        {
            string sql = "DELETE FROM Productos WHERE ProductID = " + p.ProductId.ToString();

            return EjecutarNonQuery(sql);
        }
        #endregion


        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductoDAO._conexion.Open();

                // EJECUTO EL COMMAND
                ProductoDAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    ProductoDAO._conexion.Close();
            }
            return todoOk;
        }

        #endregion
    }
}
