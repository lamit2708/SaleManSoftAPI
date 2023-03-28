using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Api.Cfg.Routes;
using VSoft.Company.TIC.Ticket.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Business.Dto.Response;
using VSoft.Company.TIC.Ticket.Client.Models;
using VSoft.Company.TIC.Ticket.Client.Services;

namespace VSoft.Company.TIC.Ticket.Client.Provider.Services;

public class TicketClient : ApiDtoClientJSon<ITicketClient, MTicketClient>, ITicketClient
{
    public TicketClient(IConfigurationRoot configuration, MTicketClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(ITicketControllerPath.Ticket);

    public Task<TicketFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, TicketFindDtoResponse>(relativePath, request);
    }

    public Task<TicketFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, TicketFindRangeDtoResponse>(relativePath, request);
    }

    public Task<TicketInsertDtoResponse> CreateAsync(TicketInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.CreateOne));
        return PostAsync<TicketInsertDtoRequest, TicketInsertDtoResponse>(relativePath, request);
    }

    public Task<TicketInsertRangeDtoResponse> CreateRangeAsync(TicketInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.CreateRange));
        return PostAsync<TicketInsertRangeDtoRequest, TicketInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<TicketUpdateDtoResponse> UpdateAsync(TicketUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.UpdateOne));
        return PutAsync<TicketUpdateDtoRequest, TicketUpdateDtoResponse>(relativePath, request);
    }

    public Task<TicketUpdateRangeDtoResponse> UpdateRangeAsync(TicketUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.UpdateRange));
        return PutAsync<TicketUpdateRangeDtoRequest, TicketUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<TicketDeleteDtoResponse> DeleteAsync(TicketDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.DeleteOne));
        return DeleteAsync<TicketDeleteDtoRequest, TicketDeleteDtoResponse>(relativePath, request);
    }

    public Task<TicketDeleteRangeDtoResponse> DeleteRangeAsync(TicketDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.DeleteRange));
        return DeleteAsync<TicketDeleteRangeDtoRequest, TicketDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<TicketSaveRangeDtoResponse> SaveRangeAsync(TicketSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITicketActionName.SaveRange));
        return PostAsync<TicketSaveRangeDtoRequest, TicketSaveRangeDtoResponse>(relativePath, request);
    }
}