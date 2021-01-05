using Infra.EF.Mapeamentos;
using Microsoft.EntityFrameworkCore;
using Natanael.Dominio.Clientes;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapeamentoDeClientes());
            base.OnModelCreating(modelBuilder);
        }
    }
}
