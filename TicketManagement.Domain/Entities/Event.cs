﻿using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.Domain.Common;

namespace TicketManagement.Domain.Entities
{
    class Event : AuditableEntity
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
