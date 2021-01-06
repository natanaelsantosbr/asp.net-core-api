using Infra.EF.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Natanael.Dominio.Clientes;
using Natanael.Dominio.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EF.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapeamentoDeClientes());
            modelBuilder.ApplyConfiguration(new MapeamentoDeUsuarios());

            base.OnModelCreating(modelBuilder);
        }
    }
}
