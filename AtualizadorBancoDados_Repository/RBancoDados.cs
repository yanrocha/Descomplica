using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtualizadorBancoDados_Model;

namespace AtualizadorBancoDados_Repository
{
    public class RBancoDados
    {
        public string Conectar(BancoDados oBancoDados)
        {
            string Retorno = "Houve um erro não identificado";

            Helper.SqlConection _Con = new Helper.SqlConection();
            Retorno = _Con.Conectar(oBancoDados);

            return Retorno;
        }
    }
}
