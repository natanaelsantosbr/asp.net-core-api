using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.GestaoDeClientes
{
    public interface IServicoDeGestaoDeClientes
    {
        ModeloDeRetornoDaLista Listar();
    }
}
