using AutoMapper;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TicketManagement.Application.Contracts.Persistence;
using TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using TicketManagement.Application.Profiles;
using TicketManagement.Domain.Entities;
using TicketManagement.UnitTests.Mocks;
using Xunit;

namespace TicketManagement.UnitTests.Categories.Commands
{
    public class CreateCategoryTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public CreateCategoryTests()
        {
            _mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCategory_AddedToCategoriesRepo()
        {
            var handler = new CreateCategoryCommandHandler(_mapper, _mockCategoryRepository.Object);

            await handler.Handle(new CreateCategoryCommand() { Name = "Test" }, CancellationToken.None);

            var allCategories = await _mockCategoryRepository.Object.ListAllAsync();
            allCategories.Count.ShouldBe(5);
        }
    }
}
