using HubSpot.NET.Api.Properties.Dto;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotContactPropertiesApi
    {
        PropertiesListHubSpotModel<ContactPropertyHubSpotModel> GetAll();
        ContactPropertyHubSpotModel Create(ContactPropertyHubSpotModel property);
        ContactPropertyHubSpotModel Update(ContactPropertyHubSpotModel property);
    }
}
