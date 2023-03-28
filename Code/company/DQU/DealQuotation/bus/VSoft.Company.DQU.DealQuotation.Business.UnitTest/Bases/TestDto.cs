using VSoft.Company.DQU.DealQuotation.Business.Dto.Data;

namespace VSoft.Company.DQU.DealQuotation.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual DealQuotationDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual DealQuotationDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual DealQuotationDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual DealQuotationDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.Name = arr[1];
        return e;
    }

    public virtual DealQuotationDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract DealQuotationDto Dto { get; }
}
