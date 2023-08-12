using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries
{
    public class GetByIdOrderDetailQueryRequest : IRequest<ResultOrderDetailDto>
    {
        public int Id { get; set; }

        public GetByIdOrderDetailQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
