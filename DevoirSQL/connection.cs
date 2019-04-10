using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Ado
{
    static class connection
    {
        static private MySqlConnection cnx;

        public static MySqlConnection Cnx
        {
            get 
            { 
                return connection.cnx; 
            }
        }
        static private string sConnection;

        static connection()
        {
            sConnection = "host=localhost; database=tennis; user=root; password=siojjr";
            cnx = new MySqlConnection(sConnection);
        }
    }
}
