using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamassaProject
{
    public partial class fmrSplash : Form
    {
        public fmrSplash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void fmrSplash_Load(object sender, EventArgs e)
        {

        }
        int contador=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            lb_Contador.Text = contador.ToString();
            pic_Image.Visible = !pic_Image.Visible;

            if (contador == 10)
            {
                timer1.Enabled = false;
                this.Hide();
                new fmrLogin().ShowDialog();
                this.Close();
            }
        }
    }
}
