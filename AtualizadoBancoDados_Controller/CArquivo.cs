using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtualizadorBancoDados_Repository;

namespace AtualizadoBancoDados_Controller
{
    public class CArquivo
    {
        private RArquivo _Arquivo = new RArquivo();

        public string RetornaTexto(string Caminho)
        {
            return _Arquivo.RetornaTexto(Caminho);
        }

        public string CopiarArquivo(string Caminho)
        {
            return _Arquivo.CopiarArquivo(Caminho);
        }
    }
}
