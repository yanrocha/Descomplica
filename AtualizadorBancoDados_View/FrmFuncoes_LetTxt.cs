using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtualizadoBancoDados_Controller;

namespace AtualizadorBancoDados_View
{
    public partial class FrmFuncoes_LetTxt : Form
    {
        private CArquivo _Arquivo = new CArquivo();
        private CBancoDados _BancoDados = new CBancoDados();

        public FrmFuncoes_LetTxt()
        {
            InitializeComponent();
        }

        private void FrmFuncoes_LetTxt_Load(object sender, EventArgs e)
        {
            TxtMileSeconds.Text = "0";
        }

        private void BtnCaminho_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Selecione o arquivo .TXT";
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    TxtCaminho.Text += arquivo;
                }
            }
        }

        private void FrmFuncoes_LetTxt_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).lerTxtToolStripMenuItem.Enabled = true;
        }

        private void TxtCaminho_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Texto = _Arquivo.RetornaTexto(TxtCaminho.Text.Trim());

                if(Texto.Trim() != "")
                {
                    TxtArquivoTXT.Text = Texto;
                }

            }
            catch
            {

            }
        }

        private void BtnBloquear_Click(object sender, EventArgs e)
        {
            TxtArquivoTXT.ReadOnly = !TxtArquivoTXT.ReadOnly;
        }

        private void BtnExecutarSql_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = TxtArquivoTXT.Lines.Count();
            progressBar1.Value = 0;

            string Caminho = _Arquivo.CopiarArquivo(TxtCaminho.Text);

            using (StreamReader sr = new StreamReader(Caminho))
            {
                String Comando;
                while ((Comando = sr.ReadLine()) != null)
                {
                    SqlConnection odb = AtualizadorBancoDados_Repository.Helper.SqlConection.getConnection();
                    SqlCommand oComando = new SqlCommand(Comando, odb);
                    oComando.ExecuteNonQuery();
                    oComando.Dispose();
                    odb.Close();
                    System.Threading.Thread.Sleep(Convert.ToInt32(TxtMileSeconds.Text));
                    progressBar1.Value++;
                }
            }
        }
    }
}
