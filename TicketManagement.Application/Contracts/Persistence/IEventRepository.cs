using TicketManagement.Domain.Entities;
using System;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}
