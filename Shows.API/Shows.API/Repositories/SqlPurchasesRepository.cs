using Microsoft.EntityFrameworkCore;
using Shows.API.Data;
using Shows.API.Models.Domain;

namespace Shows.API.Repositories;

public class SqlPurchasesRepository : IPurchaseRepository
{
    private readonly DatabaseContext _dbContext;
    
    public SqlPurchasesRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<ICollection<PurchasedTicket>> GetOrdersAsync(string? customerLastName)
    {
        return await _dbContext.PurchasedTickets.ToListAsync();
    }
}