using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDtos;
using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQueryRequest, ResultAddressDto>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetByIdAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultAddressDto> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultAddressDto>(result);
        }
    }
}
