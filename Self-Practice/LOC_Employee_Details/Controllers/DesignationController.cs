using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LOC_Employee_Details.Controllers
{
    public class DesignationController : Controller
    {
        private IConfiguration Configuration;
        
        public DesignationController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult Index()
        {
            SqlConnection connection = new SqlConnection(this.Configuration.GetConnectionString("myconnection"));
            connection.Open();

            SqlCommand DesigCommand = connection.CreateCommand();
            DesigCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DesigCommand.CommandText = "PR_SelectAll_Designation";
            SqlDataReader sdr = DesigCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            return View(dt);
        }
    }
}
