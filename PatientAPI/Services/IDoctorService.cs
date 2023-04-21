using Appointment_Booking_App.Models;

namespace PatientAPI.Services
{
    public interface IDoctorService
    {
       List<Appointments> Appointmentlist(int doctorid);
        Appointments ApprovedAppointment(int doctorId);
        Doctor DoctorLogin(LoginInfo loginInfo);
        List<Appointments> PendingAppointmentlist(int doctorid);
        List<Appointments> GetAppovedAppointments(int doctorid);
        bool ResisterDoctor(Doctor doctor);
        bool UpdateDoctorDetails(Doctor doctor);
        List<Appointments> DoneAppointment(int doctorId);
    }
}
