using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubSpot.NET.Api.Properties.Dto;
using HubSpot.NET.Core.Interfaces;
using RestSharp;

namespace HubSpot.NET.Api.Properties
{
    public class HubSpotContactPropertyGroupsApi : IHubSpotContactPropertyGroupsApi
    {
        private readonly IHubSpotClient _client;

        public HubSpotContactPropertyGroupsApi(IHubSpotClient client)
        {
            _client = client;
        }
        public ContactPropertyGroupHubSpotModel Create(ContactPropertyGroupHubSpotModel property)
        {
            var path = $"{new PropertiesListHubSpotModel<ContactPropertyGroupHubSpotModel>().RouteBasePath}";

            return _client.Execute<ContactPropertyGroupHubSpotModel>(path, property, Method.POST, convertToPropertiesSchema: false);
        }
        public PropertiesListHubSpotModel<ContactPropertyGroupHubSpotModel> GetAll()
        {
            var path = $"{new PropertiesListHubSpotModel<ContactPropertyGroupHubSpotModel>().RouteBasePath}";

            return _client.ExecuteList<PropertiesListHubSpotModel<ContactPropertyGroupHubSpotModel>>(path, convertToPropertiesSchema: false);
        }
    }
}
