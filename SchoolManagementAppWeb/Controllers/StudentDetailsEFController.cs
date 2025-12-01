using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementAppWeb.Abstract;
using SchoolManagementAppWeb.Models;
using SchoolManagementAppWeb.Data;
using SchoolManagementAppWeb.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchoolManagementAppWeb.Controllers
{
    public class StudentDetailsEFController : Controller
    {
        private readonly IStudentInfoUsingEF studentInfoRepository;

        public StudentDetailsEFController(IStudentInfoUsingEF studentInfoRepository)
        {
            this.studentInfoRepository = studentInfoRepository;

        }

        public IActionResult fetchStudentDetailsUsingIEnumerable()
        {

            var studentDetails = studentInfoRepository.fetchStudentDetailsIEnumerableImplementEF();

            return View(studentDetails);
        }

        public IActionResult fetchStudentDetailsUsingList()
        {
            List<StudentInfoEF> lstStudentInfoList = new List<StudentInfoEF>();

            lstStudentInfoList = studentInfoRepository.fetchStudentDetailsListImplementEF();

            return View(lstStudentInfoList);
        }

        public IActionResult displayStudentDetailsForDropDown()
        {
            List<StudentInfoForDropdownEF> lstStudentForDrpDwn = new List<StudentInfoForDropdownEF>();

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
