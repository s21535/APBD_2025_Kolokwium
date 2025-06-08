using Microsoft.EntityFrameworkCore;
using Shows.API.Data;
using Shows.API.Models.Domain;

namespace Shows.API.Repositories;

public class SQLOrdersRepository : IOrderRepository
{
    private readonly DatabaseContext _dbContext;
    
    public SQLOrdersRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<ICollection<PurchasedTicket>> GetOrdersAsync()
    {
        return await _dbContext.PurchasedTickets.ToListAsync();
    }
}