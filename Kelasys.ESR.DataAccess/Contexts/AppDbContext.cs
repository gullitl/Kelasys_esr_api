using Kelasys.ESR.Entity;
using Microsoft.EntityFrameworkCore;

namespace Kelasys.ESR.DataAccess.Contexts {
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

            modelBuilder.Entity<AnneeScolaire>()
                .HasKey(a => new { a.AnneeEnseignement, a.NiveauxEnseignement });
            
            modelBuilder.Entity<Eleve>()
                .HasOne(e => e.AnneeScolaire)
                .WithMany(a => a.Eleves)
                .HasForeignKey(e => new { e.AnneeEnseignement, e.NiveauxEnseignement });

            modelBuilder.Entity<Membre>()
                .HasOne(m => m.Utilisateur)
                .WithOne(u => u.Membre)
                .HasForeignKey<Utilisateur>(u => u.MembreId);
        }

        #endregion

        public virtual DbSet<Professeur> Professeurs { get; set; }
        public virtual DbSet<Eleve> Eleves { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<AnneeScolaire> AnneeScolaires { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    }
}
