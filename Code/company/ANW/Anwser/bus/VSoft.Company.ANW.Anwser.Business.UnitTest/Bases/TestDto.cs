using VSoft.Company.ANW.Anwser.Business.Dto.Data;

namespace VSoft.Company.ANW.Anwser.Business.UnitTest.Bases;

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
        //e.Name = fullName;
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
        //e.Name = arr[1];
        return e;
    }

    public virtual AnwserDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract AnwserDto Dto { get; }
}
