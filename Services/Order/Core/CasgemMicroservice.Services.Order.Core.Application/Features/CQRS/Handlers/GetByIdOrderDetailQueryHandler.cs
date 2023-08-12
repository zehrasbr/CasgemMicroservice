using Amazon.Runtime.Internal;
using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetByIdOrderDetailQueryHandler : IRequestHandler<GetByIdOrderDetailQueryRequest, ResultOrderDetailDto>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public GetByIdOrderDetailQueryHandler(IMapper mapper, IRepository<OrderDetail> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ResultOrderDetailDto> Handle(GetByIdOrderDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderDetailDto>(value);
        }
    }
}
