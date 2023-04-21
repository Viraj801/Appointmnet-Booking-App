using Appointment_Booking_App.Models;
using PatientAPI.Repositary;

namespace PatientAPI.Services
{
    public class DoctorService:IDoctorService
    {
        readonly IDoctorRepositary _doctorRepositary;
        public DoctorService(IDoctorRepositary doctorRepositary)
        {
            _doctorRepositary = doctorRepositary;  
        }

        public List<Appointments>  Appointmentlist(int doctorid)
        {
            return _doctorRepositary.Appointmentlist(doctorid);
        }

        public Appointments ApprovedAppointment(int doctorId)
        {
            return _doctorRepositary.ApprovedAppointment(doctorId);
        }

        public Doctor DoctorLogin(LoginInfo loginInfo)
        {
            Doctor doctor = _doctorRepositary.Doctorlogin(loginInfo);
            if(doctor != null)
            {
                return doctor;
            }
            return null;
        }

        public List<Appointments> DoneAppointment(int doctorId)
        {
            return _doctorRepositary.DoneAppointment(doctorId);
        }

        public List<Doctor> GetAllDoctor()
        {
            return _doctorRepositary.GetAllDoctor();
        }

        public List<Appointments> GetAppovedAppointments(int doctorid)
        {
            return _doctorRepositary.GetAppovedAppointments(doctorid);
        }

        public List<Appointments> PendingAppointmentlist(int doctorid)
        {
            return _doctorRepositary.PendingAppointmentlist(doctorid);
        }

        public bool ResisterDoctor(Doctor doctor)
        {
            return _doctorRepositary.ResisterDoctor(doctor);

        }

        public bool UpdateDoctorDetails(Doctor doctor)
        {
            return _doctorRepositary.UpdateDoctorDetails(doctor);
        }
    }
}
