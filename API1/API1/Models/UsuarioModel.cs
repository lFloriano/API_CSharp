using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API1.Models
{
    public class UsuarioModel
    {
        private int codigo;
        private string nome;
        private string login;

        public UsuarioModel() { }

        public UsuarioModel(int codigo, string nome, string login)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Login = login;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }

    }
}