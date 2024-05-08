using EkartApp.Models;

namespace EkartApp.Repositary
{
    public interface IOrderRepository
    {
        Order PlaceOrder(Order order);
        Order GetOrderDetails(int orderId);
        IEnumerable<OrderDetail> GetBill(int orderId);
        string? GetCustomersByOrderDate(DateTime orderDate);
        string? GetCustomerWithHighestOrder();
    }
}
