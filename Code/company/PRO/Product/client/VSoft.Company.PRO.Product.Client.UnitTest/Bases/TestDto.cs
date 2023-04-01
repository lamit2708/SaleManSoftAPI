using VSoft.Company.PRO.Product.Business.Dto.Data;

namespace VSoft.Company.PRO.Product.Client.UnitTest.Bases;

public abstract class TestDto
{
    public virtual ProductDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual ProductDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.Name = fullName;
        return e;
    }

    public virtual ProductDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual ProductDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.Name = arr[1];
        return e;
    }

    public virtual ProductDto GetUpdateDto(int id, string fullName, string description)
    {
        var e = Dto;
        e.Id = id;
        e.Name = fullName;        
        return e;
    }

    protected abstract ProductDto Dto { get; }
}
