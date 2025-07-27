using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var customerList = new List<Customer>
            {
                new Customer
                {
                    customerId = 100,
                    lastName = "Alagao",
                    firstName = "Mikyle",
                    middleName = "V.",
                    birthDay = new DateTime(1990, 5, 15)
                },
                new PremiumCustomer
                {
                    customerId = 200,
                    lastName = "Valencia",
                    firstName = "Lorene Mikyle",
                    middleName = "A.",
                    birthDay = new DateTime(1985, 3, 20),
                    isVIP = true
                }
            };

            ViewBag.customerList = customerList;
            return View();
        }
    }
}
