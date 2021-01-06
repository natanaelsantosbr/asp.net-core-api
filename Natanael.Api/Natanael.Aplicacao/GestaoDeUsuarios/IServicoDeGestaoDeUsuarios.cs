using Natanael.Aplicacao.GestaoDeUsuarios.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Aplicacao.GestaoDeUsuarios
{
    public interface IServicoDeGestaoDeUsuarios
    {
        string GerarToken(ModeloDeLogin usuario);
    }
}
