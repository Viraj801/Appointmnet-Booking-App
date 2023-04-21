using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Appointment_Booking_App.Models
{
    public class Doctor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        [Required]
        public string ?DoctorName { get; set; }
        [Required]
        public string ?ContectNumber { get; set; }
        [Required]
        public  string ?Specility { get; set; }
        public string ?Description { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string ?Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string ?DoctorEmailId { get; set; }
    }
}
