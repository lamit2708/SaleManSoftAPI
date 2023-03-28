namespace VSoft.Company.TIC.Ticket.Business.Dto.Data
{
    public class TicketDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public long CustomerId { get; set; }

        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}
