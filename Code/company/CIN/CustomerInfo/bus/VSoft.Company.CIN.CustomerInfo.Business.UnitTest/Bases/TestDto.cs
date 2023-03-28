using VSoft.Company.CIN.CustomerInfo.Business.Dto.Data;

namespace VSoft.Company.CIN.CustomerInfo.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual CustomerInfoDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual CustomerInfoDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual CustomerInfoDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual CustomerInfoDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.Name = arr[1];
        return e;
    }

    public virtual CustomerInfoDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract CustomerInfoDto Dto { get; }
}
