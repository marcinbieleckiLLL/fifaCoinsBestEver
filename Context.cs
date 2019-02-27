using fifaCoinsBestEver.dte;
using fifaCoinsBestEver.Models;
using Microsoft.EntityFrameworkCore;

namespace fifaCoinsBestEver {
    public class Context : DbContext {
        public Context(DbContextOptions<Context> options) : base(options){}
        public DbSet<User> users { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Transaction> transations { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<UserRoleType> userRoleTypes { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
    }
}