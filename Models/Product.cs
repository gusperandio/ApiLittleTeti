namespace LittleTeti.Models;

public class Product
{
    public int Id { get; set; }
    public int Name { get; set; }
    public decimal Price { get; set; }
    public decimal PriceFake { get; set; }
    public int Amount { get; set; }
    public string Description { get; set; }
    public bool Girl { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedAt { get; set; }
}