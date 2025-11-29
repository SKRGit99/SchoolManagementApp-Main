using SchoolManagementAppWeb.Data;
using SchoolManagementAppWeb.Models;
using SchoolManagementAppWeb.Abstract;

namespace SchoolManagementAppWeb.Repository
{
    public class StudentInfoRepoEF:IStudentInfoUsingEF
    {
        private readonly StudentInfoDbContext StudentInfoDbContext;

        public StudentInfoRepoEF(StudentInfoDbContext StudentInfoDbContext)
        {
            this.StudentInfoDbContext = StudentInfoDbContext;
        }

       
        public IEnumerable<StudentInfoEF> fetchStudentDetailsIEnumerableImplementEF() //Display all the Records.
        {
            return StudentInfoDbContext.StudentInfoUsingIEnumerable;
        }

        public List<StudentInfoEF> fetchStudentDetailsListImplementEF()
        {
            List<StudentInfoEF> stdDetailsUsingList = new List<StudentInfoEF>();
            try
            {

                stdDetailsUsingList = StudentInfoDbContext.StudentInfoUsingList.ToList();

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
                stdDetForDrpDwn = StudentInfoDbContext.StudentDetailsForDropdown.ToList();


            }
            catch (Exception ex)
            {

            }
            return stdDetForDrpDwn;
        }
    }
}
