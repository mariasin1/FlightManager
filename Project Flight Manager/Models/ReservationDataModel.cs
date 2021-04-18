using Project_Flight_Manager.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Flight_Manager.Models
{
    public class ReservationDataModel
    {
        public ReservationDataModel()
        {
            this.ReservationId = Guid.NewGuid().ToString();
        }

        [Key]
        public string ReservationId { get; set; }

        [Required(ErrorMessage ="Enter your First name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your Middle name")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Enter your Last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your EGN") ]
        public int EGN { get; set; }

        [Required(ErrorMessage = "Enter your Phone number")]
        [Display(Name = "Phone Number")]
        public int TelNumber { get; set; }

        [Required(ErrorMessage = "Enter your nationality name")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Enter your Ticket type")]
        [Display(Name = "Ticket Type")]
        public TicketType TicketType { get; set; }

        public virtual string FlightId { get; set; }

        public virtual FlightDataModel Flight { get; set; }
    }
}
