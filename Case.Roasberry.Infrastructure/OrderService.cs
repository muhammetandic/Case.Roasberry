﻿using Case.Roasberry.Application.Features.Addresses.Commands.CreateAddress;
using Case.Roasberry.Application.Features.Customers.Commands.CreateCustomer;
using Case.Roasberry.Application.Features.Orderlines.Shared;
using Case.Roasberry.Application.Features.Orders.Commands.CreateOrder;
using Case.Roasberry.Application.Features.Products.Shared;
using Case.Roasberry.Infrastructure.Shopify.Models.Orders;
using MediatR;

namespace Case.Roasberry.Infrastructure;
public class OrderService : IOrderService
{
    private readonly IMediator _mediator;

    public OrderService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task PersistOrder(Order order)
    {
        var customerToCreate = new CreateCustomerCommand()
        {
            Email = order.Customer?.Email ?? "",
            FirstName = order.Customer?.FirstName ?? "",
            LastName = order.Customer?.LastName ?? "",
            Phone = order.Customer?.Phone ?? "",
            Nationality = order.Customer?.State ?? "",
        };
        var customer = await _mediator.Send(customerToCreate);

        var invoiceAddressToCreate = new CreateAddressCommand()
        {
            Country = order.BillingAddress?.CountryName,
            City = order.BillingAddress?.City ?? "",
            District = order.BillingAddress?.Province ?? "",
            PostalCode = order.BillingAddress?.Zip,
            AddressLine = order.BillingAddress?.Address1 ?? "",
            CustomerId = customer.Id,
        };
        var invoiceAddress = await _mediator.Send(invoiceAddressToCreate);

        var shippingAddressToCreate = new CreateAddressCommand()
        {
            Country = order.ShippingAddress?.CountryName,
            City = order.ShippingAddress?.City ?? "",
            District = order.ShippingAddress?.Province ?? "",
            PostalCode = order.ShippingAddress?.Zip,
            AddressLine = order.ShippingAddress?.Address1 ?? "",
            CustomerId = customer.Id,
        };
        var shippingAddress = await _mediator.Send(shippingAddressToCreate);

        var orderToCreate = new CreateOrderCommand()
        {
            OrderNumber = order.OrderNumber.ToString(),
            OrderDate = order.CreatedAt,
            TotalPrice = order.TotalPrice ?? 0,
            TotalDiscount = order.TotalDiscounts ?? 0,
            LastPrice = order.TotalPrice ?? 0 - order.TotalDiscounts ?? 0,
            CustomerId = customer.Id,
            InvoiceAddressId = invoiceAddress.Id,
            ShippingAddressId = shippingAddress.Id,
            Orderlines = new List<OrderlineDto>()
        };
        if (order.LineItems?.Length > 0)
        {
            foreach (var orderline in order.LineItems)
            {
                orderToCreate.Orderlines.Add(new OrderlineDto()
                {
                    Quantity = (uint)orderline.Quantity,
                    UnitPrice = orderline.Price ?? 0,
                    Discount = orderline.TotalDiscount ?? 0,
                    Product = new ProductDto()
                    {
                        Name = orderline.Name ?? ""
                    }
                });
            }

        }
        await _mediator.Send(orderToCreate);
    }
}
