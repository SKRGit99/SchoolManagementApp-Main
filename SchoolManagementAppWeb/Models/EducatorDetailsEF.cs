using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementAppWeb.Models
{
    public class EducatorDetailsEF
    {
        [Key]
        public int educator_registration_Id { get; set; }
        public string educator_name { get; set; }
        public string educator_subject_assigned { get; set; }
        public int educator_class_assigned { get; set; }
        public string educator_section_assigned { get; set; }
        public string educator_mobile_number { get; set; }
        public string educator_address { get; set; }

        
      
    }

    public class EducatorDetailsForDropdownEF
    {
        [Key]
        public int educator_registration_Id { get; set; }
        public string educator_name { get; set; }
    }
}
