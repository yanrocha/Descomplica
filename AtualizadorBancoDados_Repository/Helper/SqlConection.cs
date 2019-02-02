using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtualizadorBancoDados_Model;

namespace AtualizadorBancoDados_Repository.Helper
{
    public class SqlConection
    {
        private static BancoDados oBancoDados = new BancoDados();

        public string Conectar(BancoDados pBancoDados)
        {
            oBancoDados.TipoServidor = pBancoDados.TipoServidor;
            oBancoDados.Server = pBancoDados.Server;
            oBancoDados.Base = pBancoDados.Base;
            oBancoDados.Usuario = pBancoDados.Usuario;
            oBancoDados.Senha = pBancoDados.Senha;

            SqlConnection Con = getConnection();

            if (Con.State == ConnectionState.Open)
            {
                return "Conexão estabelecida com sucesso.";
            }
            else
            {
                return "Houve algum problema durante a conexão";
            }
        }

        public static SqlConnection getConnection()
        {
            string StringConnection;
            StringConnection = "Data Source=" + oBancoDados.Server + ";Initial Catalog=" + oBancoDados.Base + ";User Id=" + oBancoDados.Usuario + ";Password=" + oBancoDados.Senha;
            SqlConnection oCn = new SqlConnection(StringConnection);
            oCn.Open();
            return oCn;
        }
    }
}
