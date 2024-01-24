using AutoMapper;
using GloboTicket.TicketManagement.Applicati.Contracts.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Applicati.Contracts.Features.Events.Queries.GetEventsList;
using GloboTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Applicati.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap(); 
        }
    }
}
