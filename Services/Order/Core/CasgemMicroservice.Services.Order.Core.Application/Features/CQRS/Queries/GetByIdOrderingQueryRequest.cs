using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdOrderingQueryRequest : IRequest<ResultOrderingDto>
    {
        public int Id { get; set; }

        public GetByIdOrderingQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
