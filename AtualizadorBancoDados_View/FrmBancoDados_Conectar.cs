using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtualizadoBancoDados_Controller;
using AtualizadorBancoDados_Model;

namespace AtualizadorBancoDados_View
{
    public partial class FrmBancoDados_Conectar : Form
    {

        private CBancoDados _BancoDados = new CBancoDados();

        public FrmBancoDados_Conectar()
        {
            InitializeComponent();
        }

        public void LimpaControles()
        {
            CmbTipoServidor.SelectedIndex = 0;
            TxtServer.Text = "";
            TxtBase.Text = "";
            TxtUsuario.Text = "";
            TxtSenha.Text = "";
            CmbTipoServidor.Focus();
        }

        public bool ValidaControles()
        {
            bool retorno = false;

            if(CmbTipoServidor.SelectedIndex != 0)
            {
                if(TxtServer.Text != "")
                {
                    if(TxtBase.Text != "")
                    {
                        if (TxtUsuario.Text != "")
                        {
                            if (TxtSenha.Text != "")
                            {
                                retorno = true;
                            }
                            else
                            {
                                MessageBox.Show("Você deve especificar a Senha");
                                TxtSenha.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Você deve especificar o Usuario");
                            TxtUsuario.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você deve especificar a Base");
                        TxtBase.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Você deve especificar o Servidor");
                    TxtServer.Focus();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar um tipo de servidor");
                CmbTipoServidor.Focus();                
            }

            return retorno;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaControles();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if(ValidaControles())
            {
                BancoDados oBancoDados = new BancoDados();
                oBancoDados.TipoServidor = CmbTipoServidor.SelectedText;
                oBancoDados.Server = TxtServer.Text.Trim();
                oBancoDados.Base = TxtBase.Text.Trim();
                oBancoDados.Usuario = TxtUsuario.Text.Trim();
                oBancoDados.Senha = TxtSenha.Text.Trim();                
                string Retorno = _BancoDados.Conectar(oBancoDados);
                MessageBox.Show(Retorno);
            }
        }

        private void FrmBancoDados_Conectar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).conectarToolStripMenuItem.Enabled = true;
        }
    }
}
