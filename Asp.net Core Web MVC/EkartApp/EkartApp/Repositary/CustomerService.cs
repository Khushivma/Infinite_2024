using EkartApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EkartApp.Repositary
{
    public class CustomerService
    {
        private readonly NorthwindContext _context;

        public CustomerService(NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetCustomersByOrderDate(DateTime orderDate)
        {
            return _context.Customers
                .Where(c => c.Orders.Any(o => o.OrderDate == orderDate.Date))
                .ToList();
        }

        public Customer GetCustomerWithHighestOrder()
        {
            var customerWithHighestOrder = _context.Customers
                .OrderByDescending(c => c.Orders.Sum(o => o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice)))
                .FirstOrDefault();

            return customerWithHighestOrder;
        }
    }
}
