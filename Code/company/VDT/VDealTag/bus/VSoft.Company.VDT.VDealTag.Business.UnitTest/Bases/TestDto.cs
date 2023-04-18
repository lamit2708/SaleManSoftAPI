using VSoft.Company.VDT.VDealTag.Business.Dto.Data;

namespace VSoft.Company.VDT.VDealTag.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual VDealTagDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual VDealTagDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.CustomerName = fullName;
        return e;
    }

    public virtual VDealTagDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual VDealTagDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.CustomerName = arr[1];
        return e;
    }

    public virtual VDealTagDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        e.CustomerName = fullName;
        
        return e;
    }

    protected abstract VDealTagDto Dto { get; }
}
