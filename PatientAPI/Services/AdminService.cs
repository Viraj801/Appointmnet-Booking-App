using Appointment_Booking_App.Models;
using PatientAPI.Repositary;

namespace PatientAPI.Services
{
    public class AdminService : IAdminService
    {
        readonly IAdminRepositary _adminRepositary;
        public AdminService(IAdminRepositary adminRepositary)
        {
            _adminRepositary= adminRepositary;
        }
        public Admin AdminDetails(string email)
        {
            return _adminRepositary.AdminDetails(email);
        }

        public Admin AdminLogin(LoginInfo loginInfo)
        {
            Admin adminExist = _adminRepositary.AdminLogin(loginInfo);
            if(adminExist != null)
            {
                return adminExist;
            }
            return null;
        }

        public bool DeleteAdmin(string email)
        {
            Admin existAdmin = _adminRepositary.AdminDetails(email);
            if(existAdmin != null)
            {
                return _adminRepositary.DeleteAdmin(email);
            }
            return false;
        }

        public bool DeleteDoctor(string email)
        {
            Doctor existDoctor = _adminRepositary.GetDoctorDetails(email);
            if(existDoctor != null)
            {
                return _adminRepositary.DeleteDoctor(email);
            }
            return false;
        }

        public List<Admin> GetAllAdmin()
        {
            return _adminRepositary.GetAllAdmin();
        }

        public List<Appointments> GetAllAppointment()
        {
            return _adminRepositary.GetAllAppointment();
        }

        public List<Doctor> GetAllDoctors()
        {
            return _adminRepositary.GetAllDoctors();
        }

        public List<Appointments> GetPendingAppointments()
        {
            return _adminRepositary.GetPendingAppointments();
        }

        public bool ResisterAadmin(Admin admin)
        {
            Admin existAdmin = _adminRepositary.AdminDetails(admin.Email);
            if(existAdmin == null)
            {
                return _adminRepositary.ResisterAdmin(admin);
            }
            return false;
        }

        public bool ResisterDoctor(Doctor doctor)
        {
            Doctor doctorExist = _adminRepositary.GetDoctorDetails(doctor.DoctorEmailId);
            if(doctorExist == null)
            {
                return _adminRepositary.ResisterDoctor(doctor);
            }
            return false;
        }

        public bool UpdateAdminDetals(Admin admin)
        {
            return _adminRepositary.UpdateAdminDetals(admin);
        }
    }
}
