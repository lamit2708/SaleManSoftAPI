using VegunSoft.Framework.Api.Service.UnitTest.Methods;
using VSoft.Company.ACT.Activity.Api.Base.Methods;
using VSoft.Company.CTM.Customer.Api.Base.Methods;
using VSoft.Company.DEA.Deal.Api.Base.Methods;
using VSoft.Company.DST.DealStep.Api.Base.Methods;
using VSoft.Company.PRC.ProductCategory.Api.Base.Methods;
using VSoft.Company.PRO.Product.Api.Base.Methods;
using VSoft.Company.TEA.Team.Api.Base.Methods;
using VSoft.Company.UCU.UserCustomer.Api.Base.Methods;
using VSoft.Company.USR.User.Api.Base.Methods;
using VSoft.Company.VDT.VDealTag.Api.Base.Methods;
using VSoft.Company.PRF.ProductFeature.Api.Base.Methods;
using VSoft.Company.ORD.Order.Api.Base.Methods;

var builder = WebApplication.CreateBuilder(args);
builder.RegisterTestApi((services, configuration) =>
{
    services.RegisterTeamServices(configuration);
    services.RegisterActivityServices(configuration);
    services.RegisterCustomerServices(configuration);
    services.RegisterDealServices(configuration);
    services.RegisterProductServices(configuration);
    services.RegisterUserServices(configuration);
    services.RegisterProductCategoryServices(configuration);
    services.RegisterDealStepServices(configuration);
    services.RegisterVDealTagServices(configuration);
    services.RegisterUserCustomerServices(configuration);
    services.RegisterProductFeatureServices(configuration);
    services.RegisterOrderServices(configuration);
});
