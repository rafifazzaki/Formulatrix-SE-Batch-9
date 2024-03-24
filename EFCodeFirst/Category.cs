using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst;

public class Category
{
    // classNameId = primary key automatically
    [Key]
    public int CategoryId {get; set;}
    [Required]
    [MaxLength(15)]
    // can be like this: [Required, MaxLength(15)]
    public string CategoryName { get; set; }
    [Column(TypeName ="ntext")]
    public string? Description { get; set; }
    public ICollection<Product> products {get; set;}
    public Category(){
        products = new HashSet<Product>();
    }
}
