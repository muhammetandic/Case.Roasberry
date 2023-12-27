using Case.Roasberry.Application.Features.Statistics.Queries.DailySales;
using Case.Roasberry.Application.Features.Statistics.Queries.MonthlySales;
using Case.Roasberry.Core.Entities;

namespace Case.Roasberry.Application.Contracts.Persistence;
public interface IOrderRepository : IGenericRepository<Order>
{
    List<DailySalesDto> GetDailySales();
    List<MonthlySalesDto> GetMonthlySales();
}
