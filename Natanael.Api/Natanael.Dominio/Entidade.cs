using System;
using System.Collections.Generic;
using System.Text;

namespace Natanael.Dominio
{
    public class Entidade
    {
        public Entidade()
        {
            this.DataDoCadastro = DateTime.Now;
        }

        public int Id { get; protected set; }

        public DateTime DataDoCadastro { get; protected set; }
    }
}
