﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shows.API.Models.Domain;

public class TicketConcert
{
    [Key] public int TicketConcertId { get; set; }
    [DataType("decimal")] [Precision(10,2)] public decimal Price { get; set; }
    
    public int TicketId { get; set; }
    public int ConcertId { get; set; }
    
    [ForeignKey(nameof(ConcertId))] public Concert Concert { get; set; } = null!;
    [ForeignKey(nameof(TicketId))] public Ticket Ticket { get; set; } = null!;
    
    public ICollection<PurchasedTicket> PurchasedTickets { get; set; } = new HashSet<PurchasedTicket>();
}