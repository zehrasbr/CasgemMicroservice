using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class RemoveOrderDetailCommandRequest : IRequest
    {
        public int Id { get; set; }

        public RemoveOrderDetailCommandRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
