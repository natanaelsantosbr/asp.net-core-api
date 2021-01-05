using Infra.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.GestaoDeClientes
{
    public class ServicoDeGestaoDeClientes : IServicoDeGestaoDeClientes
    {
        private IServicoExternoDePersistencia _servicoExternoDePersistencia;

        public ServicoDeGestaoDeClientes(IServicoExternoDePersistencia servicoExternoDePersistencia)
        {
            this._servicoExternoDePersistencia = servicoExternoDePersistencia;
        }

        public ModeloDeRetornoDaLista Listar()
        {
            try
            {
                var clientes = this._servicoExternoDePersistencia.RepositorioDeClientes.Listar();

                return new ModeloDeRetornoDaLista(true, MensagensPadronizadas.Sucesso, clientes);
            }
            catch (Exception ex)
            {
                return new ModeloDeRetornoDaLista(false, ex.Message);
            }
        }


    }
}
