using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio.Usuarios
{
    public class Usuario : Entidade
    {
        public Usuario()
        {

        }

        public Usuario(int id, string nome, string senha, string funcao)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Funcao = funcao;
        }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Funcao { get; set; }
    }
}
