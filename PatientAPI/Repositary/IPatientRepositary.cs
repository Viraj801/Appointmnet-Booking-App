using Appointment_Booking_App.Models;

namespace PatientAPI.Repositary
{
    public interface IPatientRepositary
    {
        List<Patient> GetAllPatient();
        List<Appointments> GetAppointmentsDetails(string email);
        Patient Login(LoginInfo loginInfo);
        bool ResisterAppointment(Appointments appointments);
        bool ResisterPatient(Patient patient);
        bool UpdatePatientDetails(Patient patient);
    }
}
