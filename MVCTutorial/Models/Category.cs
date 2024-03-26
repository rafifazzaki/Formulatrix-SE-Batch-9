using System.ComponentModel;

namespace MVCTutorial.Models;

public class Category
{
    public int CategoryId {get; set;}
    [DisplayName("Category Name")]
    public string CategoryName {get; set;} = null!;
    public string? Description {get; set;}
    public ICollection<Product> Products {get; set;}

    public Category(){
        Products = new List<Product>();
    }
}
