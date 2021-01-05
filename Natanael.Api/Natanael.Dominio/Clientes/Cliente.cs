using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio.Clientes
{
    public class Cliente : Entidade
    {
        public Cliente()
        {

        }

        public Cliente(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public string Nome { get; protected set; }

        public string Email { get; protected set; }

        public string CPF { get; protected set; }

        public void AlterarDados(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }
}
