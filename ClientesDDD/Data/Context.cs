using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClientesDDD.Dominio.Entidades;

namespace ClientesDDD.Data.ClienteMVCController
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<ClientesDDD.Dominio.Entidades.Cliente> Cliente { get; set; }
    }
}
