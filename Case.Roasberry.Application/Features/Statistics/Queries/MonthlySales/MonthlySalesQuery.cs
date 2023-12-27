using MediatR;

namespace Case.Roasberry.Application.Features.Statistics.Queries.MonthlySales;
public class MonthlySalesQuery : IRequest<List<MonthlySalesDto>>
{
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
}
