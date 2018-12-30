using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketReservationSystem.Models
{
    public class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string IdentificationNumber { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        public bool IsAgency { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}