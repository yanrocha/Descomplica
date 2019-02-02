using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtualizadoBancoDados_Controller;

namespace AtualizadorBancoDados_View
{
    public partial class FrmPrincipal : Form
    {

        private CBancoDados _BancoDados = new CBancoDados();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBancoDados_Conectar oFrm = new FrmBancoDados_Conectar();
            oFrm.MdiParent = this;
            oFrm.Show();
            conectarToolStripMenuItem.Enabled = false;
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _BancoDados.teste();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void lerTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncoes_LetTxt oFrm = new FrmFuncoes_LetTxt();
            oFrm.MdiParent = this;
            oFrm.Show();
            conectarToolStripMenuItem.Enabled = false;
        }
    }
}
