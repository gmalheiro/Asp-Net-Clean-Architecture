using AutoMapper;
using GloboTicket.TicketManagement.Applicati.Contracts.Infrastructure;
using GloboTicket.TicketManagement.Applicati.Contracts.Persistence;
using GloboTicket.TicketManagement.Applicati.Models.Mail;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Applicati.Contracts.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository? _eventRepository;
        private readonly IMapper? _mapper;
        private readonly IEmailService? _emailService;

        public CreateEventCommandHandler(IEventRepository eventRepository, IMapper mapper, IEmailService? emailService)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _emailService = emailService;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper?.Map<Event>(request);

            var validator = new CreateEventCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            @event = await _eventRepository!.AddAsync(@event!);

            //Sending email notification to admin address
            var email = new Email()
            {
                To = "gabriel@malheiro.com",
                Body = $"A new event was created:{request}",
                Subject = "A new event was created"
            };

            try
            {
                await _emailService!.SendEmail(email);
            }
            catch (Exception ex)
            {

                throw;
            }

            return @event.EventId;
        }
    }
}
