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
    public class HubSpotContactPropertiesApi : IHubSpotContactPropertiesApi
    {
        private readonly IHubSpotClient _client;

        public HubSpotContactPropertiesApi(IHubSpotClient client)
        {
            _client = client;
        }
        public ContactPropertyHubSpotModel Create(ContactPropertyHubSpotModel property)
        {
            var path = $"{new PropertiesListHubSpotModel<ContactPropertyHubSpotModel>().RouteBasePath}";

            return _client.Execute<ContactPropertyHubSpotModel>(path, property, Method.POST, convertToPropertiesSchema: false);
        }
        public PropertiesListHubSpotModel<ContactPropertyHubSpotModel> GetAll()
        {
            var path = $"{new PropertiesListHubSpotModel<ContactPropertyHubSpotModel>().RouteBasePath}";

            return _client.ExecuteList<PropertiesListHubSpotModel<ContactPropertyHubSpotModel>>(path, convertToPropertiesSchema: false);
        }
    }
}
