using Application.Models.DTO_s;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class MappingService : Profile
    {
        public MappingService()
        {
            CreateMap<Client, ClientDTO>();

            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.ProductsIds,
                opt => opt.MapFrom(src => src.OrderProducts
                .Select(op => op.ProductId)));

            CreateMap<Market, MarketDTO>();

            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.OrdersIds,
                opt => opt.MapFrom(src => src.OrderProducts
                .Select(op => op.OrderId)));
        }
    }
}
