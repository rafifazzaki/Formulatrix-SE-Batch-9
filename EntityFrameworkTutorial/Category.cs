namespace EntityFrameworkTutorial;

public class Category
{
    //must be property
    public int CategoryId {get; set;}
    public string CategoryName {get; set;}
    public string Description  {get; set;}
    public ICollection<Product> Products {get; set;}
}
