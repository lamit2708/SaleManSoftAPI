using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Api.Cfg.Routes;
using VSoft.Company.URO.UserRole.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Business.Dto.Response;
using VSoft.Company.URO.UserRole.Client.Models;
using VSoft.Company.URO.UserRole.Client.Services;

namespace VSoft.Company.URO.UserRole.Client.Provider.Services;

public class UserRoleClient : ApiDtoClientJSon<IUserRoleClient, MUserRoleClient>, IUserRoleClient
{
    public UserRoleClient(IConfigurationRoot configuration, MUserRoleClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IUserRoleControllerPath.UserRole);

    public Task<UserRoleFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, UserRoleFindDtoResponse>(relativePath, request);
    }

    public Task<UserRoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, UserRoleFindRangeDtoResponse>(relativePath, request);
    }

    public Task<UserRoleInsertDtoResponse> CreateAsync(UserRoleInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.CreateOne));
        return PostAsync<UserRoleInsertDtoRequest, UserRoleInsertDtoResponse>(relativePath, request);
    }

    public Task<UserRoleInsertRangeDtoResponse> CreateRangeAsync(UserRoleInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.CreateRange));
        return PostAsync<UserRoleInsertRangeDtoRequest, UserRoleInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<UserRoleUpdateDtoResponse> UpdateAsync(UserRoleUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.UpdateOne));
        return PutAsync<UserRoleUpdateDtoRequest, UserRoleUpdateDtoResponse>(relativePath, request);
    }

    public Task<UserRoleUpdateRangeDtoResponse> UpdateRangeAsync(UserRoleUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.UpdateRange));
        return PutAsync<UserRoleUpdateRangeDtoRequest, UserRoleUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<UserRoleDeleteDtoResponse> DeleteAsync(UserRoleDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.DeleteOne));
        return DeleteAsync<UserRoleDeleteDtoRequest, UserRoleDeleteDtoResponse>(relativePath, request);
    }

    public Task<UserRoleDeleteRangeDtoResponse> DeleteRangeAsync(UserRoleDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.DeleteRange));
        return DeleteAsync<UserRoleDeleteRangeDtoRequest, UserRoleDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<UserRoleSaveRangeDtoResponse> SaveRangeAsync(UserRoleSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserRoleActionName.SaveRange));
        return PostAsync<UserRoleSaveRangeDtoRequest, UserRoleSaveRangeDtoResponse>(relativePath, request);
    }
}