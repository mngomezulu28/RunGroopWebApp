using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;

namespace RunGroopWebApp.Deta
{
    public class DbContext
    {
        public DbContext(DbContextOptions<ApplicationDbContext> options)
        {
        }
    }
}