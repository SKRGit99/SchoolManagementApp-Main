using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementAppWeb.Abstract;
using SchoolManagementAppWeb.Models;

namespace SchoolManagementAppWeb.Controllers
{
    public class EducatorDetailsEFController : Controller
    {

        private readonly IEducatorDetailsEF educatorInfoRepository;

        public EducatorDetailsEFController(IEducatorDetailsEF educatorInfoRepository)
        {
            this.educatorInfoRepository = educatorInfoRepository;

        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult fetchEducatorDetailsUsingList()
        {
            List<EducatorDetailsEF> lstEducatorInfoList = new List<EducatorDetailsEF>();

            lstEducatorInfoList = educatorInfoRepository.fetchEducatorDetailsUsingListEF();

            return View(lstEducatorInfoList);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult fetchEducatorDetailsForDropDown()
        {
            List<EducatorDetailsForDropdownEF> lstEducatorForDropDwn = new List<EducatorDetailsForDropdownEF>();

            /*This code is for getting dropdown details*/
            lstEducatorForDropDwn = educatorInfoRepository.fetchEducatorDetailsForDropdownEF();
            ViewBag.educatorList = new SelectList(lstEducatorForDropDwn, "educator_registration_Id", "educator_name");
            /*code for grtting dropdown details ends*/



            return View(lstEducatorForDropDwn);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
