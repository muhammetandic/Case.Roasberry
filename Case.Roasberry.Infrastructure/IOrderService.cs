using Case.Roasberry.Infrastructure.Shopify.Models.Orders;

namespace Case.Roasberry.Infrastructure;
public interface IOrderService
{
    Task PersistOrder(Order order);
}
