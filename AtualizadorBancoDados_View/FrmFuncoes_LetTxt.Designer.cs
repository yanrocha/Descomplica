namespace AtualizadorBancoDados_View
{
    partial class FrmFuncoes_LetTxt
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
            this.LblCaminho = new System.Windows.Forms.Label();
            this.TxtCaminho = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCaminho = new System.Windows.Forms.Button();
            this.TxtArquivoTXT = new System.Windows.Forms.RichTextBox();
            this.BtnBloquear = new System.Windows.Forms.Button();
            this.BtnExecutarSql = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblSleep = new System.Windows.Forms.Label();
            this.TxtMileSeconds = new System.Windows.Forms.TextBox();
            this.lblMileSeconds = new System.Windows.Forms.Label();
            this.LblConcat = new System.Windows.Forms.Label();
            this.TxtConcat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCaminho
            // 
            this.LblCaminho.AutoSize = true;
            this.LblCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaminho.Location = new System.Drawing.Point(12, 24);
            this.LblCaminho.Name = "LblCaminho";
            this.LblCaminho.Size = new System.Drawing.Size(104, 25);
            this.LblCaminho.TabIndex = 0;
            this.LblCaminho.Text = "Caminho";
            // 
            // TxtCaminho
            // 
            this.TxtCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCaminho.Location = new System.Drawing.Point(122, 21);
            this.TxtCaminho.Name = "TxtCaminho";
            this.TxtCaminho.ReadOnly = true;
            this.TxtCaminho.Size = new System.Drawing.Size(843, 31);
            this.TxtCaminho.TabIndex = 1;
            this.TxtCaminho.TextChanged += new System.EventHandler(this.TxtCaminho_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnCaminho
            // 
            this.BtnCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaminho.Location = new System.Drawing.Point(971, 21);
            this.BtnCaminho.Name = "BtnCaminho";
            this.BtnCaminho.Size = new System.Drawing.Size(63, 31);
            this.BtnCaminho.TabIndex = 2;
            this.BtnCaminho.Text = "...";
            this.BtnCaminho.UseVisualStyleBackColor = true;
            this.BtnCaminho.Click += new System.EventHandler(this.BtnCaminho_Click);
            // 
            // TxtArquivoTXT
            // 
            this.TxtArquivoTXT.Location = new System.Drawing.Point(17, 73);
            this.TxtArquivoTXT.Name = "TxtArquivoTXT";
            this.TxtArquivoTXT.ReadOnly = true;
            this.TxtArquivoTXT.Size = new System.Drawing.Size(1017, 301);
            this.TxtArquivoTXT.TabIndex = 3;
            this.TxtArquivoTXT.Text = "";
            // 
            // BtnBloquear
            // 
            this.BtnBloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBloquear.Location = new System.Drawing.Point(17, 410);
            this.BtnBloquear.Name = "BtnBloquear";
            this.BtnBloquear.Size = new System.Drawing.Size(123, 89);
            this.BtnBloquear.TabIndex = 4;
            this.BtnBloquear.Text = "Bloquear";
            this.BtnBloquear.UseVisualStyleBackColor = true;
            this.BtnBloquear.Click += new System.EventHandler(this.BtnBloquear_Click);
            // 
            // BtnExecutarSql
            // 
            this.BtnExecutarSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExecutarSql.Location = new System.Drawing.Point(166, 410);
            this.BtnExecutarSql.Name = "BtnExecutarSql";
            this.BtnExecutarSql.Size = new System.Drawing.Size(123, 89);
            this.BtnExecutarSql.TabIndex = 5;
            this.BtnExecutarSql.Text = "Sql";
            this.BtnExecutarSql.UseVisualStyleBackColor = true;
            this.BtnExecutarSql.Click += new System.EventHandler(this.BtnExecutarSql_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(613, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 89);
            this.button5.TabIndex = 8;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(762, 410);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 89);
            this.button6.TabIndex = 9;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(911, 410);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 89);
            this.button7.TabIndex = 10;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1017, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // lblSleep
            // 
            this.lblSleep.AutoSize = true;
            this.lblSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleep.Location = new System.Drawing.Point(295, 416);
            this.lblSleep.Name = "lblSleep";
            this.lblSleep.Size = new System.Drawing.Size(72, 25);
            this.lblSleep.TabIndex = 12;
            this.lblSleep.Text = "Sleep";
            // 
            // TxtMileSeconds
            // 
            this.TxtMileSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMileSeconds.Location = new System.Drawing.Point(387, 413);
            this.TxtMileSeconds.Name = "TxtMileSeconds";
            this.TxtMileSeconds.Size = new System.Drawing.Size(112, 31);
            this.TxtMileSeconds.TabIndex = 13;
            // 
            // lblMileSeconds
            // 
            this.lblMileSeconds.AutoSize = true;
            this.lblMileSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileSeconds.Location = new System.Drawing.Point(505, 431);
            this.lblMileSeconds.Name = "lblMileSeconds";
            this.lblMileSeconds.Size = new System.Drawing.Size(68, 13);
            this.lblMileSeconds.TabIndex = 14;
            this.lblMileSeconds.Text = "MileSeconds";
            // 
            // LblConcat
            // 
            this.LblConcat.AutoSize = true;
            this.LblConcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConcat.Location = new System.Drawing.Point(295, 459);
            this.LblConcat.Name = "LblConcat";
            this.LblConcat.Size = new System.Drawing.Size(86, 25);
            this.LblConcat.TabIndex = 15;
            this.LblConcat.Text = "Concat";
            // 
            // TxtConcat
            // 
            this.TxtConcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConcat.Location = new System.Drawing.Point(387, 456);
            this.TxtConcat.Name = "TxtConcat";
            this.TxtConcat.Size = new System.Drawing.Size(112, 31);
            this.TxtConcat.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Concatenar";
            // 
            // FrmFuncoes_LetTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtConcat);
            this.Controls.Add(this.LblConcat);
            this.Controls.Add(this.lblMileSeconds);
            this.Controls.Add(this.TxtMileSeconds);
            this.Controls.Add(this.lblSleep);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnExecutarSql);
            this.Controls.Add(this.BtnBloquear);
            this.Controls.Add(this.TxtArquivoTXT);
            this.Controls.Add(this.BtnCaminho);
            this.Controls.Add(this.TxtCaminho);
            this.Controls.Add(this.LblCaminho);
            this.Name = "FrmFuncoes_LetTxt";
            this.Text = "Ler Txt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFuncoes_LetTxt_FormClosed);
            this.Load += new System.EventHandler(this.FrmFuncoes_LetTxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCaminho;
        private System.Windows.Forms.TextBox TxtCaminho;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnCaminho;
        private System.Windows.Forms.RichTextBox TxtArquivoTXT;
        private System.Windows.Forms.Button BtnBloquear;
        private System.Windows.Forms.Button BtnExecutarSql;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.TextBox TxtMileSeconds;
        private System.Windows.Forms.Label lblMileSeconds;
        private System.Windows.Forms.Label LblConcat;
        private System.Windows.Forms.TextBox TxtConcat;
        private System.Windows.Forms.Label label2;
    }
}