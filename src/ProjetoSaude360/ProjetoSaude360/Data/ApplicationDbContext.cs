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
        public DbSet<Enum> Enums { get; set; }
    }
}
