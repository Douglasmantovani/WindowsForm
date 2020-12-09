using DamassaProject.Interfaces;
using DamassaProject.Models;
using DamassaProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamassaProject
{
    public partial class fmrLogin : Form
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        private IAdministradorRepository _AdministradorRepository { get; set; }

        Usuario usuario = new Usuario();

        public fmrLogin()
        {
            InitializeComponent();

            _usuarioRepository = new UsuarioRepository();
            _AdministradorRepository = new AdminstradorReposirory();
        }

        private void bt_Cadastre_se_Click(object sender, EventArgs e)
        {
            new fmrCadastro().ShowDialog();
        }
        
        private void bt_Entrar_Click(object sender, EventArgs e)
        {        
            var email = txb_Email.Text.Trim();
            var senha = txb_Senha.Text.Trim();

            Usuario usuarioBuscado = _usuarioRepository.BuscarPorEmailSenha(email, senha);

            Usuario AdministradorBuscado = _AdministradorRepository.BuscarPorEmailSenha(email, senha);

            if (usuarioBuscado.Email == null|| usuarioBuscado.Senha == null)
            {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("O usuario ou senha esta incorreto", "Erro");                       
            }
            else if(usuarioBuscado.Email.Equals(email)&&usuarioBuscado.Senha.Equals(senha))
            {
                
                if(usuarioBuscado.Tipo == 1)
                {
                    MessageBox.Show("Bem Vindo:" + usuarioBuscado.NomeUsuario);
                    new fmrUsuario().ShowDialog();
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("O usuario ou senha esta incorreto", "Erro");
                }   
            }else if(AdministradorBuscado.Email.Equals(email) && AdministradorBuscado.Senha.Equals(senha))
            {
                if (AdministradorBuscado.Tipo == 0)
                {
                    MessageBox.Show("Bem Vindo:" + AdministradorBuscado.NomeUsuario);
                    new fmrAdministrador().ShowDialog();
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("O usuario ou senha esta incorreto", "Erro");
                }
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("O usuario ou senha esta incorreto", "Erro");
            }
        }
        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss:ff");
            lb_Relogio.Text = clock;
        }
    }
}
