using System;
using System.Collections.Generic;
using System.Text;

namespace TicketManagement.Application.Models.Mail
{
    class EmailSettings
    {
        public string ApiKey { get; set; }
        public string FromAddress { get; set; }
        public string FromName { get; set; }
    }
}
