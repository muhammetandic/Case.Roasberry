using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Features.Statistics.Queries.DailySales;
using Case.Roasberry.Application.Features.Statistics.Queries.MonthlySales;
using Case.Roasberry.Core.Entities;
using System.Globalization;

namespace Case.Roasberry.Persistence.Repositories;
public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    private readonly ApplicationDbContext _context;
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public List<DailySalesDto> GetDailySales()
    {
        var result = from order in _context.Orders
                     group order by DateOnly.FromDateTime(order.OrderDate.Date) into g
                     orderby DateOnly.FromDateTime(g.First().OrderDate.Date) ascending
                     select new DailySalesDto
                     {
                         DateOfSales = DateOnly.FromDateTime(g.First().OrderDate.Date),
                         TotalSales = g.Sum(p => p.LastPrice)
                     };
        return result.ToList();
    }

    public List<MonthlySalesDto> GetMonthlySales()
    {
        var result = from order in _context.Orders
                     group order by order.OrderDate.Month into g
                     orderby g.First().OrderDate.Month ascending
                     select new MonthlySalesDto
                     {
                         Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(g.First().OrderDate.Month),
                         TotalSales = g.Sum(p => p.LastPrice)
                     };
        return result.ToList();
    }
}
