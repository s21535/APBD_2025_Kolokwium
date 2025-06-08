namespace Shows.API.Models.DTOs;

public class GetPurchasesDTO
{
    public int TicketConcertId { get; set; }
    public int CustomerId { get; set; }
    public DateTime PurchaseDate { get; set; }
}