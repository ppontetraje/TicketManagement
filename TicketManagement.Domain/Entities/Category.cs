using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.Domain.Common;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Domain
{
    class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
