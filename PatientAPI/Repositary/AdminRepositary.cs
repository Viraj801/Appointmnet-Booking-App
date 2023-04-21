using Appointment_Booking_App.Models;
using PatientAPI.Context;

namespace PatientAPI.Repositary
{
    public class AdminRepositary : IAdminRepositary
    {
        Dbcontext _dbcontext;
        public AdminRepositary(Dbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public Admin AdminDetails(string email)
        {
            return _dbcontext.AdminTable.Where(u => u.Email == email).FirstOrDefault();
        }

        public Admin AdminLogin(LoginInfo loginInfo)
        {
            return _dbcontext.AdminTable.Where(u => u.Email == loginInfo.Email && u.Password == loginInfo.Password).FirstOrDefault();
        }

        public bool DeleteAdmin(string email)
        {
            Admin admin = AdminDetails(email);
            _dbcontext.AdminTable.Remove(admin);
            return _dbcontext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteDoctor(string email)
        {
           Doctor doctor = GetDoctorDetails(email);
            _dbcontext.DoctorsTable.Remove(doctor);
            return _dbcontext.SaveChanges()==1?true:false;
        }

        public List<Admin> GetAllAdmin()
        {
            return _dbcontext.AdminTable.ToList();
        }

        public List<Appointments> GetAllAppointment()
        {
            return _dbcontext.AppointmentsTable.ToList();
        }

        public List<Doctor> GetAllDoctors()
        {
          return _dbcontext.DoctorsTable.ToList();
        }

        public Doctor GetDoctorDetails(string email)
        {
            return _dbcontext.DoctorsTable.Where(u=>u.DoctorEmailId == email).FirstOrDefault();
        }

        public List<Appointments> GetPendingAppointments()
        {
            return _dbcontext.AppointmentsTable.Where(u=>u.AppointmentStatus=="Pending").ToList();
        }

        public bool ResisterAdmin(Admin admin)
        {
            _dbcontext.AdminTable.Add(admin);
            return _dbcontext.SaveChanges()==1?true:false;
        }

        public bool ResisterDoctor(Doctor doctor)
        {
            _dbcontext.DoctorsTable.Add(doctor);
            return _dbcontext.SaveChanges()==1?true:false;
        }

        public bool UpdateAdminDetals(Admin admin)
        {
            _dbcontext.Entry<Admin>(admin).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbcontext.SaveChanges() == 1?true:false;
        }
    }
}
