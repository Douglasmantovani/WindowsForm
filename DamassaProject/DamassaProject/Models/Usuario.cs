using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamassaProject.Models
{
    class Usuario
    {
        public int Id { get; set; }
        public uint Tipo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime Nasimento { get; set; }
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Informe a senha do Usuario")]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "A senha deve conter no minimo 6 e no maximo 25")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do usuário")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
