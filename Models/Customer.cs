using System.ComponentModel.DataAnnotations;

namespace MechanicShop.Models;

public class Customer{
    public long Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Phone { get; set; }
    public string? Address { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
}