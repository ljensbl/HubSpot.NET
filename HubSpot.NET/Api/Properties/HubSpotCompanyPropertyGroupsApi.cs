using HubSpot.NET.Api.Properties.Dto;
using HubSpot.NET.Core.Interfaces;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpot.NET.Api.Properties
{
    public class HubSpotCompanyPropertyGroupsApi : IHubSpotCompanyPropertyGroupsApi
    {
        private readonly IHubSpotClient _client;

        public HubSpotCompanyPropertyGroupsApi(IHubSpotClient client)
        {
            _client = client;
        }

        public CompanyPropertyGroupHubSpotModel Create(CompanyPropertyGroupHubSpotModel group)
        {
            var path = $"{new PropertiesListHubSpotModel<CompanyPropertyGroupHubSpotModel>().RouteBasePath}";

            return _client.Execute<CompanyPropertyGroupHubSpotModel>(path, group, Method.POST, convertToPropertiesSchema: false);
        }

        public PropertiesListHubSpotModel<CompanyPropertyGroupHubSpotModel> GetAll()
        {
            var path = $"{new PropertiesListHubSpotModel<CompanyPropertyGroupHubSpotModel>().RouteBasePath}";

            return _client.ExecuteList<PropertiesListHubSpotModel<CompanyPropertyGroupHubSpotModel>>(path, convertToPropertiesSchema: false);
        }
    }
}
