using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public string CategoryId {get; set;}
    public short Stock {get; set;}
    public int Price {get; set;}
    public Category Category {get; set;}
}
