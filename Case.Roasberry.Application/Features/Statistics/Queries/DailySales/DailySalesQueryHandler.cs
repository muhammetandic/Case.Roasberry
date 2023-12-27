using Case.Roasberry.Application.Contracts.Persistence;
using MediatR;

namespace Case.Roasberry.Application.Features.Statistics.Queries.DailySales;
public class DailySalesQueryHandler : IRequestHandler<DailySalesQuery, List<DailySalesDto>>
{
    private readonly IOrderRepository _orderRepository;

    public DailySalesQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task<List<DailySalesDto>> Handle(DailySalesQuery request, CancellationToken cancellationToken)
    {
        var result = _orderRepository.GetDailySales();
        return Task.FromResult(result);
    }
}
