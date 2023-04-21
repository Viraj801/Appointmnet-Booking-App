using Appointment_Booking_App.Models;

namespace PatientAPI.Repositary
{
    public interface IDoctorRepositary
    {
        List<Appointments> Appointmentlist(int doctorid);
        Appointments ApprovedAppointment(int doctorId);
        Doctor Doctorlogin(LoginInfo loginInfo);
        List<Appointments> DoneAppointment(int doctorId);
        List<Doctor> GetAllDoctor();
        List<Appointments>  GetAppovedAppointments(int doctorid);
        List<Appointments> PendingAppointmentlist(int doctorid);
        bool ResisterDoctor(Doctor doctor);
        bool UpdateDoctorDetails(Doctor doctor);
    }
}
