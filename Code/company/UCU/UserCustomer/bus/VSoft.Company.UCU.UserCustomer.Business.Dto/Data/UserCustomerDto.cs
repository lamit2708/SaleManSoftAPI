﻿namespace VSoft.Company.UCU.UserCustomer.Business.Dto.Data
{
    public class UserCustomerDto
    {
        public int Id { get; set; }

        public long CustomerId { get; set; }

        public int? UserId { get; set; }

        public int? TeamId { get; set; }

        public DateTime CreatedDateTeam { get; set; }

        public DateTime CreatedDateUser { get; set; }

        public string? CustomerFullName { get; set; }

        public string? UserFullName { get; set; }

        public string? TeamName { get; set; }

        public override string ToString()
        {
            return $"{Id} / {CustomerId}";
        }
    }
}
