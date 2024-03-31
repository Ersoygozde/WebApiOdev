using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFReservation.Models;
public class Reservation: BaseEntity
{
    public DateTime ReservationDate { get; set; }
    public string Note { get; set;}
    public int CustomerId { get; set;}
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }



}
