using Microsoft.EntityFrameworkCore;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class AppContext : DbContext {

        public DbSet<User> Users { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Historical> Historicals { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Shed> Sheds { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }
        public DbSet<TypeDoc> TypeDocs { get; set; }
        public DbSet<AssignedShed> AssignedSheds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            if ( !optionsBuilder.IsConfigured ) {
                optionsBuilder
                .UseSqlServer("Data Source = DIRAF-TELEM15\\SQLEXPRESS; Initial Catalog = Galpon; TRUSTED_CONNECTION = TRUE");
            }

        }

    }

}