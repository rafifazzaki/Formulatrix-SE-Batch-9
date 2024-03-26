using Microsoft.EntityFrameworkCore;
using APITutorial.Model;


namespace APITutorial.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Category> Categories {get; set;}
    public DbSet<Product> Products {get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(cat => {
            cat.HasKey(c => c.CategoryId);
            cat.Property(c => c.CategoryName).IsRequired().HasMaxLength(50);
            cat.Property(c => c.Description).IsRequired(false).HasMaxLength(200);
            cat.HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
        });
        modelBuilder.Entity<Product>(pro => {
            pro.HasKey(p => p.ProductId);
            pro.Property(p => p.ProductName).IsRequired().HasMaxLength(50);
            pro.Property(p => p.Description).IsRequired(false).HasMaxLength(200);
            pro.Property(p => p.UnitPrice).HasColumnType("decimal(18,2)");
            pro.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
        });
        // data seeding
        modelBuilder.Entity<Category>().HasData(
            new Category {CategoryId = 1, CategoryName = "Electronics", Description = "Electronic Items"},
            new Category {CategoryId = 2, CategoryName = "Clothes", Description = "Clothes Items"},
            new Category {CategoryId = 3, CategoryName = "Grocery", Description = "Grocery Items"}
        );
        modelBuilder.Entity<Product>().HasData(
            new Product {ProductId = 1, ProductName = "Laptop", Description = "Laptop", UnitPrice = 50000, CategoryId = 1},
            new Product { ProductId = 2, ProductName = "Mobile", Description = "Mobile", UnitPrice = 20000, CategoryId = 1 },
			new Product { ProductId = 3, ProductName = "Shirt", Description = "Shirt", UnitPrice = 1000, CategoryId = 2 },
			new Product { ProductId = 4, ProductName = "Pant", Description = "Pant", UnitPrice = 1500, CategoryId = 2 },
			new Product { ProductId = 5, ProductName = "Rice", Description = "Rice", UnitPrice = 50, CategoryId = 3 },
			new Product { ProductId = 6, ProductName = "Dal", Description = "Dal", UnitPrice = 100, CategoryId = 3 }
        );
    }
}
