namespace DamassaProject
{
    partial class fmrUsuario
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
            this.bt_ListarAvios = new System.Windows.Forms.Button();
            this.bt_GerenciarRelatorios = new System.Windows.Forms.Button();
            this.bt_GerenciarCompania = new System.Windows.Forms.Button();
            this.bt_GerenciarAvioes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_ListarAvios
            // 
            this.bt_ListarAvios.Location = new System.Drawing.Point(22, 44);
            this.bt_ListarAvios.Name = "bt_ListarAvios";
            this.bt_ListarAvios.Size = new System.Drawing.Size(96, 103);
            this.bt_ListarAvios.TabIndex = 4;
            this.bt_ListarAvios.Text = "Listar Aviões";
            this.bt_ListarAvios.UseVisualStyleBackColor = true;
            // 
            // bt_GerenciarRelatorios
            // 
            this.bt_GerenciarRelatorios.Location = new System.Drawing.Point(156, 163);
            this.bt_GerenciarRelatorios.Name = "bt_GerenciarRelatorios";
            this.bt_GerenciarRelatorios.Size = new System.Drawing.Size(96, 103);
            this.bt_GerenciarRelatorios.TabIndex = 5;
            this.bt_GerenciarRelatorios.Text = "Gerenciar Relatorios";
            this.bt_GerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // bt_GerenciarCompania
            // 
            this.bt_GerenciarCompania.Location = new System.Drawing.Point(22, 163);
            this.bt_GerenciarCompania.Name = "bt_GerenciarCompania";
            this.bt_GerenciarCompania.Size = new System.Drawing.Size(96, 103);
            this.bt_GerenciarCompania.TabIndex = 6;
            this.bt_GerenciarCompania.Text = "Gerenciar Compania";
            this.bt_GerenciarCompania.UseVisualStyleBackColor = true;
            // 
            // bt_GerenciarAvioes
            // 
            this.bt_GerenciarAvioes.Location = new System.Drawing.Point(156, 44);
            this.bt_GerenciarAvioes.Name = "bt_GerenciarAvioes";
            this.bt_GerenciarAvioes.Size = new System.Drawing.Size(96, 103);
            this.bt_GerenciarAvioes.TabIndex = 7;
            this.bt_GerenciarAvioes.Text = "Gerenciar Aviões";
            this.bt_GerenciarAvioes.UseVisualStyleBackColor = true;
            // 
            // fmrUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 313);
            this.Controls.Add(this.bt_GerenciarAvioes);
            this.Controls.Add(this.bt_GerenciarCompania);
            this.Controls.Add(this.bt_GerenciarRelatorios);
            this.Controls.Add(this.bt_ListarAvios);
            this.Name = "fmrUsuario";
            this.Text = "fmrUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ListarAvios;
        private System.Windows.Forms.Button bt_GerenciarRelatorios;
        private System.Windows.Forms.Button bt_GerenciarCompania;
        private System.Windows.Forms.Button bt_GerenciarAvioes;
    }
}