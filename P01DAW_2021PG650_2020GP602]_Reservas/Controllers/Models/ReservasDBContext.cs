using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace P01DAW_2021PG650_2020GP602_Reservas.Models
{
    public class ReservasContext:DbContext
    {
        public ReservasContext(DbContextOptions<ReservasContext> options) : base(options);

 

}
    public DbSet<Reservas>Reservas { get; set;
    }
}

