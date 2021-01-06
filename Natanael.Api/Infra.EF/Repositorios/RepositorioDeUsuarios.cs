using Infra.EF.Context;
using Natanael.Dominio.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.EF.Repositorios
{
    public class RepositorioDeUsuarios : IRepositorioDeUsuarios
    {
        private readonly Contexto _contexto;
        public RepositorioDeUsuarios(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public Usuario BuscarUsuarioPorNomeESenha(string nome, string senha)
        {
            return this._contexto.Set<Usuario>().FirstOrDefault(a => a.Nome.ToLower() == nome.ToLower() && a.Senha.ToLower() == senha.ToLower());
        }
    }
}
