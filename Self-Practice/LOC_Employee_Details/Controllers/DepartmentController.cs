using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LOC_Employee_Details.Controllers
{
    public class DepartmentController : Controller
    {
        private IConfiguration Configuration;

        public DepartmentController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult Index()
        {
            SqlConnection DeptConn = new SqlConnection(this.Configuration.GetConnectionString("myconnection"));
            DeptConn.Open();

            SqlCommand DeptCmd = DeptConn.CreateCommand();
            DeptCmd.CommandType = System.Data.CommandType.StoredProcedure;
            DeptCmd.CommandText = "PR_SelectAll_Department";
            SqlDataReader sdr = DeptCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            return View(dt);
        }
    }
}
