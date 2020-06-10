
using Microsoft.EntityFrameworkCore;

namespace ControleDeSalasBackEnd.Models

{
    public class SalasDBContext : DbContext
{
    public SalasDBContext(DbContextOptions<SalasDBContext> options) : base(options)
    {

    }

    public DbSet<Salas> Salas { get; set; }
}
}