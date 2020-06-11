using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Models
{
    public class AgendamentosDbContext : DbContext
    {
        public AgendamentosDbContext(DbContextOptions<AgendamentosDbContext> options) : base(options)
        {

        }

        public DbSet<Agendamentos> Agendamentos { get; set; }
     
    }
}
