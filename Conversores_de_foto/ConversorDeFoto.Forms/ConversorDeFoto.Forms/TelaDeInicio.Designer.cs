namespace ConversorDeFoto.Forms
{
    partial class TelaDeInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_SelecionarImagem = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.bt_ArrayToImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_SelecionarImagem
            // 
            this.bt_SelecionarImagem.Location = new System.Drawing.Point(104, 48);
            this.bt_SelecionarImagem.Name = "bt_SelecionarImagem";
            this.bt_SelecionarImagem.Size = new System.Drawing.Size(303, 23);
            this.bt_SelecionarImagem.TabIndex = 0;
            this.bt_SelecionarImagem.Text = "Selecione uma imagen para converter em byte";
            this.bt_SelecionarImagem.UseVisualStyleBackColor = true;
            this.bt_SelecionarImagem.Click += new System.EventHandler(this.bt_SelecionarImagem_Click);
            // 
            // Imagen
            // 
            this.Imagen.Location = new System.Drawing.Point(104, 98);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(569, 270);
            this.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Imagen.TabIndex = 1;
            this.Imagen.TabStop = false;
            this.Imagen.Click += new System.EventHandler(this.Imagen_Click);
            // 
            // bt_ArrayToImage
            // 
            this.bt_ArrayToImage.Location = new System.Drawing.Point(417, 48);
            this.bt_ArrayToImage.Name = "bt_ArrayToImage";
            this.bt_ArrayToImage.Size = new System.Drawing.Size(256, 23);
            this.bt_ArrayToImage.TabIndex = 2;
            this.bt_ArrayToImage.Text = "Converter array de byte em imagem";
            this.bt_ArrayToImage.UseVisualStyleBackColor = true;
            this.bt_ArrayToImage.Click += new System.EventHandler(this.bt_ArrayToImage_Click);
            // 
            // TelaDeInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.bt_ArrayToImage);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.bt_SelecionarImagem);
            this.Name = "TelaDeInicio";
            this.Text = "Selecione uma imagen";
            this.Load += new System.EventHandler(this.TelaDeInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_SelecionarImagem;
        private System.Windows.Forms.PictureBox Imagen;
        private System.Windows.Forms.Button bt_ArrayToImage;
    }
}

