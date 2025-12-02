using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementAppWeb.Models
{
    public class StudentDetailsEF
    {
           [Key]
            public int student_registration_Id { get; set; }
            public string student_name { get; set; }
            public int student_roll_number { get; set; }
            public string student_mobile_number { get; set; }
            public int student_class_details { get; set; }
            public string student_section_details { get; set; }
            public string student_address { get; set; }
            public string student_guardian_Name { get; set; }

            
    }

    public class StudentDetailsForDropdownEF
    {
        [Key]
        public int student_registration_Id { get; set; }
        public string student_name { get; set; }
    }
    
}
