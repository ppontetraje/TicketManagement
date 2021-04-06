using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using TicketManagement.Application.Contracts;
using TicketManagement.Domain.Entities;
using Xunit;

namespace TicketManagement.Persistence.IntegrationTests
{
    public class TicketManagementDbContextTests
    {
        private readonly TicketManagementDbContext _globoTicketDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public TicketManagementDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<TicketManagementDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _globoTicketDbContext = new TicketManagementDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }

        [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var ev = new Event() { EventId = Guid.NewGuid(), Name = "Test event" };

            _globoTicketDbContext.Events.Add(ev);
            await _globoTicketDbContext.SaveChangesAsync();

            ev.CreatedBy.ShouldBe(_loggedInUserId);
        }

    }
}
