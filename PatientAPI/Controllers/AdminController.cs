using Appointment_Booking_App.Models;
using Microsoft.AspNetCore.Mvc;
using PatientAPI.Services;

namespace PatientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpPost]
        [Route("ResisterAdmin")]
        public ActionResult ResisterAdmin(Admin admin)
        {
            bool result = _adminService.ResisterAadmin(admin);
            return Created("api/Created", result);
        }
        [HttpGet]
        [Route("GetAllAdmin")]
        public ActionResult GetAllAdmin()
        {
            List<Admin> allAdmin = _adminService.GetAllAdmin();
            return Ok(allAdmin);
        }
        [HttpGet]
        [Route("AdminDetails")]
        public ActionResult AdminDetails(string email)
        {
            Admin admin = _adminService.AdminDetails(email);
            return Ok(admin);
        }
        [HttpPost]
        [Route("UpdataAdminDetails")]
        public ActionResult UpdateAdminDetails(Admin admin)
        {
            bool result = _adminService.UpdateAdminDetals(admin);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetAllDoctors")]
        public ActionResult GetAllDoctors()
        {
            List<Doctor> allDocters = _adminService.GetAllDoctors();
            return Ok(allDocters);
        }
        [HttpDelete]
        [Route("DeleteDoctor")]
        public ActionResult DeleteDoctor(string email)
        {
            bool result = _adminService.DeleteDoctor(email);
            return Ok(result);
        }
        [HttpDelete]
        [Route("DeleteAdmin")]
        public ActionResult DeleteAdmin(string email)
        {
            bool result = _adminService.DeleteAdmin(email);
            return Ok(result);
        }
        [HttpGet]
        [Route("GetAllAppointmentsList")]
        public ActionResult GetAllAppointments()
        {
            List<Appointments> appointments = _adminService.GetAllAppointment();
            return Ok(appointments);
        }
        [HttpGet]
        [Route("GetPendingAppointments")]
        public ActionResult GetPendingAppointments()
        {
            List<Appointments> result = _adminService.GetPendingAppointments();
            return Ok(result);
        }
        [HttpPost]
        [Route("AdminLogin")]
        public ActionResult AdminLogin(LoginInfo loginInfo)
        {
            Admin admin = _adminService.AdminLogin(loginInfo);
            return Ok(admin);
        }
        [HttpPost]
        [Route("ResistorDoctor")]
        public ActionResult ResisterDoctor(Doctor doctor)
        {
            bool result = _adminService.ResisterDoctor(doctor);
            return Created("api/Created", result);
        }
       
        // get all patient left
    }
}
