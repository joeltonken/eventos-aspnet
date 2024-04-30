using EventoApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EventoApplication.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<EventosModel> Eventos { get; set; }

    }
}
