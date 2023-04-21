using Appointment_Booking_App.Models;

namespace PatientAPI.Services
{
    public interface IAdminService
    {
        Admin AdminDetails(string email);
        Admin AdminLogin(LoginInfo loginInfo);
        bool DeleteAdmin(string email);
        bool DeleteDoctor(string email);
        List<Admin> GetAllAdmin();
        List<Appointments> GetAllAppointment();
        List<Doctor> GetAllDoctors();
        List<Appointments> GetPendingAppointments();
        bool ResisterAadmin(Admin admin);
        bool ResisterDoctor(Doctor doctor);
        bool UpdateAdminDetals(Admin admin);
    }
}
