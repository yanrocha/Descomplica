using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AtualizadorBancoDados_Repositroy.Helper
{
    class MyConnection
    {
        public static MySqlConnection getConnection(string Server, string User, string Database, string Password)
        {
            string StringConnection;
            StringConnection = "server="+Server+";User Id="+User+";database="+Database+";password="+Password+";Pooling=False";
            MySqlConnection oCn = new MySqlConnection(StringConnection);
            oCn.Open();
            return oCn;
        }
    }
}
