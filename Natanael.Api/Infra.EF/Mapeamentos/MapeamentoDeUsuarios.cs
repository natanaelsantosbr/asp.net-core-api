using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Natanael.Dominio.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF.Mapeamentos
{
    public class MapeamentoDeUsuarios : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
        }
    }
}
