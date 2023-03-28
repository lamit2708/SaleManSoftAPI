using VSoft.Company.PRI.Priority.Business.Dto.Data;

namespace VSoft.Company.PRI.Priority.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual PriorityDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual PriorityDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.Name = fullName;
        return e;
    }

    public virtual PriorityDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual PriorityDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.Name = arr[1];
        return e;
    }

    public virtual PriorityDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        e.Name = fullName;
        
        return e;
    }

    protected abstract PriorityDto Dto { get; }
}
