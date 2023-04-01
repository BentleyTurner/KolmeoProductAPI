namespace KolmeoProductAPI.Models;
public class Product
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Price { get; set; }
    public string? Secret { get; set; }
}