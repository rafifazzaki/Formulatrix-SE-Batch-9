using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst;

public class Northwind : DbContext
{
    public DbSet<Category> Categories {get; set;}
    public DbSet<Product> Products {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlite("Data Source=Northwind.db");

		//Must install :
		// - Npgsql.EntityFrameworkCore.PostgreSQL
		// - PostgreSQL
		optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydatabase;Username=postgres;Password=postgres");
    }

    protected override void OnModelCreating(ModelBuilder builder) 
    {
        builder.Entity<Category>(c => {
            c.HasKey(c => c.CategoryId);
            c.Property(c => c.CategoryName).IsRequired(true).HasMaxLength(15);
            c.Property(c => c.Description).IsRequired(false);
            c.HasMany(c => c.Products);
        });

        builder.Entity<Product>(p =>
		{
			p.HasKey(p => p.ProductId);
			p.Property(p => p.ProductName).IsRequired(true).HasMaxLength(40);
			p.Property(p => p.Stock).HasColumnType("smallint").HasColumnName("UnitsInStock");
			p.HasOne(p => p.Category);
		});
        // Data Seeding
        builder.Entity<Category>().HasData(
            new Category() 
			{
				CategoryId = 1,
				CategoryName = "Beverages",
				Description = "Soft drinks, coffees, teas, beers, and ales"
			},
			new Category() 
			{
				CategoryId = 2,
				CategoryName = "Yanto",
				Description = "Yanto is human being"
			}
        );

        

    }
}
