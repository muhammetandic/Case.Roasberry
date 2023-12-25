using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Features.Orderlines.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Queries.GetOrderlineById;
public class GetOrderlineByIdQueryHandler : IRequestHandler<GetOrderlineByIdQuery, OrderlineDto>
{
    private readonly IMapper _mapper;
    private readonly IOrderlineRepository _orderlineRepository;

    public GetOrderlineByIdQueryHandler(IMapper mapper, IOrderlineRepository orderlineRepository)
    {
        _mapper = mapper;
        _orderlineRepository = orderlineRepository;
    }

    public async Task<OrderlineDto> Handle(GetOrderlineByIdQuery request, CancellationToken cancellationToken)
    {
        var orderline = await _orderlineRepository.GetByIdAsync(request.Id);
        var orderlineDto = _mapper.Map<OrderlineDto>(orderline);
        return orderlineDto;
    }
}
