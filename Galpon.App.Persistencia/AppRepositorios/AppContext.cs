using Microsoft.EntityFrameworkCore;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class AppContext : DbContext {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            if ( !optionsBuilder.IsConfigured ) {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Galpon");
            }

        }

    }

}