using AutoMapper;
using Case.Roasberry.Application.Contracts.Persistence;
using Case.Roasberry.Application.Exceptions;
using Case.Roasberry.Core.Entities;
using MediatR;

namespace Case.Roasberry.Application.Features.Products.Commands.UpdateProduct;
public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _productRepository;

    public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var productToUpdate = await _productRepository.GetByIdAsync(request.Id);
        if (productToUpdate == null)
        {
            throw new NotFoundException(nameof(Product), request.Id);
        }
        var validator = new UpdateProductValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            throw new ValidationException(validationResult);
        }

        productToUpdate = _mapper.Map<Product>(request);
        await _productRepository.UpdateAsync(productToUpdate);
    }
}
