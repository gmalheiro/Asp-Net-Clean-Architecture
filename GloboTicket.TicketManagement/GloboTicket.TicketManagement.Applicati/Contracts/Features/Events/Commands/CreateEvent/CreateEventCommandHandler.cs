using AutoMapper;
using GloboTicket.TicketManagement.Applicati.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Applicati.Contracts.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository? _eventRepository;
        private readonly IMapper? _mapper;

        public CreateEventCommandHandler(IEventRepository eventRepository,IMapper mapper)
        { 
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper?.Map<Event>(request);

            @event = await _eventRepository!.AddAsync(@event!);

            return @event.EventId;
        }
    }
}
