using Shows.API.Models.Domain;

namespace Shows.API.Repositories;

public interface IOrderRepository
{
    Task<ICollection<PurchasedTicket>> GetOrdersAsync();
}