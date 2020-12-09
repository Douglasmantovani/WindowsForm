using DamassaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamassaProject.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario BuscarPorEmailSenha(string email,string senha);

        List<Usuario> BuscarTodos();

        void Adicionar(Usuario u);

        void Deletar(int id);

    }
}
