using System.ComponentModel.DataAnnotations;

namespace Appointment_Booking_App.Models
{
    public class LoginInfo
    {
      //  [DataType(DataType.EmailAddress)]
      //  [Required] 
        public string Email { get; set; }
      //  [DataType(DataType.Password)]
      //  [Required]
        public string Password { get; set; }

    }
}
