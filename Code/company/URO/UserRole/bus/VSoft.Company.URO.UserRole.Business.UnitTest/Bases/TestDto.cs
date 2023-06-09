﻿using VSoft.Company.URO.UserRole.Business.Dto.Data;

namespace VSoft.Company.URO.UserRole.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual UserRoleDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual UserRoleDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual UserRoleDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual UserRoleDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.Name = arr[1];
        return e;
    }

    public virtual UserRoleDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract UserRoleDto Dto { get; }
}
