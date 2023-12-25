using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Exceptions;
using Case.Roasberry.Core.Entities;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.UpdateOrderline;
public class UpdateOrderlineCommandHandler : IRequestHandler<UpdateOrderlineCommand>
{
    private readonly IMapper _mapper;
    private readonly IOrderlineRepository _orderlineRepository;
    public UpdateOrderlineCommandHandler(IMapper mapper, IOrderlineRepository orderlineRepository)
    {
        _mapper = mapper;
        _orderlineRepository = orderlineRepository;
    }

    public async Task Handle(UpdateOrderlineCommand request, CancellationToken cancellationToken)
    {
        var orderlineToUpdate = await _orderlineRepository.GetByIdAsync(request.Id);
        if (orderlineToUpdate == null)
        {
            throw new NotFoundException(nameof(Orderline), request.Id);
        }
        var validator = new UpdateOrdelineValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
        {
            throw new ValidationException(validationResult);
        }

        orderlineToUpdate = _mapper.Map<Orderline>(request);
        await _orderlineRepository.UpdateAsync(orderlineToUpdate);
    }
}
