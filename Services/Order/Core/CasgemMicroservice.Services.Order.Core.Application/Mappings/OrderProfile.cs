using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDtos;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<ResultOrderDto, Domain.Entities.Order>().ReverseMap();
            CreateMap<CreateOrderDto, Domain.Entities.Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Domain.Entities.Order>().ReverseMap();
        }
    }
}
