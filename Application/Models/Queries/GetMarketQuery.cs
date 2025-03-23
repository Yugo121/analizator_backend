using Application.Models.DTO_s;
using MediatR;

namespace Application.Models.Queries
{
    public record GetMarketQuery(Guid id) : IRequest<MarketDTO>;
}
