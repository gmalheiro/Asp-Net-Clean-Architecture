using GloboTicket.TicketManagement.Applicati.Models.Mail;

namespace GloboTicket.TicketManagement.Applicati.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
