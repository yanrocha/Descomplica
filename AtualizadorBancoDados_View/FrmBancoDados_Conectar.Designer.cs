namespace AtualizadorBancoDados_View
{
    partial class FrmBancoDados_Conectar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServer = new System.Windows.Forms.Label();
            this.TxtServer = new System.Windows.Forms.TextBox();
            this.LblBase = new System.Windows.Forms.Label();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.MaskedTextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.lblTipoServidor = new System.Windows.Forms.Label();
            this.CmbTipoServidor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(10, 46);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(81, 25);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server";
            // 
            // TxtServer
            // 
            this.TxtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServer.Location = new System.Drawing.Point(98, 43);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(308, 31);
            this.TxtServer.TabIndex = 3;
            // 
            // LblBase
            // 
            this.LblBase.AutoSize = true;
            this.LblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBase.Location = new System.Drawing.Point(10, 83);
            this.LblBase.Name = "LblBase";
            this.LblBase.Size = new System.Drawing.Size(65, 25);
            this.LblBase.TabIndex = 4;
            this.LblBase.Text = "Base";
            // 
            // TxtBase
            // 
            this.TxtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBase.Location = new System.Drawing.Point(98, 80);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(308, 31);
            this.TxtBase.TabIndex = 5;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(10, 120);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(93, 25);
            this.LblUsuario.TabIndex = 6;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(109, 117);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(297, 31);
            this.TxtUsuario.TabIndex = 7;
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(10, 157);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(79, 25);
            this.LblSenha.TabIndex = 8;
            this.LblSenha.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(109, 154);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(297, 31);
            this.TxtSenha.TabIndex = 9;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(149, 197);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(121, 91);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.Location = new System.Drawing.Point(283, 197);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(121, 91);
            this.BtnConectar.TabIndex = 12;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.Location = new System.Drawing.Point(15, 197);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(121, 91);
            this.BtnFechar.TabIndex = 10;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblTipoServidor
            // 
            this.lblTipoServidor.AutoSize = true;
            this.lblTipoServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServidor.Location = new System.Drawing.Point(10, 11);
            this.lblTipoServidor.Name = "lblTipoServidor";
            this.lblTipoServidor.Size = new System.Drawing.Size(153, 25);
            this.lblTipoServidor.TabIndex = 0;
            this.lblTipoServidor.Text = "Tipo Servidor";
            // 
            // CmbTipoServidor
            // 
            this.CmbTipoServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoServidor.FormattingEnabled = true;
            this.CmbTipoServidor.Items.AddRange(new object[] {
            "Selecionar",
            "SQL Server",
            "MySQL"});
            this.CmbTipoServidor.Location = new System.Drawing.Point(169, 4);
            this.CmbTipoServidor.Name = "CmbTipoServidor";
            this.CmbTipoServidor.Size = new System.Drawing.Size(235, 33);
            this.CmbTipoServidor.TabIndex = 1;
            // 
            // FrmBancoDados_Conectar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 297);
            this.Controls.Add(this.CmbTipoServidor);
            this.Controls.Add(this.lblTipoServidor);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.LblBase);
            this.Controls.Add(this.TxtServer);
            this.Controls.Add(this.lblServer);
            this.Name = "FrmBancoDados_Conectar";
            this.Text = "Conexão Banco de Dados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBancoDados_Conectar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox TxtServer;
        private System.Windows.Forms.Label LblBase;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.MaskedTextBox TxtSenha;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label lblTipoServidor;
        private System.Windows.Forms.ComboBox CmbTipoServidor;
    }
}