using Microsoft.EntityFrameworkCore;
using Shows.API.Models.Domain;

namespace Shows.API.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<PurchasedTicket> PurchasedTickets { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketConcert> TicketConcerts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Concert>().HasData(new List<Concert>()
        {
            new Concert()
            {
                ConcertId = 1,
                Name = "Aerosmith",
                Date = DateTime.Parse("2025-09-01"),
                AvailableTickets = 25000
            },
            new Concert()
            {
                ConcertId = 2,
                Name = "Primus",
                Date = DateTime.Parse("2026-07-23"),
                AvailableTickets = 10000
            },
            new Concert()
            {
            ConcertId = 3,
            Name = "Ozzy",
            Date = DateTime.Parse("2025-07-15"),
            AvailableTickets = 100000
        }
        });
        
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer()
            {
                CustomerID = 1,
                FirstName = "Mac",
                LastName = "McDonald",
                PhoneNumber = "555-123-1234"
            },
            new Customer()
            {
                CustomerID = 2,
                FirstName = "Sam",
                LastName = "Smith",
            },
            new Customer()
            {
                CustomerID = 3,
                FirstName = "Jack",
                LastName = "Jones",
                PhoneNumber = "555-333-4444"
            }
        });

        modelBuilder.Entity<PurchasedTicket>().HasData(new List<PurchasedTicket>()
        {
            new PurchasedTicket()
            {
                TicketConcertId = 1,
                CustomerId = 1,
                PurchaseDate = DateTime.Parse("2024-05-05"),
            },
            new PurchasedTicket()
            {
                TicketConcertId = 2,
                CustomerId = 2,
                PurchaseDate = DateTime.Parse("2025-05-05"),
            },
            new PurchasedTicket()
            {
                TicketConcertId = 3,
                CustomerId = 3,
                PurchaseDate = DateTime.Parse("2024-09-19"),
            }
        });

        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>()
        {
            new Ticket()
            {
                TicketId = 1,
                SerialNumber = "111",
                SeatNumber = 543
            },
            new Ticket()
            {
                TicketId = 2,
                SerialNumber = "222",
                SeatNumber = 210
            },
            new Ticket()
            {
                TicketId = 3,
                SerialNumber = "1540A",
                SeatNumber = 5001
            }
        });

        modelBuilder.Entity<TicketConcert>().HasData(new List<TicketConcert>()
        {
            new TicketConcert()
            {
                TicketConcertId = 1,
                Price = 500.50M,
                ConcertId = 1,
                TicketId = 1
            },
            new TicketConcert()
            {
                TicketConcertId = 2,
                Price = 340.00M,
                ConcertId = 2,
                TicketId = 2
            },
            new TicketConcert()
            {
                TicketConcertId = 3,
                Price = 700.00M,
                ConcertId = 3,
                TicketId = 3
            }
        });
    }
}