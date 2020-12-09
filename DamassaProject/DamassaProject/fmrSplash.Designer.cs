namespace DamassaProject
{
    partial class fmrSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrSplash));
            this.lb_Contador = new System.Windows.Forms.Label();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Contador
            // 
            this.lb_Contador.AutoSize = true;
            this.lb_Contador.Location = new System.Drawing.Point(199, 264);
            this.lb_Contador.Name = "lb_Contador";
            this.lb_Contador.Size = new System.Drawing.Size(35, 13);
            this.lb_Contador.TabIndex = 0;
            this.lb_Contador.Text = "label1";
            // 
            // pic_Image
            // 
            this.pic_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_Image.BackgroundImage")));
            this.pic_Image.Location = new System.Drawing.Point(29, 35);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(410, 215);
            this.pic_Image.TabIndex = 1;
            this.pic_Image.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fmrSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.pic_Image);
            this.Controls.Add(this.lb_Contador);
            this.Name = "fmrSplash";
            this.Text = "fmrSplash";
            this.Load += new System.EventHandler(this.fmrSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Contador;
        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.Timer timer1;
    }
}