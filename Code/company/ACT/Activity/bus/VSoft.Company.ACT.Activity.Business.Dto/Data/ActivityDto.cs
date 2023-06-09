﻿
namespace VSoft.Company.ACT.Activity.Business.Dto.Data
{
    public class ActivityDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Content { get; set; }
        public string? ActivityType { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string? ToWho { get; set; }
        public string? SubType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }

        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}
