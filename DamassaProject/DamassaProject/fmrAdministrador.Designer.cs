namespace DamassaProject
{
    partial class fmrAdministrador
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
            this.bt_ListarUsuarios = new System.Windows.Forms.Button();
            this.bt_GerenciarRelatorios = new System.Windows.Forms.Button();
            this.bt_GerenciarCompania = new System.Windows.Forms.Button();
            this.bt_GerenciarAvioes = new System.Windows.Forms.Button();
            this.bt_ListarAvioes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_ListarUsuarios
            // 
            this.bt_ListarUsuarios.Location = new System.Drawing.Point(12, 53);
            this.bt_ListarUsuarios.Name = "bt_ListarUsuarios";
            this.bt_ListarUsuarios.Size = new System.Drawing.Size(140, 96);
            this.bt_ListarUsuarios.TabIndex = 10;
            this.bt_ListarUsuarios.Text = "Listar Usuarios";
            this.bt_ListarUsuarios.UseVisualStyleBackColor = true;
            this.bt_ListarUsuarios.Click += new System.EventHandler(this.bt_ListarUsuarios_Click);
            // 
            // bt_GerenciarRelatorios
            // 
            this.bt_GerenciarRelatorios.Location = new System.Drawing.Point(256, 187);
            this.bt_GerenciarRelatorios.Name = "bt_GerenciarRelatorios";
            this.bt_GerenciarRelatorios.Size = new System.Drawing.Size(130, 91);
            this.bt_GerenciarRelatorios.TabIndex = 11;
            this.bt_GerenciarRelatorios.Text = "Gerenciar Relatorios";
            this.bt_GerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // bt_GerenciarCompania
            // 
            this.bt_GerenciarCompania.Location = new System.Drawing.Point(66, 187);
            this.bt_GerenciarCompania.Name = "bt_GerenciarCompania";
            this.bt_GerenciarCompania.Size = new System.Drawing.Size(140, 91);
            this.bt_GerenciarCompania.TabIndex = 12;
            this.bt_GerenciarCompania.Text = "Gerenciar Compania";
            this.bt_GerenciarCompania.UseVisualStyleBackColor = true;
            // 
            // bt_GerenciarAvioes
            // 
            this.bt_GerenciarAvioes.Location = new System.Drawing.Point(346, 53);
            this.bt_GerenciarAvioes.Name = "bt_GerenciarAvioes";
            this.bt_GerenciarAvioes.Size = new System.Drawing.Size(128, 96);
            this.bt_GerenciarAvioes.TabIndex = 13;
            this.bt_GerenciarAvioes.Text = "Gerenciar Aviões";
            this.bt_GerenciarAvioes.UseVisualStyleBackColor = true;
            // 
            // bt_ListarAvioes
            // 
            this.bt_ListarAvioes.Location = new System.Drawing.Point(180, 53);
            this.bt_ListarAvioes.Name = "bt_ListarAvioes";
            this.bt_ListarAvioes.Size = new System.Drawing.Size(136, 96);
            this.bt_ListarAvioes.TabIndex = 14;
            this.bt_ListarAvioes.Text = "Listar Aviões";
            this.bt_ListarAvioes.UseVisualStyleBackColor = true;
            // 
            // fmrAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 380);
            this.Controls.Add(this.bt_ListarAvioes);
            this.Controls.Add(this.bt_GerenciarAvioes);
            this.Controls.Add(this.bt_GerenciarCompania);
            this.Controls.Add(this.bt_GerenciarRelatorios);
            this.Controls.Add(this.bt_ListarUsuarios);
            this.Name = "fmrAdministrador";
            this.Text = "fmrAdministrador";
            this.Load += new System.EventHandler(this.fmrAdministrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ListarUsuarios;
        private System.Windows.Forms.Button bt_GerenciarRelatorios;
        private System.Windows.Forms.Button bt_GerenciarCompania;
        private System.Windows.Forms.Button bt_GerenciarAvioes;
        private System.Windows.Forms.Button bt_ListarAvioes;
    }
}