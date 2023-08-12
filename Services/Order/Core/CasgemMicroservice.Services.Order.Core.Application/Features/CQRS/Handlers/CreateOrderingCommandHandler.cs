using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Commands;
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
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommandRequest>
    {
        private readonly IRepository<Ordering>  _repository;

        public CreateOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }


        public Task Handle(CreateOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Ordering
            {
                UserID = request.UserID,
                OrderDate =Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                TotalPrice = request.TotalPrice,
            };
            return _repository.CreateAsync(values);
        }
    }
}
