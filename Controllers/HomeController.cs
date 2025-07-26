using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Models;
using System.Diagnostics;

namespace PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<IDescribable> customers = new List<IDescribable>
            {
                new Customer { Id = 1, Name = "John Doe", Email = "john@example.com" },
                new PremiumCustomer { Id = 2, Name = "Jane Smith", Email = "jane@example.com", MembershipLevel = "Gold" }
            };

            return View(customers);
        }
    }
}
