using Appointment_Booking_App.Models;
using PatientAPI.Context;

namespace PatientAPI.Repositary
{
    public class PatientRepositary:IPatientRepositary
    {
        Dbcontext _dbcontext;
        public PatientRepositary(Dbcontext dbcontext)
        {
            _dbcontext= dbcontext;
        }

        public List<Patient> GetAllPatient()
        {
            return _dbcontext.PatientsTable.ToList();
        }

        public List<Appointments> GetAppointmentsDetails(string email)
        {
            return _dbcontext.AppointmentsTable.Where(u=>u.PatientEmailId== email).ToList();    
        }

        public Patient Login(LoginInfo loginInfo)
        {
            return _dbcontext.PatientsTable.Where(u => u.PatientEmailId == loginInfo.Email && u.Password == loginInfo.Password).FirstOrDefault();
        }

        public bool ResisterAppointment(Appointments appointments)
        {
           _dbcontext.AppointmentsTable.Add(appointments);
          return _dbcontext.SaveChanges()==1?true:false;
        }

        public bool ResisterPatient(Patient patient)
        {
           _dbcontext.PatientsTable.Add(patient);   
            return _dbcontext.SaveChanges()==1?true :false;
        }

        public bool UpdatePatientDetails(Patient patient)
        {
            _dbcontext.Entry<Patient>(patient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbcontext.SaveChanges() == 1?true:false;
        }
    }
}
