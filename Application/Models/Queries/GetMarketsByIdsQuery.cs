using Application.Models.DTO_s;
using MediatR;

namespace Application.Models.Queries
{
    public record GetMarketsByIdsQuery(List<Guid> ids) : IRequest<List<MarketDTO>>;
}
