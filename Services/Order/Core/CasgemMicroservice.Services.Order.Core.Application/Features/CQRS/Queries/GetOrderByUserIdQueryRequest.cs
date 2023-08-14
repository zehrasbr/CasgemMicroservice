using Amazon.Runtime.Internal;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetOrderByUserIdQueryRequest : IRequest<List<ResultOrderingDto>>
    {
        public string Id { get; set; }
    }
}
