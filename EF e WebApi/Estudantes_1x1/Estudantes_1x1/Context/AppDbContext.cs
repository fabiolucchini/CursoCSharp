using Estudantes_1x1.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudantes_1x1.Context {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Estudante>? Estudantes { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }        
    }
}
