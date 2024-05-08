using EkartApp.Models;

namespace EkartApp.Repositary
{
    public interface CustomerRepository
    {
        IEnumerable<Customer> GetCustomersByOrderDate(DateTime orderDate);
        Customer GetCustomerWithHighestOrder();
    }
}
