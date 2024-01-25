using MediatR;

namespace GloboTicket.TicketManagement.Applicati.Features.Categories.Commands.DeleteEvent
{
    public class DeleteEventCommand : IRequest
    {
        public Guid EventId { get; set; }
    }
}
