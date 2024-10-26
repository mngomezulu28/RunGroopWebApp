using Microsoft.EntityFrameworkCore;

namespace RunGroopWebApp.Data
{
    public class IdentityDbContext<T>
    {
        public IdentityDbContext(DbContextOptions<ApplicationDbContext> options)
        {
        }
    }
}