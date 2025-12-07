using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementAppWeb.Abstract;
using SchoolManagementAppWeb.Models;
using SchoolManagementAppWeb.Data;
using SchoolManagementAppWeb.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementAppWeb.Controllers
{
    public class StudentDetailsEFController : Controller
    {
        private readonly IStudentDetailsUsingEF studentInfoRepository;
        private readonly SchoolApplicationDbContext context;

        public StudentDetailsEFController(IStudentDetailsUsingEF studentInfoRepository, SchoolApplicationDbContext context)
        {
            this.studentInfoRepository = studentInfoRepository;
            this.context = context;
        }

        [Authorize(Roles = "Admin,Educator")]
        [HttpGet]
        public IActionResult fetchStudentDetailsUsingList()
        {
            List<StudentDetailsEF> lstStudentInfoList = new List<StudentDetailsEF>();

            lstStudentInfoList = studentInfoRepository.fetchStudentDetailsUsingListEF();

            return View(lstStudentInfoList);
        }

       
        public IActionResult fetchStudentDetailsForDropDown()
        {
            List<StudentDetailsForDropdownEF> lstStudentForDrpDwn = new List<StudentDetailsForDropdownEF>();
            lstStudentForDrpDwn =  studentInfoRepository.fetchStudentDetailsForDropdownEF();
            ViewBag.studentListDropdown =  new SelectList(lstStudentForDrpDwn, "student_registration_Id", "student_name");

            return View();
        }

        
        [HttpGet]
        public IActionResult fetchSelectedStudentDetailsFromDropDown(int student_registration_Id)
        {
            var dropDownSelectedStudentDetails = context.StudentDetailsEF.Where(p => p.student_registration_Id == student_registration_Id).Select(p => new { p.student_registration_Id, p.student_name, p.student_roll_number, p.student_mobile_number, p.student_class_details, p.student_section_details, p.student_address, p.student_guardian_Name }).ToList();
            return Json(dropDownSelectedStudentDetails);

        }

       
        public async Task<IActionResult> fetchStudentsDetailsForSelectListItem()
        {
            ViewBag.studentSelectListItem = await context.StudentDetailsForDropdownEF.OrderBy(c => c.student_registration_Id).ToListAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> fetchSelectedStudentDetailsFromSelectListItem(int student_registration_Id)
        {
            var selectListSelectedStudentDetails = await context.StudentDetailsEF.Where(p => p.student_registration_Id == student_registration_Id).Select(p => new { p.student_registration_Id, p.student_name, p.student_roll_number, p.student_mobile_number, p.student_class_details, p.student_section_details, p.student_address, p.student_guardian_Name }).ToListAsync();

            return Json(selectListSelectedStudentDetails);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
