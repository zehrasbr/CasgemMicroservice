using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
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
    public class GetByIdOrderingQueryHandler : IRequestHandler<GetByIdOrderingQueryRequest, ResultOrderingDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetByIdOrderingQueryHandler(IMapper mapper, IRepository<Ordering> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ResultOrderingDto> Handle(GetByIdOrderingQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderingDto>(value);
        }
    }
}
