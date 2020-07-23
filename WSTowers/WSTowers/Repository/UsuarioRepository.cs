using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WSTowers.Models;

namespace WSTowers.Repository
{
    class UsuarioRepository
    {
        private static List<Usuario> Usuarios;

        public UsuarioRepository()
        {
            if(Usuarios == null)
            {
                Usuarios = new List<Usuario>();

                Usuarios.Add(new Usuario
                {
                    Nome = "Ana Laura",
                    Apelido = "Ana",
                    Email = "analaurafeltrim@gmail.com",
                    Senha = "123",
                    
                });
                Usuarios.Add(new Usuario
                {
                    Nome = "Eduardo",
                    Apelido = "Duds",
                    Email = "duds@gmail.com",
                    Senha = "1234"
                });
            }
        }
        public void Adicionar(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }
        public Usuario Login(string Email, string Senha)
        {
            return Usuarios.Find(u => u.Email == Email && u.Senha == Senha);
        }
        
    }
}
