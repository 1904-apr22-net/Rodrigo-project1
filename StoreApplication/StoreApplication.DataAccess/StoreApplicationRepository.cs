using Microsoft.EntityFrameworkCore;
using StoreApplication.DataAccess.Entities;
using StoreApplication.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using StoreApplication.Library;

namespace StoreApplication.DataAccess
{
    public class StoreApplicationRepository 
    {
        private readonly ProjectDBContext _dbContext;

        public StoreApplicationRepository(ProjectDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            //_logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Library.Customer> GetCustomer(string search = null)
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Customers> customers =
                _dbContext.Customers.Include(c => c.Location).AsNoTracking();
            if (search != null)
            {
                customers = customers.Where(c => c.FirstName.Contains(search));
            }
            return Mapper.Map(customers);
        }

        public Library.Customer GetCustomerById(int id)
        {
            Customers customer = _dbContext.Customers.Include(c => c.Location).AsNoTracking().First(c => c.Id == id); 
            return Mapper.Map(customer);
        }

        public List<Library.Order> GetOrdersCust(int id, Customer cust)
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Orders> orders =
                _dbContext.Orders.Include(c => c.OrderItem).ThenInclude(p => p.Product).AsNoTracking();
            orders = orders.Where(c => c.CustomerId == id);
            //customers = customers.Where(c => c.LastName.Contains(search));
            List<Order> ordersToReturn = new List<Library.Order>();
            foreach (Orders o in orders)
            {
                Library.Order or = new Order();
                or.Id = o.Id;
                or.OrderTime = o.Time;
                or.Customer = cust;
                //ProductsOrdered =
                foreach (OrderItem p in o.OrderItem)
                {
                    //or.ProductsOrdered.Concat((p.Product.Name + ", "));
                    or.ProductsOrdered.Add(p.Product.Name);
                    or.Price += p.Product.Price;

                }
                ordersToReturn.Add(or);
            }
            return ordersToReturn;
        }

        public IEnumerable<Library.Location> GetLocation(string search = null)
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Entities.Location> locations =
                _dbContext.Location;
            if (search != null)
            {
                locations = locations.Where(c => c.Name.Contains(search));
            }
            return Mapper.Map(locations);
        }

        public Library.Location GetLocationById(int id)
        {
            Entities.Location location = _dbContext.Location.First(l => l.Id == id);
            return Mapper.Map(location);
        }

        public List<Library.Order> GetOrdersLoc(int id, Library.Location loc)
        {
            // disable unnecessary tracking for performance benefit
            IQueryable<Orders> orders =
                _dbContext.Orders.Include(c => c.OrderItem).ThenInclude(p => p.Product).AsNoTracking();
            orders = orders.Where(c => c.LocationId == id);
            //customers = customers.Where(c => c.LastName.Contains(search));
            List<Order> ordersToReturn = new List<Library.Order>();
            foreach (Orders o in orders)
            {
                Library.Order or = new Order();
                or.Id = o.Id;
                or.OrderTime = o.Time;
                or.Location = loc;
                //or.Customer = o.Customer;
                //ProductsOrdered =
                foreach (OrderItem p in o.OrderItem)
                {
                    //or.ProductsOrdered.Concat((p.Product.Name+", "));
                    or.ProductsOrdered.Add(p.Product.Name);
                    or.Price += p.Product.Price;

                }
                ordersToReturn.Add(or);
            }
            return ordersToReturn;
        }

        public int CreateOrder(int CustId, int LocId)
        {
            Entities.Orders NewOrder = new Orders();
            int id = 0;
            int temp = 0;
            IQueryable<Orders> orders = _dbContext.Orders;
            foreach(Orders x in orders)
            {
                temp = x.Id;
                if(temp > id)
                {
                    id = temp;
                }
            }
            id++;
            NewOrder.Id = id;
            NewOrder.CustomerId = CustId;
            NewOrder.LocationId = LocId;
            NewOrder.Time = DateTime.Now;
            _dbContext.Add(NewOrder);
            return NewOrder.Id;
        }

        public int CreateBurgers(int burger, int orderId)
        {
            int id = 0;
            int temp = 0;
            IQueryable<OrderItem> orderItem = _dbContext.OrderItem;
            foreach (OrderItem x in orderItem)
            {
                temp = x.Id;
                if (temp > id)
                {
                    id = temp;
                }
            }
            id++;
            for (int i=0; i < burger; i++)
            {
                Entities.OrderItem NewItem = new OrderItem();
                NewItem.Id = id;
                NewItem.ProductId = 1;
                NewItem.OrderId = orderId;
                _dbContext.Add(NewItem);
                id++;
            }
            return id;
        }

        public int CreateFries(int fries, int orderId, int id)
        {
            for (int i = 0; i < fries; i++)
            {
                Entities.OrderItem NewItem = new OrderItem();
                NewItem.Id = id;
                NewItem.ProductId = 2;
                NewItem.OrderId = orderId;
                _dbContext.Add(NewItem);
                id++;
            }
            return id;
        }

        public void CreateDrinks(int drinks, int orderId, int id)
        {
            for (int i = 0; i < drinks; i++)
            {
                Entities.OrderItem NewItem = new OrderItem();
                NewItem.Id = id;
                NewItem.ProductId = 3;
                NewItem.OrderId = orderId;
                _dbContext.Add(NewItem);
                id++;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
