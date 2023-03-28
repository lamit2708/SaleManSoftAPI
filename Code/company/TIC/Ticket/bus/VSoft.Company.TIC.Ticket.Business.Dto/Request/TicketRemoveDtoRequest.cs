using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.TIC.Ticket.Business.Dto.Request
{
    public class TicketRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? TICName { get; set; }
       
    }
}
