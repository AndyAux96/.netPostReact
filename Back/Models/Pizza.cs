namespace Back.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }

    public string? Sabor { get; set; }

    public bool Extra { get; set; }

}