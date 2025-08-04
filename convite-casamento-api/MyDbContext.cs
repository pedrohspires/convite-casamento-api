using convite_casamento_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace convite_casamento_api
{
    public class MyDbContext : DbContext
    {
        public DbSet<Convidado> Convidado { get; set; }
        public DbSet<ConvidadoAcompanhante> ConvidadoAcompanhante { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
