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
    public partial class fmrCadastro : Form
    {
        public fmrCadastro()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UsuarioRepository usuarioRepository = new UsuarioRepository();

            bool campos = true;

            Usuario u = new Usuario();
            u.Tipo = 1;
            u.Nome = txb_Nome.Text;
            u.Sobrenome = txb_Sobrenome.Text;
            u.Nasimento = dtp_Nascimento.Value;
            u.Endereco = txb_Endereco.Text;
            u.Telefone = txb_Telefone.Text;
            u.NomeUsuario = txb_Usuario.Text;
            u.Email = txb_Email.Text;
            u.Senha = txb_Senha.Text;
            string confirmarSenha = txb_ConfirmarSenha.Text;

            if (u.Email.Length == 0)
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Email", "Erro");
            }

            if (u.Nome.Length == 0)
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Nome", "Erro");
            }

            if (u.Sobrenome.Length == 0)
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Sobrenome", "Erro");
            }

            if (u.Endereco.Length == 0)
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Endereço", "Erro");
            }

            if (u.Telefone.Length == 0)
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Telefone", "Erro");
            }

            if (u.Nome.Length == 0)
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Nome", "Erro");
            }
            if (u.Senha.Length == 0)
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Senha", "Erro");
            }
            if (confirmarSenha.Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha o campo Confirmar senha", "Erro");
            }
            if (!confirmarSenha.Equals(u.Senha))
            {
                campos = false;
                SystemSounds.Beep.Play();
                MessageBox.Show("As senhas tem que ser iguais", "Erro");
            }

            if (campos == true)
            {   
                usuarioRepository.Adicionar(u);
                this.Hide();
                this.Close();
                new fmrUsuario().ShowDialog();
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha Todos os campos corretamente", "Erro");
            }

        }

        private void fmrCadastro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
