using SchoolManagementAppWeb.Models;

namespace SchoolManagementAppWeb.Abstract
{
    public interface IStudentInfoUsingEF
    {
        IEnumerable<StudentInfoEF> fetchStudentDetailsIEnumerableImplementEF();

        List<StudentInfoEF> fetchStudentDetailsListImplementEF();
        List<StudentInfoForDropdownEF> fetchStudentDetailsForDropdownEF();
    }
}
