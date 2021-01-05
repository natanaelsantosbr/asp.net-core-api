using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF
{
    public interface IServicoExternoDePersistencia
    {
        IRepositorioDeClientes RepositorioDeClientes { get; }

        void Persistir();
    }
}
