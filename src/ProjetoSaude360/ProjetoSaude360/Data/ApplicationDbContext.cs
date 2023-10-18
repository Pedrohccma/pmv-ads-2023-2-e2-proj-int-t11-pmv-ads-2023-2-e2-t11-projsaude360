using Microsoft.EntityFrameworkCore;
using Saude360.Models;

namespace ProjetoSaude360.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cadastro>()
                .Property(c => c.Generos)
                .HasConversion(
                    e => e.ToString(),
                    e => Enum.Parse<Enums.Genero>(e));
                    //Enum.Parse(typeof(Enums.Genero), e)) ;
        }
    }
}
