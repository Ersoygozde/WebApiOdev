using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReservation.Models;
public class EFReservationContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=EGEERSOY\SQLEXPRESS;Initial Catalog=EFRestaurantReservationDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }


    public DbSet<Customer> Customers { get; set; }
    public DbSet<Reservation>Reservations { get; set; }
    public DbSet<Menu>Menus { get; set; }

    public DbSet<Order> Orders { get; set; }
}
