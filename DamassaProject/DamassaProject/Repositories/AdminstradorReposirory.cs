using DamassaProject.Interfaces;
using DamassaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamassaProject.Repositories
{
    class AdminstradorReposirory: IAdministradorRepository
    {
        public Usuario BuscarPorEmailSenha(string email, string senha)
        {
            Usuario usuario = new Usuario()
            {
                Id = 0,
                Tipo = 0,
                Nome = "Douglas",
                Sobrenome="Mantovani",
                Telefone = "0800771587",
                Endereco = "Rua Abençoada",
                NomeUsuario = "Master",
                Senha = "123123",
                Email = "Teste@hotmail.com"
            };
            return usuario;
        }
    }
}
