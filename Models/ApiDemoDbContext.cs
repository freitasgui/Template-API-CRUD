using Microsoft.EntityFrameworkCore;

namespace templateAPI_core_7.Models
{
    public class ApiDemoDbContext: DbContext
    {
        public ApiDemoDbContext(DbContextOptions<ApiDemoDbContext> options) : base(options)
        { 
            
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Salas> Salas { get; set; }
    }
}
