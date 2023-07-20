using SophartVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SophartVidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> _customers;


        public CustomersController()
        {
            _customers = GetCustomers();
        }

        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers);
        }

        public ActionResult Detail(int id)
        {
            var customer = _customers.SingleOrDefault(c => c.Id == id);

            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer{Id =1, Name = "Sophart"},
                new Customer{Id =2, Name = "Lakkhena"},
                new Customer{Id =3, Name = "Panhakvoan"},
            };

            return customers;
        }


    }
}