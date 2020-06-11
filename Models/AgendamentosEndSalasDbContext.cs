using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeSalasBackEnd.Models
{
    public class AgendamentosEndSalasDbContext : DbContext
    {
        public AgendamentosEndSalasDbContext(DbContextOptions<AgendamentosEndSalasDbContext> options) : base(options)
        {

        }

        public DbSet<Agendamentos> Agendamentos { get; set; }
        public DbSet<Salas> Salas { get; set; }
        
    }
}
