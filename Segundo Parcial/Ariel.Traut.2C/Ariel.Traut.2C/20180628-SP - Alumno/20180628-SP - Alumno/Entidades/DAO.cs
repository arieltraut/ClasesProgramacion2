using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;

namespace Entidades
{
    public class DAO : IArchivos<Votacion> 
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion
        
        #region Constructores
        static DAO()
        {
            // CREO UN OBJETO SQLCONECTION
            DAO._conexion = new SqlConnection("Data Source=LAB3PC16\\SQLEXPRESS;Initial Catalog=votacion-sp-2018;Integrated Security=True");
            // CREO UN OBJETO SQLCOMMAND"
            DAO._comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            DAO._comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            DAO._comando.Connection = DAO._conexion;
        }
        #endregion
            
        
        public Votacion Leer(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(string nombre, Votacion objeto)
        {
            string sql;
            try
            {
                sql = String.Format("INSERT INTO {0} (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES('{1}','{2}','{3}','{4}','{5}');",
                    nombre, objeto.NombreLey, objeto.ContadorAfirmativo, objeto.ContadorNegativo, objeto.ContadorAbstencion, "Ariel Traut");
            }
            catch (ErrorArchivoException ex)
            {
                throw ex;
            }

            return EjecutarNonQuery(sql);
        }
        

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                DAO._comando.CommandText = sql;

                DAO._conexion.Open();

                DAO._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    DAO._conexion.Close();
            }
            return todoOk;
        }
        
    }
}
