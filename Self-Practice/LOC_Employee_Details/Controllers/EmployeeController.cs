using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LOC_Employee_Details.Controllers
{
    public class EmployeeController : Controller
    {
        private IConfiguration Configuration;

        public EmployeeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult Index()
        {
            SqlConnection EmpConn = new SqlConnection(this.Configuration.GetConnectionString("myconnection"));
            EmpConn.Open();

            SqlCommand EmpCmd = EmpConn.CreateCommand();
            EmpCmd.CommandType = System.Data.CommandType.StoredProcedure;
            EmpCmd.CommandText = "PR_SelectAll_Employee";
            SqlDataReader sdr = EmpCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            return View();
        }
    }
}
