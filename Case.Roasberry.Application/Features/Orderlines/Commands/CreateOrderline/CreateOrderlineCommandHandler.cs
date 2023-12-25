using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Exceptions;
using Case.Roasberry.Application.Features.Orderlines.Shared;
using Case.Roasberry.Core.Entities;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.CreateOrderline;
public class CreateOrderlineCommandHandler : IRequestHandler<CreateOrderlineCommand, OrderlineDto>
{
    private readonly IMapper _mapper;
    private readonly IOrderlineRepository _orderlineRepository;

    public CreateOrderlineCommandHandler(IMapper mapper, IOrderlineRepository orderlineRepository)
    {
        _mapper = mapper;
        _orderlineRepository = orderlineRepository;
    }

    public async Task<OrderlineDto> Handle(CreateOrderlineCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateOrderlineValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        var orderline = _mapper.Map<Orderline>(request);
        orderline = await _orderlineRepository.InsertAsync(orderline);
        var orderlineDto = _mapper.Map<OrderlineDto>(orderline);
        return orderlineDto;
    }
}
