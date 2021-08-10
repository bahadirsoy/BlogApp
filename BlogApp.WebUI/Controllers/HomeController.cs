using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        
        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult Index()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnectionString");

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand com = new SqlCommand("Select count(*) from Table_Category", connection);
            var count = (int)com.ExecuteScalar();

            ViewData["TotalData"] = count;

            connection.Close();

            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
