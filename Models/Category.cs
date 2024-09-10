using MyMvcApp.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }

    // Navigation property
    public virtual ICollection<Product> Products { get; set; }
}
