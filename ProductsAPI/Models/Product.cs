namespace ProductsAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public int Stock { get; set; }
    public string? Category { get; set; }
}