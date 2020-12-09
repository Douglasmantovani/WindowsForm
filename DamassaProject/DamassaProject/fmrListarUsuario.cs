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
    public partial class fmrListarUsuario : Form
    {
        public fmrListarUsuario()
        {
            InitializeComponent();
        }
        private void bt_VoltarPaginaAnterior_Click(object sender, EventArgs e)
        {
            new fmrAdministrador().ShowDialog();
        }
        private void bt_ListarUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();

            List<Usuario> usuarios = usuarioRepository.BuscarTodos();
           

            dgv_ListarUsuario.DataSource = usuarios;
        }

        private void fmrListarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioRepository repository = new UsuarioRepository();
            

           dgv_ListarUsuario.DataSource = repository.BuscarTodos();
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            dgv_ListarUsuario.DataSource = null;

            UsuarioRepository usuarioRepository = new UsuarioRepository();

            bool campos = true;

            Usuario u = new Usuario();
            u.Tipo = 1;
            u.Nome = txb_Nome.Text;
            u.Sobrenome=txb_Sobrenome.Text;
            u.Nasimento = dt_Nascimento.Value;
            u.Endereco=txb_Endereco.Text;
            u.Telefone=txb_Telefone.Text;
            u.NomeUsuario=txb_NomeUsuario.Text;
            u.Email=txb_Email.Text;
            u.Senha=txb_Senha.Text;
            string confirmarSenha = txb_ConfirmarSenha.Text;

            if (u.Email.Length==0)
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
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha Todos os campos corretamente", "Erro");
            }  
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            new fmrLogin().ShowDialog();
        }

        private void bt_DeletarUsuario_Click(object sender, EventArgs e)
        {
            dgv_ListarUsuario.DataSource = null;

            UsuarioRepository usuarioRepository = new UsuarioRepository();

            Usuario userDeletado = new Usuario();

            int Id = int.Parse(tbx_id.Text);

            usuarioRepository.Deletar(Id);
        }
    }
}
