using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApplication.DataAccess;
using StoreApplication.Library;
using StoreApplication.WebUI.Models;

namespace StoreApplication.WebUI.Controllers
{
    public class CustomerController : Controller
    {
       public StoreApplicationRepository Repo { get; }

       public CustomerController(StoreApplicationRepository repo) =>
           Repo = repo ?? throw new ArgumentNullException(nameof(repo));

        
       public ActionResult Index([FromQuery]string search = "")
       {
          
            IEnumerable<Customer> customers = Repo.GetCustomer(search);
            IEnumerable<CustomerViewModel> viewModels = customers.Select(x => new CustomerViewModel
            {
                Id = x.Id,
                FirstName = x.FirstName,
                //Reviews = x.Reviews.Select(y => new ReviewViewModel()),
                LastName = x.LastName,
                LocationName = x.CustLocation.Name
                //Score = x.Score
            });
            
            return View(viewModels);
        }
  

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer customer = Repo.GetCustomerById(id);
            IEnumerable<Order> orders = Repo.GetOrdersCust(id, customer);
            //String products = Repo.GetProducts(id);
            IEnumerable<OrderViewModel> viewModels = orders.Select(x => new OrderViewModel
            {
                Id = x.Id,
                FirstName = customer.FirstName,
                //Reviews = x.Reviews.Select(y => new ReviewViewModel()),
                LastName = customer.LastName,
                LocationName = customer.CustLocation.Name,
                OrderTime = x.OrderTime,
                Products = x.ProductsOrdered,
                Price = x.Price

                //Score = x.Score
            });
            return View(viewModels);
        }

        // GET: Customer/Create
        public ActionResult Create(int id)
        {
            Customer customer = Repo.GetCustomerById(id);
            OrderViewModel orders = new OrderViewModel();
            orders.FirstName = customer.FirstName;
            orders.LastName = customer.LastName;
            orders.LocationName = customer.CustLocation.Name;
            
            return View(orders);
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderViewModel viewModel)
        {
            try
            {
                Customer cust = Repo.GetCustomerById(viewModel.Id);
                Location loc = cust.CustLocation;
                int OrderId = Repo.CreateOrder(cust.Id, loc.Id);
                int IdOrderItem = Repo.CreateBurgers(viewModel.Burger, OrderId);
                IdOrderItem= Repo.CreateFries(viewModel.Fries, OrderId, IdOrderItem);
                Repo.CreateDrinks(viewModel.Drink, OrderId, IdOrderItem);
                Repo.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}