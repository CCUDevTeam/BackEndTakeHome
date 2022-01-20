using Microsoft.EntityFrameworkCore;
using TodoApp.DAL.Entities;

namespace TodoApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Todo>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasData(new Todo[]
            {
                new() { Id = 1, Title = "Christmas Shopping", Description = "Buy gifts for family", Completed = false, DueDate = new(2022, 12, 24) },
                new() { Id = 2, Title = "Buy Groceries", Description = "Get food for hungry children", Completed = false, DueDate = new(2023, 01, 15) }
            });
        });
    }
}