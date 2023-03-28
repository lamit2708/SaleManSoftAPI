using VSoft.Company.CSO.CustomerSource.Business.Dto.Data;

namespace VSoft.Company.CSO.CustomerSource.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual CustomerSourceDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual CustomerSourceDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.Name = fullName;
        return e;
    }

    public virtual CustomerSourceDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual CustomerSourceDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.Name = arr[1];
        return e;
    }

    public virtual CustomerSourceDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        e.Name = fullName;
        
        return e;
    }

    protected abstract CustomerSourceDto Dto { get; }
}
