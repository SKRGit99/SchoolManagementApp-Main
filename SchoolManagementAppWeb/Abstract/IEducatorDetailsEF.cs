using SchoolManagementAppWeb.Models;

namespace SchoolManagementAppWeb.Abstract
{
    public interface IEducatorDetailsEF
    {
        List<EducatorDetailsEF> fetchEducatorDetailsUsingListEF();
        List<EducatorDetailsForDropdownEF> fetchEducatorDetailsForDropdownEF();
    }
}
