﻿using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Business.entity.Extension.Methods;

public static class CustomerEntityMethods
{
    public static CustomerDto GetDto(this MCustomerEntity src)
    {
        return new CustomerDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            //CustomerInfoId = src.CustomerInfoId,
            IsBought = src.IsBought,
            BirthDate = src.BirthDate,
            Keyword = src.Keyword,
            CustomerSourceId = src.CustomerSourceId,
            IsMarrage = src.IsMarrage,
            Job = src.Job,
            Hobby = src.Hobby
        };
    }
    public static List<CustomerDto> GetDto(this List<MCustomerEntity> srcs)
    {
        var rs = new List<CustomerDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
