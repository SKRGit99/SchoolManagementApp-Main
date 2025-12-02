using SchoolManagementAppWeb.Abstract;
using SchoolManagementAppWeb.Data;
using SchoolManagementAppWeb.Models;

namespace SchoolManagementAppWeb.Repository
{
    public class EducatorDetailsRepoEF:IEducatorDetailsEF
    {
        private readonly SchoolApplicationDbContext EducatorInfoDbContext;

        public EducatorDetailsRepoEF(SchoolApplicationDbContext EducatorInfoDbContext)
        {
            this.EducatorInfoDbContext = EducatorInfoDbContext;
        }


        public List<EducatorDetailsEF> fetchEducatorDetailsUsingListEF()
        {
            List<EducatorDetailsEF> eduDetailsUsingList = new List<EducatorDetailsEF>();
            try
            {

                eduDetailsUsingList = EducatorInfoDbContext.EducatorDetailsEF.ToList();

            }
            catch (Exception ex)
            {

            }

            return eduDetailsUsingList;

        }

        public List<EducatorDetailsForDropdownEF> fetchEducatorDetailsForDropdownEF() //Display all the Records.
        {
            List<EducatorDetailsForDropdownEF> eduDetForDrpDwn = new List<EducatorDetailsForDropdownEF>();

            try
            {
                eduDetForDrpDwn = EducatorInfoDbContext.EducatorDetailsForDropdownEF.ToList();


            }
            catch (Exception ex)
            {

            }
            return eduDetForDrpDwn;
        }
    }
}
