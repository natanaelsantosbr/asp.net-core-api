using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio.Clientes
{
    public interface IRepositorioDeClientes
    {
        List<Cliente> Listar();

        Cliente BuscarPorId(int id);

        void Cadastrar(Cliente cliente);

        void Atualizar(Cliente cliente);

        void Excluir(Cliente cliente);
    }
}
