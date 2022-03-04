using Microsoft.EntityFrameworkCore;

namespace PortifolioAPI.Model
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions options): base(options)   
        { 
        
        
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }


    }
}
