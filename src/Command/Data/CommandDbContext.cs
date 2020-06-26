using Command.Models;
using Microsoft.EntityFrameworkCore;

namespace Command.Data
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Commands> Commands { get; set; }
    }
}