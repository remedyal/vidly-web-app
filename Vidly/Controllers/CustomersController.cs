using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Smith"},
            new Customer { Id = 2, Name = "Mary Williams"}
        };

        public ActionResult Index()
        {
            var viewModel = new IndexCustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("customers/details")]
        [Route("customers/details/{id:int}")]
        public ActionResult Details(int id)
        {
            var customer = customers.Where(x => x.Id == id).SingleOrDefault();

            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }
    }
}