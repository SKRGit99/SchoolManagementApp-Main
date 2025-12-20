using SchoolManagementAppWeb.Data;
using SchoolManagementAppWeb.Models;
using SchoolManagementAppWeb.Abstract;

namespace SchoolManagementAppWeb.Repository
{
    public class StudentDetailsRepoEF:IStudentDetailsUsingEF
    {
        private readonly SchoolApplicationDbContext SchoolApplicationDbContext;

        public StudentDetailsRepoEF(SchoolApplicationDbContext SchoolApplicationDbContext)
        {
            this.SchoolApplicationDbContext = SchoolApplicationDbContext;
        }


        public List<StudentDetailsEF> fetchStudentDetailsUsingListEF()
        {
            List<StudentDetailsEF> stdDetailsUsingList = new List<StudentDetailsEF>();
            try
            {

                stdDetailsUsingList = SchoolApplicationDbContext.StudentDetailsEF.ToList();

            }
            catch (Exception ex)
            {

            }

            return stdDetailsUsingList;

        }

        public List<StudentDetailsForDropdownEF> fetchStudentDetailsForDropdownEF() //Display all the Records.
        {
            List<StudentDetailsForDropdownEF> stdDetForDrpDwn = new List<StudentDetailsForDropdownEF>();

            try
            {
                stdDetForDrpDwn = SchoolApplicationDbContext.StudentDetailsForDropdownEF.ToList();


            }
            catch (Exception ex)
            {

            }
            return stdDetForDrpDwn;
        }
    }
}
