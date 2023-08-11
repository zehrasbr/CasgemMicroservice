using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
    public class AddressProfile : Profile
    {
        public AddressProfile() 
        { 
            CreateMap<ResultAddressDto, Address>().ReverseMap();
            CreateMap<CreateAddressDto, Address>().ReverseMap();
            CreateMap<UpdateAddressDto, Address>().ReverseMap();
        }
    }
}
