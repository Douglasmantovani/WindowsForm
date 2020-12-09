namespace DamassaProject
{
    partial class fmrLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrLogin));
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Entrar = new System.Windows.Forms.Button();
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.pic_Imagem = new System.Windows.Forms.PictureBox();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Cadastre_se = new System.Windows.Forms.Button();
            this.cbox_Idioma = new System.Windows.Forms.ComboBox();
            this.lb_Relogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(313, 161);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(133, 20);
            this.txb_Email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // bt_Entrar
            // 
            this.bt_Entrar.Location = new System.Drawing.Point(313, 265);
            this.bt_Entrar.Name = "bt_Entrar";
            this.bt_Entrar.Size = new System.Drawing.Size(59, 23);
            this.bt_Entrar.TabIndex = 2;
            this.bt_Entrar.Text = "Entrar";
            this.bt_Entrar.UseVisualStyleBackColor = true;
            this.bt_Entrar.Click += new System.EventHandler(this.bt_Entrar_Click);
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(313, 200);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.PasswordChar = '*';
            this.txb_Senha.Size = new System.Drawing.Size(133, 20);
            this.txb_Senha.TabIndex = 3;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(359, 184);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 4;
            this.Senha.Text = "Senha";
            // 
            // pic_Imagem
            // 
            this.pic_Imagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Imagem.BackgroundImage")));
            this.pic_Imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_Imagem.Location = new System.Drawing.Point(12, 35);
            this.pic_Imagem.Name = "pic_Imagem";
            this.pic_Imagem.Size = new System.Drawing.Size(198, 164);
            this.pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Imagem.TabIndex = 6;
            this.pic_Imagem.TabStop = false;
            // 
            // pic_Logo
            // 
            this.pic_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Logo.BackgroundImage")));
            this.pic_Logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pic_Logo.ErrorImage")));
            this.pic_Logo.Location = new System.Drawing.Point(329, 35);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(95, 86);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Logo.TabIndex = 7;
            this.pic_Logo.TabStop = false;
            // 
            // bt_Sair
            // 
            this.bt_Sair.Location = new System.Drawing.Point(387, 265);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(59, 23);
            this.bt_Sair.TabIndex = 8;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Cadastre_se
            // 
            this.bt_Cadastre_se.Location = new System.Drawing.Point(340, 294);
            this.bt_Cadastre_se.Name = "bt_Cadastre_se";
            this.bt_Cadastre_se.Size = new System.Drawing.Size(75, 23);
            this.bt_Cadastre_se.TabIndex = 9;
            this.bt_Cadastre_se.Text = "Cadastre-se";
            this.bt_Cadastre_se.UseVisualStyleBackColor = true;
            this.bt_Cadastre_se.Click += new System.EventHandler(this.bt_Cadastre_se_Click);
            // 
            // cbox_Idioma
            // 
            this.cbox_Idioma.FormattingEnabled = true;
            this.cbox_Idioma.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.cbox_Idioma.Location = new System.Drawing.Point(313, 238);
            this.cbox_Idioma.Name = "cbox_Idioma";
            this.cbox_Idioma.Size = new System.Drawing.Size(133, 21);
            this.cbox_Idioma.TabIndex = 10;
            this.cbox_Idioma.Text = "PT-BR/EN-US";
            // 
            // lb_Relogio
            // 
            this.lb_Relogio.AutoSize = true;
            this.lb_Relogio.Location = new System.Drawing.Point(348, 9);
            this.lb_Relogio.Name = "lb_Relogio";
            this.lb_Relogio.Size = new System.Drawing.Size(35, 13);
            this.lb_Relogio.TabIndex = 11;
            this.lb_Relogio.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Idioma";
            // 
            // fmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Relogio);
            this.Controls.Add(this.cbox_Idioma);
            this.Controls.Add(this.bt_Cadastre_se);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.pic_Imagem);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txb_Senha);
            this.Controls.Add(this.bt_Entrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Email);
            this.Name = "fmrLogin";
            this.Text = "fmrLogin";
            this.Load += new System.EventHandler(this.fmrLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Entrar;
        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.PictureBox pic_Imagem;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Cadastre_se;
        private System.Windows.Forms.ComboBox cbox_Idioma;
        private System.Windows.Forms.Label lb_Relogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}