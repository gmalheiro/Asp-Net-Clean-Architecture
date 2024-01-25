using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Applicati.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryEventListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
