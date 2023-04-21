using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Booking_App.Models
{
    public class Appointments
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppoimtmentId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string ?PatientEmailId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        [Required]
        public string  ?PatientName { get; set; }
        [Required]
        public int PatientAge { get; set; }
        [Required]
        public string AppointmentStatus { get; set; } = "Pending";
        [Required]
        [DataType(DataType.Date)]
        public string ?AppointmentDate { get; set; }
        [DataType(DataType.Time)]
        public string ?AppointmentTime { get; set; } = null;
        
    }
}
