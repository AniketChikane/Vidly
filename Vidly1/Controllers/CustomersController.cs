using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;


namespace Vidly1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult Save(Customers customers)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customers = customers,
                    MembershipTypes = _context.MembershipTypes.ToList()

                };
                return View("CustomerForm", viewModel);

            }
            if (customers.Id == 0)
                _context.Customers.Add(customers);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customers.Id);

                customerInDb.Name = customers.Name;
                customerInDb.Birthdate = customers.Birthdate;
                customerInDb.MembershipTypeId = customers.MembershipTypeId;
                customerInDb.IsSubscribedNewsLetter = customers.IsSubscribedNewsLetter;
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }
        
        public ActionResult New()
        {
            var membershiptypes = _context.MembershipTypes.ToList();

            var ViewModel = new CustomerFormViewModel
            {
                Customers = new Customers(),
                MembershipTypes =membershiptypes
            };

            return View("CustomerForm", ViewModel);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c =>c.Id == id);
            if(customer == null)
                return HttpNotFound();
            var ViewModel = new CustomerFormViewModel
            {
                Customers = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", ViewModel);

        }


        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}