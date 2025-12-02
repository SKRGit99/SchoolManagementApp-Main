using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementAppWeb.Abstract;
using SchoolManagementAppWeb.Models;
using SchoolManagementAppWeb.Data;
using SchoolManagementAppWeb.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace SchoolManagementAppWeb.Controllers
{
    public class StudentDetailsEFController : Controller
    {
        private readonly IStudentDetailsUsingEF studentInfoRepository;

        public StudentDetailsEFController(IStudentDetailsUsingEF studentInfoRepository)
        {
            this.studentInfoRepository = studentInfoRepository;

        }

        //public IActionResult fetchStudentDetailsUsingIEnumerable()
        //{

        //    var studentDetails = studentInfoRepository.fetchStudentDetailsUsingIEnumerable();

        //    return View(studentDetails);
        //}

        [Authorize(Roles = "Admin,Educator")]
        [HttpGet]
        public IActionResult fetchStudentDetailsUsingList()
        {
            List<StudentDetailsEF> lstStudentInfoList = new List<StudentDetailsEF>();

            lstStudentInfoList = studentInfoRepository.fetchStudentDetailsUsingListEF();

            return View(lstStudentInfoList);
        }

        [Authorize(Roles = "Admin,Educator")]
        public IActionResult fetchStudentDetailsForDropDown()
        {
            List<StudentDetailsForDropdownEF> lstStudentForDrpDwn = new List<StudentDetailsForDropdownEF>();

            /*This code is for getting dropdown details*/
            lstStudentForDrpDwn = studentInfoRepository.fetchStudentDetailsForDropdownEF();
            ViewBag.studentList = new SelectList(lstStudentForDrpDwn, "student_registration_Id", "student_name");
            /*code for grtting dropdown details ends*/

            

            return View(lstStudentForDrpDwn);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
