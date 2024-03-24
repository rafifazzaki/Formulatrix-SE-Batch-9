using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst;

public class Northwind : DbContext
{
    public DbSet<Category> categories {get; set;}
    public DbSet<Product> products {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Northwind.db");
    }
}
