using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtualizadorBancoDados_Repository
{
    public class RArquivo
    {

        public string RetornaTexto(string Caminho)
        {
            string retorno = "";

            if (File.Exists(Caminho))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(Caminho))
                    {
                        String linha;
                        // Lê linha por linha
                        while ((linha = sr.ReadLine()) != null)
                        {
                            retorno += linha;
                            retorno += "\n";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return retorno;
        }

        public string CopiarArquivo(string caminho)
        {
            string destino = @"C:\";

            string[] dest = caminho.Split(Path.DirectorySeparatorChar);
            destino += "Teste" + dest.Last();

            if(!File.Exists(destino))
            {
                StreamWriter Escrita = new StreamWriter(destino);

                using (StreamReader sr = new StreamReader(caminho))
                {
                    String linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Escrita.WriteLine(linha);
                    }
                }

                Escrita.Close();
            }
         
            return destino;
        }
    }
}
