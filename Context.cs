using fifaCoinsBestEver.Models;
using Microsoft.EntityFrameworkCore;

namespace fifaCoinsBestEver {
    public class Context : DbContext {
        public Context(DbContextOptions<Context> options) : base(options){}
        public DbSet<User> users { get; set; }
    }
}