using MVCIdeaton07._10._2017.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIdeaton07._10._2017.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ComplainModel CM)
        {
            // < add name = "DatabaseEntities" connectionString = "metadata=res://*/Models.ModelDatabase.csdl|res://*/Models.ModelDatabase.ssdl|res://*/Models.ModelDatabase.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Database.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName = "System.Data.EntityClient" />

         //   string connectionString = "metadata=res://*/Models.ModelDatabase.csdl|res://*/Models.ModelDatabase.ssdl|res://*/Models.ModelDatabase.msl;provider=System.Data.SqlClient;provider connection string=';data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Database.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework';";

            string consrt = ConfigurationManager.ConnectionStrings["DatabaseEntities"].ConnectionString;
            using(SqlConnection con = new SqlConnection(consrt))
            {
                string query = "INSERT INTO OurTable(Id,Title,Description,Email,Address,Numbers) VALUES(@Id, @Title, @Description , @Email, @Address, @Numbers)";
                using(SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Id", CM.ID);
                    cmd.Parameters.AddWithValue("@Title", CM.Title);
                    cmd.Parameters.AddWithValue("@Description", CM.Description);
                    cmd.Parameters.AddWithValue("@Email", CM.Email);
                    cmd.Parameters.AddWithValue("@Address", CM.Address);
                    cmd.Parameters.AddWithValue("@Numbers", CM.Number);
                    con.Close();
                }
            }

            return View(CM);
        }

     
    }
}