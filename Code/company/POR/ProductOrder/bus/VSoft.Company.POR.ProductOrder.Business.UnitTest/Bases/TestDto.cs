using VSoft.Company.POR.ProductOrder.Business.Dto.Data;

namespace VSoft.Company.POR.ProductOrder.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual ProductOrderDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual ProductOrderDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual ProductOrderDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual ProductOrderDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
       // e.Name = arr[1];
        return e;
    }

    public virtual ProductOrderDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract ProductOrderDto Dto { get; }
}
