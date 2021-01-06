using Infra.EF.Context;
using Infra.EF.Repositorios;
using Natanael.Dominio.Clientes;
using Natanael.Dominio.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF
{
    public class ServicoExternoDePersistenciaViaEF : IServicoExternoDePersistencia, IDisposable
    {
        private readonly Contexto _contexto;

        public ServicoExternoDePersistenciaViaEF(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public IRepositorioDeClientes RepositorioDeClientes => new RepositorioDeClientes(this._contexto);

        public IRepositorioDeUsuarios RepositorioDeUsuarios => new RepositorioDeUsuarios(this._contexto);

        public void Dispose()
        {
            if (this._contexto != null)
                this._contexto.Dispose();

            GC.SuppressFinalize(this);
        }

        public void Persistir()
        {
            this._contexto.SaveChanges();
        }
    }
}
