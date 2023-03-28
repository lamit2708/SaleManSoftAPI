using VSoft.Company.PRC.ProductCategory.Business.Dto.Data;

namespace VSoft.Company.PRC.ProductCategory.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual ProductCategoryDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual ProductCategoryDto GetCreateDto(string fullName)
    {
        var e = Dto;
        e.Name = fullName;
        return e;
    }

    public virtual ProductCategoryDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual ProductCategoryDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        e.Name = arr[1];
        return e;
    }

    public virtual ProductCategoryDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        e.Name = fullName;

        return e;
    }

    protected abstract ProductCategoryDto Dto { get; }
}
