using VSoft.Company.TEA.Team.Business.Dto.Data;

namespace VSoft.Company.TEA.Team.Client.UnitTest.Bases;

public abstract class TestDto
{
    public virtual TeamDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual TeamDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.FullName = fullName;
        return e;
    }

    public virtual TeamDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual TeamDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.FullName = arr[1];
        return e;
    }

    public virtual TeamDto GetUpdateDto(int id, string fullName, string description)
    {
        var e = Dto;
        e.Id = id;
        //e.FullName = fullName;        
        return e;
    }

    protected abstract TeamDto Dto { get; }
}
