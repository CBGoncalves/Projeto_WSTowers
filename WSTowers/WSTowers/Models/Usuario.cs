using System;
using System.Collections.Generic;
using System.Text;

namespace WSTowers.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
