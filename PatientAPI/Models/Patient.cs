using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Booking_App.Models
{
    public class Patient
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string ?PatientName { get; set; }
        [Required]
        public string ?Gender { get; set; }
        [Required (ErrorMessage = "Enter the right DOB and DOB should be 8 characters")]
        [MinLength(8)]
        public string ?DateOfBirth { get; set; }
        public string ?ContactNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string ?PatientEmailId { get; set; } 
        [DataType(DataType.Password)]
        [Required]
        [PasswordPropertyText]
        public string ?Password { get; set; }       
    }
}
