using VSoft.Company.ACT.Activity.Business.Dto.Data;

namespace VSoft.Company.ACT.Activity.Client.UnitTest.Bases;

public abstract class TestDto
{
    public virtual ActivityDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual ActivityDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.FullName = fullName;
        return e;
    }

    public virtual ActivityDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual ActivityDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.FullName = arr[1];
        return e;
    }

    public virtual ActivityDto GetUpdateDto(int id, string fullName, string description)
    {
        var e = Dto;
        e.Id = id;
        //e.FullName = fullName;        
        return e;
    }

    protected abstract ActivityDto Dto { get; }
}
