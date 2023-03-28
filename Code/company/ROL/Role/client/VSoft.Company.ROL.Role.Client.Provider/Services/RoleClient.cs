using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ROL.Role.Api.Cfg.Routes;
using VSoft.Company.ROL.Role.Business.Dto.Request;
using VSoft.Company.ROL.Role.Business.Dto.Response;
using VSoft.Company.ROL.Role.Client.Models;
using VSoft.Company.ROL.Role.Client.Services;

namespace VSoft.Company.ROL.Role.Client.Provider.Services;

public class RoleClient : ApiDtoClientJSon<IRoleClient, MRoleClient>, IRoleClient
{
    public RoleClient(IConfigurationRoot configuration, MRoleClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IRoleControllerPath.Role);

    public Task<RoleFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, RoleFindDtoResponse>(relativePath, request);
    }

    public Task<RoleFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, RoleFindRangeDtoResponse>(relativePath, request);
    }

    public Task<RoleInsertDtoResponse> CreateAsync(RoleInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.CreateOne));
        return PostAsync<RoleInsertDtoRequest, RoleInsertDtoResponse>(relativePath, request);
    }

    public Task<RoleInsertRangeDtoResponse> CreateRangeAsync(RoleInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.CreateRange));
        return PostAsync<RoleInsertRangeDtoRequest, RoleInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<RoleUpdateDtoResponse> UpdateAsync(RoleUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.UpdateOne));
        return PutAsync<RoleUpdateDtoRequest, RoleUpdateDtoResponse>(relativePath, request);
    }

    public Task<RoleUpdateRangeDtoResponse> UpdateRangeAsync(RoleUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.UpdateRange));
        return PutAsync<RoleUpdateRangeDtoRequest, RoleUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<RoleDeleteDtoResponse> DeleteAsync(RoleDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.DeleteOne));
        return DeleteAsync<RoleDeleteDtoRequest, RoleDeleteDtoResponse>(relativePath, request);
    }

    public Task<RoleDeleteRangeDtoResponse> DeleteRangeAsync(RoleDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.DeleteRange));
        return DeleteAsync<RoleDeleteRangeDtoRequest, RoleDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<RoleSaveRangeDtoResponse> SaveRangeAsync(RoleSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IRoleActionName.SaveRange));
        return PostAsync<RoleSaveRangeDtoRequest, RoleSaveRangeDtoResponse>(relativePath, request);
    }
}