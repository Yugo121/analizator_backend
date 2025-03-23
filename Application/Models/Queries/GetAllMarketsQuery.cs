using Application.Models.DTO_s;
using MediatR;

namespace Application.Models.Queries
{
    public record GetAllMarketsQuery : IRequest<List<MarketDTO>>;
}
