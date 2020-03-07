using ClientesDDD.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDDD.Infra.Dados.Config
{
    public class ClientesDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public ClientesDbContext()
        {

        }

         public ClientesDbContext(DbContextOptions<ClientesDbContext> options) 
            : base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            return $"Server = (localdb)\\MSSQLLocalDB; Database = ClientesDDD; Trusted_Connection = True; MultipleActiveResultSets = True";
        }
    }
}

