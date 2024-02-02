using GloboTicket.TicketManagement.Applicati.Responses;

namespace GloboTicket.TicketManagement.Applicati.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse: BaseResponse
    {
        public CreateCategoryCommandResponse(): base()
        {

        }

        public CreateCategoryDto Category { get; set; } = default!;
    }
}