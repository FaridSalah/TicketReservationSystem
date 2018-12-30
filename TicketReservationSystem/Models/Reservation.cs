using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketReservationSystem.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        [Required]
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        public string ReservationNumber { get; set; }
        [Required]
        public DateTime ReservationDateTime { get; set; }
        [Required]
        public string FlightClass { get; set; }
    }
}