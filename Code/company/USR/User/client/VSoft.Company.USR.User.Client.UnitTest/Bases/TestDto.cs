using VSoft.Company.USR.User.Business.Dto.Data;

namespace VSoft.Company.USR.User.Client.UnitTest.Bases;

public abstract class TestDto
{
    public virtual UserDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual UserDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.FullName = fullName;
        return e;
    }

    public virtual UserDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual UserDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.FullName = arr[1];
        return e;
    }

    public virtual UserDto GetUpdateDto(int id, string fullName, string description)
    {
        var e = Dto;
        e.Id = id;
        e.FullName = fullName;        
        return e;
    }

    protected abstract UserDto Dto { get; }
}
