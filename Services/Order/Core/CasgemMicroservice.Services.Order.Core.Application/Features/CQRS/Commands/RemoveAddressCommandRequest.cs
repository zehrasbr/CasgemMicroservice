using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Commands
{
    public class RemoveAddressCommandRequest : IRequest
    {
        public int Id { get; set; }

        public RemoveAddressCommandRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
