using Microsoft.EntityFrameworkCore;
using MVCTutorial.Models;
namespace MVCTutorial.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Category> Categories {get; set;}
    public DbSet<Product> Products {get; set;}

    // awal awal use this, but now use middleware. what needed: constructor, in program.cs (then we can save it to appsettings)
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=dbyanto.db");
    // }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Category>(category =>
		{
			category.HasKey(c => c.CategoryId);
			category.Property(c => c.CategoryName).IsRequired().HasMaxLength(40);
			category.Property(c => c.Description).IsRequired(false).HasMaxLength(100);
			category.HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
		});
		modelBuilder.Entity<Product>(product =>
		{
			product.HasKey(p => p.ProductId);
			product.Property(p => p.ProductName).IsRequired().HasMaxLength(40);
			product.Property(p => p.Description).IsRequired(false).HasMaxLength(100);
		});
		//Seeding
		modelBuilder.Entity<Category>().HasData(
			new Category { CategoryId = 1, CategoryName = "Electronics", Description = "Electronic Items" },
			new Category { CategoryId = 2, CategoryName = "Clothes", Description = "Dress Items" },
			new Category { CategoryId = 3, CategoryName = "Groceries", Description = "Grocery Items" }
		);
		modelBuilder.Entity<Product>().HasData(
			new Product { ProductId = 1, ProductName = "Laptop", Description = "Laptop", CategoryId = 1 },
			new Product { ProductId = 2, ProductName = "Mobile", Description = "Mobile", CategoryId = 1 },
			new Product { ProductId = 3, ProductName = "Shirt", Description = "Shirt", CategoryId = 2 },
			new Product { ProductId = 4, ProductName = "Jeans", Description = "Jeans", CategoryId = 2 },
			new Product { ProductId = 5, ProductName = "Rice", Description = "Rice", CategoryId = 3 },
			new Product { ProductId = 6, ProductName = "Wheat", Description = "Wheat", CategoryId = 3 }
		);
	}


}
