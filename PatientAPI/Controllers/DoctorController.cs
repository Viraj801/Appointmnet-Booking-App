using Appointment_Booking_App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientAPI.Services;

namespace PatientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService= doctorService;
        }
        [HttpPost]
        [Route("DocotorLogin")]
        public ActionResult DoctorLogin(LoginInfo loginInfo)
        {
            Doctor doctor = _doctorService.DoctorLogin(loginInfo);
            return Ok(doctor);
        }
        [HttpPost]
        [Route("UpdateDoctorDetails")]
        public ActionResult UpdateDoctorDetails(Doctor doctor)
        {
            bool result = _doctorService.UpdateDoctorDetails(doctor);
            return Ok(result);
        }
        [HttpGet]
        [Route("Appointmentlist")]
        public ActionResult Appointmentlist(int doctorid) 
        {
            List<Appointments> appointments = _doctorService.Appointmentlist(doctorid);
            return Ok(appointments);
        }
        [HttpGet]
        [Route("GetPendingAppointments")]
        public ActionResult PendingAppointmentlist(int doctorid)
        {
            List<Appointments> appointments = _doctorService.GetAppovedAppointments(doctorid);
            return Ok(appointments);
        }
        [HttpGet]
        [Route("GetAppovedAppointments")]
        public ActionResult GetAppovedAppointments(int doctorid)
        {
          List<Appointments> appointments = _doctorService.GetAppovedAppointments(doctorid);
            return Ok(appointments);
        }
        // Apporoved Appointment left 
        [HttpPost]
        [Route("ApprovedAppointment")]
        public ActionResult ApprovedAppointment(int doctorId)
        {
            Appointments ststus = _doctorService.ApprovedAppointment(doctorId);
            return Ok(ststus);
        }
        [HttpGet]
        [Route("DoneAppointment")]
        public ActionResult DoneAppointment(int doctorId)
        {
            List<Appointments> appointments = _doctorService.DoneAppointment(doctorId);
            return Ok(appointments);
        }
       
    }
}
