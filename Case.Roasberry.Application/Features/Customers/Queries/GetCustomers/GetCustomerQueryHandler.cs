using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Features.Customers.Shared;
using MediatR;

namespace Case.Roasberry.Application.Features.Customers.Queries.GetCustomers;
public class GetCustomerQueryHandler : IRequestHandler<GetCustomersQuery, List<CustomerDto>>
{
    private readonly IMapper _mapper;
    private readonly ICustomerRepository _customerRepository;

    public GetCustomerQueryHandler(IMapper mapper, ICustomerRepository customerRepository)
    {
        _mapper = mapper;
        _customerRepository = customerRepository;
    }

    public async Task<List<CustomerDto>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
    {
        var customers = await _customerRepository.GetAllAsync();
        var customerDtos = _mapper.Map<List<CustomerDto>>(customers);
        return customerDtos;
    }
}
