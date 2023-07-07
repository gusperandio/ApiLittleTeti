namespace LittleTeti.Models;

public class Solicitation
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public User User { get; set; }
    public IList<Product> Products { get; set; }
    public string TrackingCode { get; set; }
}