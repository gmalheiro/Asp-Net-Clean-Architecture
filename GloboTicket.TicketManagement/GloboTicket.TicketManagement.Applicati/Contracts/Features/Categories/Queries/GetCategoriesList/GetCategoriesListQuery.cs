using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Applicati.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryListVm>>
    {
    }
}
