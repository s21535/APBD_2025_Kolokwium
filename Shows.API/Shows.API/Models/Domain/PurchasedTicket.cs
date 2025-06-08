using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shows.API.Models.Domain;

[Table("Purchased_Ticket")]
[PrimaryKey(nameof(TicketConcertId),nameof(CustomerId))]
public class PurchasedTicket
{
    public int TicketConcertId { get; set; }
    public int CustomerId { get; set; }
    public DateTime PurchaseDate { get; set; }
    
    [ForeignKey(nameof(CustomerId))] public Customer Customer { get; set; } = null!;
    [ForeignKey(nameof(TicketConcertId))] public TicketConcert TicketConcert { get; set; } = null!;
}