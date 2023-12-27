using MediatR;

namespace Case.Roasberry.Application.Features.Statistics.Queries.DailySales;
public class DailySalesQuery : IRequest<List<DailySalesDto>>
{
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
}
