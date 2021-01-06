using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio.Usuarios
{
    public interface IRepositorioDeUsuarios
    {
        Usuario BuscarUsuarioPorNomeESenha(string nome, string senha);
    }
}
