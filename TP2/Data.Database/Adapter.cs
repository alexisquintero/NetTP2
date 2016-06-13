using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {
        
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");
        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringLocal";
        private SqlConnection _sqlConn;
        public SqlConnection SqlConn
        {
            get { return _sqlConn;  }
            set { _sqlConn = value; }
        }
        protected void OpenConnection()
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            SqlConn = new SqlConnection(connString);
            SqlConn.Open();
            //throw new Exception("Metodo no implementado");
        }

        protected void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
            //throw new Exception("Metodo no implementado");
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
