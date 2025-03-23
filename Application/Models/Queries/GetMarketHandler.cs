using Application.Interfaces;
using Application.Models.DTO_s;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Models.Queries
{
    public class GetMarketHandler : IRequestHandler<GetMarketQuery, MarketDTO>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetMarketHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<MarketDTO> Handle(GetMarketQuery request, CancellationToken cancellationToken)
        {
            MarketDTO market = _mapper.Map<MarketDTO>(await _context.Markets.FirstOrDefaultAsync(m => m.Id == request.id));

            return market;
        }
    }
}
