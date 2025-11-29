using Microsoft.Data.SqlClient;
using SchoolManagementAppWeb.Abstract;
using SchoolManagementAppWeb.Models;
using System.Data;

namespace SchoolManagementAppWeb.Repository
{
    //public class StudentInfoRepoADO:IStudentInfoUsingADO
    //{
    //    SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=schoolmanagementdb;Integrated Security=True;");
    //    public List<StudentInfoADO> fetchStudentDetailsUsingADO()
    //    {
    //        List<StudentInfoADO> lstStdDetails = new List<StudentInfoADO>();


    //        SqlCommand cmd = new SqlCommand("getStudentDetails", conObj);
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        SqlDataAdapter da = new SqlDataAdapter(cmd);

    //        DataTable dt = new DataTable();

    //        da.Fill(dt);

    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            StudentInfoADO studentDet = new StudentInfoADO();
    //            studentDet.student_registration_Id = Convert.ToInt32(dr["student_registration_Id"]);
    //            studentDet.student_name = dr["student_name"].ToString();
    //            studentDet.student_roll_number = Convert.ToInt32(dr["student_roll_number"]);
    //            studentDet.student_mobile_number = dr["student_mobile_number"].ToString();
    //            studentDet.student_class = Convert.ToInt32(dr["student_class"]);
    //            studentDet.student_section_name = dr["student_section_name"].ToString();
    //            studentDet.student_address = dr["student_address"].ToString();

    //            lstStdDetails.Add(studentDet);


    //        }

    //        return lstStdDetails;


    //    }

    //    public List<StudentDetailsForDropdownADO> fetchStudentDetailsForDrpDwnUsingADO()
    //    {
    //        List<StudentDetailsForDropdownADO> lsdDrpDwn = new List<StudentDetailsForDropdownADO>();
    //        SqlCommand cmd = new SqlCommand("getStudentDetails", conObj);
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        SqlDataAdapter da = new SqlDataAdapter(cmd);

    //        DataTable dt = new DataTable();

    //        da.Fill(dt);

    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            StudentDetailsForDropdownADO studentDetailsByDropDown = new StudentDetailsForDropdownADO();
    //            studentDetailsByDropDown.student_registration_Id = Convert.ToInt32(dr["student_registration_id"]);
    //            studentDetailsByDropDown.student_name = dr["student_name"].ToString();


    //            lsdDrpDwn.Add(studentDetailsByDropDown);
    //        }
    //        return lsdDrpDwn;
    //    }
    //}
}
