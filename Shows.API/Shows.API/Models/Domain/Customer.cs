using System.ComponentModel.DataAnnotations;

namespace Shows.API.Models.Domain;

public class Customer
{
    [Key] public int CustomerID { get; set; }
    [MaxLength(50)] public string FirstName { get; set; } = string.Empty;
    [MaxLength(100)] public string LastName { get; set; } = string.Empty;
    [MaxLength(100)] public string? PhoneNumber { get; set; }
    
    public ICollection<PurchasedTicket> PurchasedTickets { get; set; } = new HashSet<PurchasedTicket>();
}