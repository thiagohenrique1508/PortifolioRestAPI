using Microsoft.EntityFrameworkCore;
using PortifolioAPI.Model;

namespace ApiSimples.Model
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions options): base(options)   
        { 
        
        
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }


    }
}
