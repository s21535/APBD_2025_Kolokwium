using Shows.API.Models.Domain;

namespace Shows.API.Repositories;

public interface IPurchaseRepository
{
    Task<ICollection<PurchasedTicket>> GetOrdersAsync();
}