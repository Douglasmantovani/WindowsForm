using DamassaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamassaProject.Interfaces
{
    interface IAdministradorRepository
    {
        Usuario BuscarPorEmailSenha(string email,string senha); 
    }
}
