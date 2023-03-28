using VSoft.Company.DAC.DealActivity.Business.Dto.Data;

namespace VSoft.Company.DAC.DealActivity.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual DealActivityDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual DealActivityDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual DealActivityDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual DealActivityDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.Name = arr[1];
        return e;
    }

    public virtual DealActivityDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract DealActivityDto Dto { get; }
}
