using DamassaProject.Interfaces;
using DamassaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamassaProject.Repositories
{
    class UsuarioRepository : IUsuarioRepository
    {
       
       
        public static List<Usuario> usuarios = new List<Usuario>();

        public static int Contador = 1;


        public Usuario BuscarPorEmailSenha(string email,string senha)
        {
            Usuario usuarioAchado = usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

            return usuarioAchado;
        }

        public void Adicionar(Usuario u)
        {
            if (u == null)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Preencha Todos os campos", "Erro");
            }
            else
            {
                u.Id = Contador;
                usuarios.Add(u);
                Contador++;
            }
           
        }

        public List<Usuario> BuscarTodos()
        {
            return usuarios;
        }

        public void Deletar(int id)
        {
            Usuario UserDeletado=usuarios.Find(u => u.Id == id);
            usuarios.Remove(UserDeletado);
        }
    }
}
