using System.Data.Common;
using EntityFrameworkTutorial;
using Microsoft.EntityFrameworkCore;

public class Program{
    static void Main(){
        using (Northwind db = new Northwind()){
            bool status = db.Database.CanConnect();
            Console.WriteLine($"Can connect: {status}");

            // Retrieve/Read
                //LINQ:
                    // Select
                    // Order
                    // OrderByDesc
                    // Where
                    // FirstOrDefault
                    // SelectMany (jarang dipake)
            var Categories = db.Categories.ToList();
            // foreach (var Category in Categories)
            // {
            //     Console.WriteLine($"{Category.CategoryId} {Category.CategoryName} {Category.Description}");
            // }

            Category? category = db.Categories.Find(1);
            Category? category1 = db.Categories.Where(c => c.CategoryId == 1).FirstOrDefault();
            Category? category2 = db.Categories.Where(c => c.CategoryName.Contains("Seafood")).FirstOrDefault();
            if(category2 != null){
                Console.WriteLine($"{category2.CategoryId} {category2.CategoryName} {category2.Description}");
            }

            // Create
            // Category category3 = new Category(){
            //     CategoryName = "Something",
            //     Description = "Something new on Category"
            // };
            // db.Categories.Add(category3);
            // db.SaveChanges();

            // Update
            Category something = db.Categories.Where(c => c.CategoryName == "Something").FirstOrDefault();
            // if(something != null){
            //     something.Description = "Something changed";
            // }
            // db.SaveChanges();

            // Delete
            // if(something is not null){
            //     db.Categories.Remove(something);
            //     db.SaveChanges();
            // }

            string search = "Beverages";
            IEnumerable<Category> categories = db.Categories
            .Where(c => c.CategoryName.Contains(search)).
            Include(c => c.Products).ToList(); //include => Eager Loading

            foreach (var item in categories)
            {
                Console.WriteLine($"{item.CategoryId} {item.CategoryName} {item.Description}");
				Console.WriteLine(item.Products.Count());
                foreach (var product in item.Products)
                {
                    Console.WriteLine($"\t{product.ProductName}");
                }
            }

            // Create New Product
            // Product product1 = new Product(){
            //     ProductName = "Something's Drink",
            //     CategoryId = 1
            // };
            // db.Products.Add(product1);
            // db.SaveChanges();
            
            var productDelete = db.Products.Where(c => c.ProductName.Contains("Something's Drink")).FirstOrDefault();
            if(productDelete != null){
                db.Products.Remove(productDelete);
                db.SaveChanges();
            }
        }
    }
}