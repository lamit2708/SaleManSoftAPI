using VSoft.Company.UCU.UserCustomer.Business.Dto.Data;

namespace VSoft.Company.UCU.UserCustomer.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual UserCustomerDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual UserCustomerDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual UserCustomerDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual UserCustomerDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.Name = arr[1];
        return e;
    }

    public virtual UserCustomerDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract UserCustomerDto Dto { get; }
}
