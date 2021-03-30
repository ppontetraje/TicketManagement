using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.Application.Features.Events.Queries.GetEventsList;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();

            CreateMap<Category, CategoryDto>();
        }
    }
}
