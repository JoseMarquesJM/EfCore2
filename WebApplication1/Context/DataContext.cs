using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Context
{
    public class DataContext: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Aluno>()
                .Property(x => x.Nome)
                .HasMaxLength(50);
        }
    }
    

    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
    }
}
