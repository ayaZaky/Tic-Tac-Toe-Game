using Microsoft.EntityFrameworkCore;
using TicTacToe.Core.Models;

namespace TicTacToe.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Game> Games { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.BoardState).IsRequired();
            entity.Property(e => e.CurrentPlayer).IsRequired();
            entity.Property(e => e.CreatedAt).IsRequired();
        });
    }
}