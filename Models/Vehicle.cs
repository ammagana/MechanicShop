namespace MechanicShop.Models;

public class Vehicle{
    public long Id { get; set;}
    public int Year { get; set;}
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int Engine { get; set; }
    public virtual required Customer Customer { get; set;}
}