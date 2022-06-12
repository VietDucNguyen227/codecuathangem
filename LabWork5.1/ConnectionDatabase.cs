using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace LabWork5._1
{
    public class ConnectionDatabase
    {
        public SqlConnection GetConnection()
        {
            string connectionString =
                "Data source = localhost; Initial Catalog =myjdbcapp;User =sa; password =shiroukrs1";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection; 
        }
    }
}
