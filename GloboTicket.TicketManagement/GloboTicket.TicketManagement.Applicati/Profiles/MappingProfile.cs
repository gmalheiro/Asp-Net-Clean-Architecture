using AutoMapper;
using GloboTicket.TicketManagement.Applicati.Contracts.Features.Events.Commands.CreateEvent;
using GloboTicket.TicketManagement.Applicati.Contracts.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Applicati.Contracts.Features.Events.Queries.GetEventsList;
using GloboTicket.TicketManagement.Applicati.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Applicati.Features.Categories.Queries.GetCategoriesListWithEvents;
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

            CreateMap<Category,CategoryListVm>().ReverseMap();  
            CreateMap<Category,CategoryEventListVm>().ReverseMap();

            CreateMap<Event,CreateEventCommand>().ReverseMap();
        }
    }
}
