using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketReservationSystem.Models
{
    public class Flight
    {
        public Flight()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int FlightId { get; set; }
        [Required]
        public string FlightNumber { get; set; }
        [Required]
        public DateTime DepartureDateTime { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}