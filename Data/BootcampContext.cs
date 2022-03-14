using DesafioBootcamp2.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioBootcamp2.Data
{
    public class BootcampContext : DbContext
    {
        public BootcampContext(DbContextOptions<BootcampContext> options) : base(options)
         { 
            
         }

        public DbSet<ClienteModel> ClientesModel { get; set; }

    }
}
