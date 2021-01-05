using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Natanael.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF.Mapeamentos
{
    public class MapeamentoDeClientes : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
        }
    }
}
