using Infra.EF.Context;
using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.EF.Repositorios
{
    public class RepositorioDeClientes : IRepositorioDeClientes
    {
        private Contexto _contexto;

        public RepositorioDeClientes(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public void Atualizar(Cliente cliente)
        {
            this._contexto.Set<Cliente>().Update(cliente);
        }

        public Cliente BuscarPorId(int id)
        {
            return this._contexto.Set<Cliente>().FirstOrDefault(a => a.Id == id);
        }

        public void Cadastrar(Cliente cliente)
        {
            this._contexto.Set<Cliente>().Add(cliente);
        }

        public void Excluir(Cliente cliente)
        {
            this._contexto.Set<Cliente>().Remove(cliente);
        }

        public List<Cliente> Listar()
        {
            return this._contexto.Set<Cliente>().ToList();
        }
    }
}
