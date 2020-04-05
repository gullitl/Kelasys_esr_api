using Kelasys.ESR.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kelasys.ESR.DataAccess {
    public class AppDbContext : DbContext {

        #region DbContext configurations
        public AppDbContext(DbContextOptions options) : base(options) { 
            Database.EnsureCreated();
            //Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            base.OnConfiguring(options);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        public virtual DbSet<Professeur> Professeurs { get; set; }
        //public virtual DbSet<Eleve> Eleves { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        //public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    }
}
