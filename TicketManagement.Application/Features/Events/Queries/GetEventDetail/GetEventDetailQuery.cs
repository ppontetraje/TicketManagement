using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
