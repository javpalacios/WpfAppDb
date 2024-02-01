using Microsoft.EntityFrameworkCore;
using WpfAppDb.Models;

namespace WpfAppDb.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Item> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Items)
                .HasForeignKey(d => d.CategoryId);
        });
}