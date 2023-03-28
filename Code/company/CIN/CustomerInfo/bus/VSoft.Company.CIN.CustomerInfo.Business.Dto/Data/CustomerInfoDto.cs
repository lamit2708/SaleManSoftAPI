namespace VSoft.Company.CIN.CustomerInfo.Business.Dto.Data
{
    public class CustomerInfoDto
    {
        public long Id { get; set; }

        public int? CustomerSourceId { get; set; }

        public string? Hobby { get; set; }

        public string? Job { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool? IsMarrage { get; set; }

        public override string ToString()
        {
            return $"{Id} / {CustomerSourceId}";
        }
    }
}
