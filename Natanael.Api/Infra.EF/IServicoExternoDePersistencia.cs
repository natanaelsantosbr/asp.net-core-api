using Natanael.Dominio.Clientes;
using Natanael.Dominio.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF
{
    public interface IServicoExternoDePersistencia
    {
        IRepositorioDeClientes RepositorioDeClientes { get; }

        IRepositorioDeUsuarios RepositorioDeUsuarios { get; }

        void Persistir();
    }
}
