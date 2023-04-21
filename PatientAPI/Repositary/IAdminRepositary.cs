using Appointment_Booking_App.Models;

namespace PatientAPI.Repositary
{
    public interface IAdminRepositary
    {
        Admin AdminDetails(string email);
        Admin AdminLogin(LoginInfo loginInfo);
        bool DeleteAdmin(string email);
        bool DeleteDoctor(string email);
        List<Admin> GetAllAdmin();
        List<Appointments> GetAllAppointment();
        List<Doctor> GetAllDoctors();
        Doctor GetDoctorDetails(string email);
        List<Appointments> GetPendingAppointments();
        bool ResisterAdmin(Admin admin);
        bool ResisterDoctor(Doctor doctor);
        bool UpdateAdminDetals(Admin admin);
    }
}
