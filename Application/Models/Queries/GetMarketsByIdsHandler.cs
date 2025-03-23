using Application.Interfaces;
using Application.Models.DTO_s;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Models.Queries
{
    public class GetMarketsByIdsHandler : IRequestHandler<GetMarketsByIdsQuery, List<MarketDTO>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetMarketsByIdsHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<MarketDTO>> Handle(GetMarketsByIdsQuery request, CancellationToken cancellationToken)
        {
            List<MarketDTO> markets =  _mapper.Map<List<MarketDTO>>
                (await _context.Markets.Where(m => request.ids.Contains(m.Id)).ToListAsync(cancellationToken));

            return markets;
        }
    }
}
