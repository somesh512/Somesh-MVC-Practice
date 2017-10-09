using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        //Making instance of ApplicationDBContext to connect DB

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        //Since _context is of disposable type need to dispose it

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer/Index
        public ActionResult Index()
        {
            var customer = _context.Customer.Include(c=>c.MembershipType).ToList();
            //this _context.Customer is DbSet which we declared in IdentityModels.cs 
            //to make reference to ApplicationDBContext.

            return View(customer);
        }


        public ActionResult Details(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.ID == id);
                if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        
    }
}