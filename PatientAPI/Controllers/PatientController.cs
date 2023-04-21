using Appointment_Booking_App.Models;
using Microsoft.AspNetCore.Mvc;
using PatientAPI.Services;

namespace PatientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        readonly IPatientService _patientService;
      //  ITokengeneratorcs _tokengeneratorcs;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
         //   _tokengeneratorcs = tokengeneratorcs;
        }

        [HttpPost]
        [Route("ResistorPatient")]
        public ActionResult ResisterPatient(Patient patient)
        {
            bool result = _patientService.ResisterPatient(patient);
            return Created("api/Created", result);
        }

        [HttpGet]
        [Route("GetAllPatient")]
        public ActionResult GetPatient()
        {
            List<Patient> patients = _patientService.GetAllPatient();
            return Ok(patients);
        }
        [HttpPost]
        [Route("LogIn")]
        public ActionResult LogIn(LoginInfo loginInfo)
        {
            Patient result = _patientService.Login(loginInfo);
         //   string patientToken = _tokengeneratorcs.generateToken(result.Id, result.PatientName);
            return Ok(result);
        }
        [HttpPost]
        [Route("UpdatePatientDetails")]
        public ActionResult UpdatePatientDetails(Patient patient)
        {
            bool result = _patientService.UpdatePatientDetails(patient);
            return Ok(result);
        }
        [HttpPost]
        [Route("ReisiterAppointment")]
        public ActionResult ResisterAppointment(Appointments appointments)
        {
            bool result = _patientService.ResisterAppointment(appointments);
            return Ok(result);
        }
        // editdetails // book appointments // chackAppointment status// pending or Conform
        [HttpGet]
        [Route("GetAppointments")]
        public ActionResult GetAppointmentsDetails(string email)
        {
            List<Appointments> appointments = _patientService.GetAppointmentsDetails(email);
            return Ok(appointments);
        }
    }
}
