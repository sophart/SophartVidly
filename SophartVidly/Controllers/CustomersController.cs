using SophartVidly.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SophartVidly.ViewModels.Customers;

namespace SophartVidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;


        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(x => x.Id == id);

            return View(customer);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var customer = new CustomerForCreationViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View(customer);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(m => m.Id == id);

            if (customerInDb == null) return HttpNotFound();

            var membershipTypes = _context.MembershipTypes.ToList();

            var customer = new CustomerForUpdateViewModel()
            {
                Id = customerInDb.Id,
                Name = customerInDb.Name,
                BirthDate = customerInDb.BirthDate,
                MembershipTypeId = customerInDb.MembershipTypeId,
                MembershipTypes = membershipTypes,
                IsSubscribedToNewsletter = customerInDb.IsSubscribedToNewsletter,
            };
            
            return View(customer);
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            var customerInDb = _context.Customers.SingleOrDefault(m => m.Id == customer.Id);

            if (customerInDb == null)
            {
                return HttpNotFound();
            }
            customerInDb.Name = customer.Name;
            customerInDb.BirthDate = customer.BirthDate;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}