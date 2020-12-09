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
    public partial class fmrAdministrador : Form
    {
        public fmrAdministrador()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_ListarUsuarios_Click(object sender, EventArgs e)
        {
            new fmrListarUsuario().ShowDialog();
        }

        private void fmrAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
