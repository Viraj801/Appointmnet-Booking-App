using Appointment_Booking_App.Models;

namespace PatientAPI.Services
{
    public interface IPatientService
    {
        List<Patient> GetAllPatient();
        List<Appointments> GetAppointmentsDetails(string email);
        Patient Login(LoginInfo loginInfo);
        bool ResisterAppointment(Appointments appointments);
        bool ResisterPatient(Patient patient);
        bool UpdatePatientDetails(Patient patient);
    }
}
