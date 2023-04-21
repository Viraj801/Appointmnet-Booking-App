using Appointment_Booking_App.Models;
using PatientAPI.Repositary;

namespace PatientAPI.Services
{
    public class Patientservice : IPatientService
    {
        readonly IPatientRepositary _patientRepositary;
        public Patientservice(IPatientRepositary patientRepositary)
        {
            _patientRepositary = patientRepositary;
        }

        public List<Patient> GetAllPatient()
        {
            return _patientRepositary.GetAllPatient();
        }

        public List<Appointments> GetAppointmentsDetails(string email)
        {
            return _patientRepositary.GetAppointmentsDetails(email);
        }

        public Patient Login(LoginInfo loginInfo)
        {
            Patient existPatient= _patientRepositary.Login(loginInfo);
            if (existPatient != null)
            {
                return existPatient;
            }
            return null;
        }

        public bool ResisterAppointment(Appointments appointments)
        {
            return _patientRepositary.ResisterAppointment(appointments);
        }

        public bool ResisterPatient(Patient patient)
        {
            return _patientRepositary.ResisterPatient(patient);
        }

        public bool UpdatePatientDetails(Patient patient)
        {
            return _patientRepositary.UpdatePatientDetails(patient);
        }
    }
}
