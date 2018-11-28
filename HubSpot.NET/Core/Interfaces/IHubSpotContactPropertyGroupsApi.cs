using HubSpot.NET.Api.Properties.Dto;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotContactPropertyGroupsApi
    {
        PropertiesListHubSpotModel<ContactPropertyGroupHubSpotModel> GetAll();
        ContactPropertyGroupHubSpotModel Create(ContactPropertyGroupHubSpotModel property);
    }
}
