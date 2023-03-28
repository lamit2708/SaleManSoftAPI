using VSoft.Company.ANW.Anwser.Business.Dto.Data;

namespace VSoft.Company.ANW.Anwser.Client.UnitTest.Bases;

public abstract class TestDto
{
    public virtual AnwserDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual AnwserDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.FullName = fullName;
        return e;
    }

    public virtual AnwserDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual AnwserDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.FullName = arr[1];
        return e;
    }

    public virtual AnwserDto GetUpdateDto(int id, string fullName, string description)
    {
        var e = Dto;
        e.Id = id;
        e.FullName = fullName;        
        return e;
    }

    protected abstract AnwserDto Dto { get; }
}
