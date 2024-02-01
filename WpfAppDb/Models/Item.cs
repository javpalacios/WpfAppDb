namespace WpfAppDb.Models;

public class Item
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUri { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}