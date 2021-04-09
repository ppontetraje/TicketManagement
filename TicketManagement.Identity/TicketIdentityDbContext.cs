using TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TicketManagement.Identity
{
    public class TicketIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public TicketIdentityDbContext(DbContextOptions<TicketIdentityDbContext> options) : base(options)
        {
        }
    }
}
