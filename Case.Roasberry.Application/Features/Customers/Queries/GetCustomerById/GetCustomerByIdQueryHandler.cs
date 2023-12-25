using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Exceptions;
using Case.Roasberry.Application.Features.Customers.Shared;
using Case.Roasberry.Core.Entities;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Queries.GetCustomerById;
public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
{
    private readonly IMapper _mapper;
    private readonly ICustomerRepository _customerRepository;

    public GetCustomerByIdQueryHandler(IMapper mapper, ICustomerRepository customerRepository)
    {
        _mapper = mapper;
        _customerRepository = customerRepository;
    }

    public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        var customer = await _customerRepository.GetByIdAsync(request.Id);
        if (customer == null)
        {
            throw new NotFoundException(nameof(Customer), request.Id);
        }
        var customerDto = _mapper.Map<CustomerDto>(customer);
        return customerDto;
    }
}
