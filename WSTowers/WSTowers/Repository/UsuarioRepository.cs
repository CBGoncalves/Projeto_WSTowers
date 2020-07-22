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
        public void Adicionar(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }/*
        public Usuario Login(string Email, string Senha)
        {
            return Usuarios.Find(u => u.Email == Email && u.Senha == Senha);
        }
        */
    }
}
