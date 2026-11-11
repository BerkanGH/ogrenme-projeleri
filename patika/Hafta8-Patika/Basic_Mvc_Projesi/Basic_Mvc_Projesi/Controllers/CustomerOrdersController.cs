using Microsoft.AspNetCore.Mvc;
using Basic_Mvc_Projesi.Models;

namespace Basic_Mvc_Projesi.Controllers
{
    public class CustomerOrdersController : Controller
    {
        // Index action, müşteri ve sipariş bilgilerini view'a iletecek
        public IActionResult Index()
        {
            // Örnek bir müşteri oluşturuyoruz
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            // Örnek siparişler oluşturuyoruz
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 1500.99m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Smartphone", Price = 799.99m, Quantity = 2 },
                new Order { Id = 3, ProductName = "Headphones", Price = 199.99m, Quantity = 1 }
            };

            // Customer ve Orders verilerini içeren CustomerOrderViewModel nesnesi oluşturuyoruz
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'a gönderiyoruz
            return View(viewModel);
        }
    }
}
