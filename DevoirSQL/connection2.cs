using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Ado
{
    class connection2
    {
         static private MySqlConnection cnx2;
         static private string sConnexion;

         public connection2(string h, string u, string db, string pswd)
         
         {
            connection2.sConnexion = "host="+h+"; database="+db+"; user="+u+"; password="+pswd+";";
            connection2.cnx2 = new MySqlConnection(sConnexion);
         }
         public MySqlConnection Cnx2
         {
             get { return connection2.cnx2; }
         }


    }
}
