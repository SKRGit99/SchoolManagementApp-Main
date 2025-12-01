using System.ComponentModel.DataAnnotations;

namespace SchoolManagementAppWeb.Models
{
    public class StudentInfoEF
    {
           [Key]
            public int student_registration_Id { get; set; }
            public string? student_name { get; set; }
            public int student_roll_number { get; set; }
            public string? student_mobile_number { get; set; }
            public int student_class { get; set; }
            public string? student_section_name { get; set; }
            public string? student_address { get; set; }
            public string? student_Guardian_Name { get; set; }
    }

    public class StudentInfoForDropdownEF
    {
        [Key]
        public int student_registration_Id { get; set; }
        public string? student_name { get; set; }
    }
    
}
