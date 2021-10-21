using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Internet_service_provider
{
    static internal class ConnectionString
    {
        /// <summary>
        /// Connection string from app.config.
        /// </summary>
        /// <returns>If first start project, method return string connection with data base for developing.</returns>
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        public static DataSet GetDataSetFromDataBase (string select)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, connection);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
        }
        /// <summary>
        /// Example SQL commands (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="select">It`s command "select..."</param>
        public static void ExecuteSqlCommand (string select)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(select, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
            }
        }



    }
}
