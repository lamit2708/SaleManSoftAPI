using VSoft.Company.TIC.Ticket.Business.Dto.Data;

namespace VSoft.Company.TIC.Ticket.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual TicketDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual TicketDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.Name = fullName;
        return e;
    }

    public virtual TicketDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual TicketDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.Name = arr[1];
        return e;
    }

    public virtual TicketDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        e.Name = fullName;
        
        return e;
    }

    protected abstract TicketDto Dto { get; }
}
