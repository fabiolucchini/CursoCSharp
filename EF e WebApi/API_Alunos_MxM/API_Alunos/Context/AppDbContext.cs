using API_Alunos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Context {
    public class AppDbContext:DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Professor>? Professores { get; set; }        
        public DbSet<Materia>? Materias { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ProfessorMateria>().HasKey(i => new { i.ProfessorId, i.MateriaId });

        }
    }
}
