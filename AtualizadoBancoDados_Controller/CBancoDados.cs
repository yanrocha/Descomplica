using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtualizadorBancoDados_Model;
using AtualizadorBancoDados_Repository;

namespace AtualizadoBancoDados_Controller
{
    public class CBancoDados
    {
        private RBancoDados _BancoDados = new RBancoDados();

        public string Conectar(BancoDados oBancoDados)
        {
            string oRetorno = "";

            oRetorno = _BancoDados.Conectar(oBancoDados);

            return oRetorno;
        }

        public void teste()
        {
            SqlConnection odb = AtualizadorBancoDados_Repository.Helper.SqlConection.getConnection();
            string SQL = "INSERT INTO Pessoa (id,Nome,Idade,Sexo) VALUES(2,'FAUSTO GAMA MARINS',21,'MASCULINO')";
            SqlCommand oComando = new SqlCommand(SQL, odb);
            oComando.ExecuteNonQuery();
            oComando.Dispose();
            odb.Close();
        }
    }
}
