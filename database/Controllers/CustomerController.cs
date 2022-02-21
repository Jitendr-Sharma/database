using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using database.Models;
     


namespace database.Controllers
{
    public class CustomerController : Controller
    {
        public ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            
                List<Customer> Customers = dbContext.Customer.ToList();
                return View(Customers);
            
           

        }
    }
}
