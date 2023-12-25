using Case.Roasberry.Application.Contracts.Persistence;
using MediatR;

namespace Case.Roasberry.Application.Features.Orderlines.Commands.DeleteOrderline;
public class DeleteOrderlineCommandHandler : IRequestHandler<DeleteOrderlineCommand>
{
    private readonly IOrderlineRepository _orderlineRepository;

    public DeleteOrderlineCommandHandler(IOrderlineRepository orderlineRepository)
    {
        _orderlineRepository = orderlineRepository;
    }

    public async Task Handle(DeleteOrderlineCommand request, CancellationToken cancellationToken)
    {
        await _orderlineRepository.DeleteAsync(request.Id);
    }
}
