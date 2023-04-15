using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Business.Dto.Extension.Methods;

public static class CustomerDtoMethods
{
    public static MCustomerEntity GetEntity(this CustomerDto src, bool isForUpdate)
    {
        return new MCustomerEntity()
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
            Hobby = src.Hobby,
		    Job = src.Job,
            BirthDate = src.BirthDate,
            IsMarrage = src.IsMarrage,
            CustomerSourceId = src.CustomerSourceId,
            Keyword = src.Keyword,

};
    }
}
