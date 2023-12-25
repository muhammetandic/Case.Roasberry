using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Features.Orderlines.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Queries.GetOrderlines;
public class GetOrderlinesQueryHandler : IRequestHandler<GetOrderlinesQuery, List<OrderlineDto>>
{
    private readonly IMapper _mapper;
    private readonly IOrderlineRepository _orderlineRepository;

    public GetOrderlinesQueryHandler(IMapper mapper, IOrderlineRepository orderlineRepository)
    {
        _mapper = mapper;
        _orderlineRepository = orderlineRepository;
    }

    public async Task<List<OrderlineDto>> Handle(GetOrderlinesQuery request, CancellationToken cancellationToken)
    {
        var orderlines = await _orderlineRepository.GetAllAsync();
        var orderlinesDto = _mapper.Map<List<OrderlineDto>>(orderlines);
        return orderlinesDto;
    }
}
