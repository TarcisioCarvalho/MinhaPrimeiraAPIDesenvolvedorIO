using Microsoft.EntityFrameworkCore;

namespace MinhaPrimeiraAPI.Model
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
