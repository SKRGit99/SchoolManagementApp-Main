using SchoolManagementAppWeb.Models;

namespace SchoolManagementAppWeb.Abstract
{
    public interface IStudentDetailsUsingEF
    {
        //IEnumerable<StudentDetailsEF> fetchStudentDetailsUsingIEnumerable();

        List<StudentDetailsEF> fetchStudentDetailsUsingListEF();
        List<StudentDetailsForDropdownEF> fetchStudentDetailsForDropdownEF();
    }
}
