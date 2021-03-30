using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}
