using Microsoft.EntityFrameworkCore;

namespace FCode_CRUD.Models
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)  :base(options)
        {
            
        }
        public DbSet<Users> TUsers { get; set; }
    }
}
