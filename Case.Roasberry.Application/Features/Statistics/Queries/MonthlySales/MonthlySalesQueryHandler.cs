using Case.Roasberry.Application.Contracts.Persistence;
using MediatR;

namespace Case.Roasberry.Application.Features.Statistics.Queries.MonthlySales;
public class MonthlySalesQueryHandler : IRequestHandler<MonthlySalesQuery, List<MonthlySalesDto>>
{
    private readonly IOrderRepository _orderRepository;

    public MonthlySalesQueryHandler(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task<List<MonthlySalesDto>> Handle(MonthlySalesQuery request, CancellationToken cancellationToken)
    {
        var result = _orderRepository.GetMonthlySales();
        return Task.FromResult(result);
    }
}
