using Appointment_Booking_App.Models;
using PatientAPI.Context;
using System.Linq;

namespace PatientAPI.Repositary
{
    public class DoctorRepositary:IDoctorRepositary
    {
        Dbcontext _dbcontext;
        public DoctorRepositary(Dbcontext dbcontext )
        {
            _dbcontext= dbcontext;
        }

        public List<Appointments> Appointmentlist(int doctorid)
        {
            return _dbcontext.AppointmentsTable.Where(u => u.DoctorId == doctorid).ToList();
        }

        public Appointments ApprovedAppointment(int doctorId)
        {
            Appointments existsappointment = _dbcontext.AppointmentsTable.Where(u => u.DoctorId == doctorId).FirstOrDefault();
            existsappointment.AppointmentTime = existsappointment.AppointmentTime;
            existsappointment.AppointmentStatus = "Confirm";
            existsappointment.AppointmentDate = existsappointment.AppointmentDate;
            existsappointment.PatientName = existsappointment.PatientName;
            existsappointment.PatientAge = existsappointment.PatientAge;
            existsappointment.DoctorId = existsappointment.DoctorId;
            existsappointment.PatientEmailId = existsappointment.PatientEmailId;
            _dbcontext.SaveChanges();
            return existsappointment;
        }

        public Doctor Doctorlogin(LoginInfo loginInfo)
        {
            return _dbcontext.DoctorsTable.Where(u => u.DoctorEmailId == loginInfo.Email && u.Password == loginInfo.Password).FirstOrDefault();
        }

        public  List<Appointments> DoneAppointment(int doctorId)
        {
            return _dbcontext.AppointmentsTable.Where(u => u.DoctorId == doctorId && u.AppointmentStatus == "Completed").ToList();
        }

        public List<Doctor> GetAllDoctor()
        {
           return _dbcontext.DoctorsTable.ToList();
        }

        public List<Appointments> GetAppovedAppointments(int doctorid)
        {
            return _dbcontext.AppointmentsTable.Where(u => u.DoctorId == doctorid && u.AppointmentStatus == "Confirm").ToList();
        }

        public List<Appointments> PendingAppointmentlist(int doctorid)
        {
            return _dbcontext.AppointmentsTable.Where(u => u.DoctorId == doctorid && u.AppointmentStatus == "Pending").ToList();
        }

        public bool ResisterDoctor(Doctor doctor)
        {
            _dbcontext.DoctorsTable.Add(doctor);
            return _dbcontext.SaveChanges()==1?true:false;
        }

       
        public bool UpdateDoctorDetails(Doctor doctor)
        {
            _dbcontext.Entry<Doctor>(doctor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbcontext.SaveChanges() == 1 ? true : false;
        }
    }
}
