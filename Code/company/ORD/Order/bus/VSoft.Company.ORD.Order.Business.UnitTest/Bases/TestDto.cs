using VSoft.Company.ORD.Order.Business.Dto.Data;

namespace VSoft.Company.ORD.Order.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual OrderDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual OrderDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual OrderDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual OrderDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.Name = arr[1];
        return e;
    }

    public virtual OrderDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract OrderDto Dto { get; }
}
