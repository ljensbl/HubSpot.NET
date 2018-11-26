using HubSpot.NET.Api.Properties.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotCompanyPropertyGroupsApi
    {
        PropertiesListHubSpotModel<CompanyPropertyGroupHubSpotModel> GetAll();
        CompanyPropertyGroupHubSpotModel Create(CompanyPropertyGroupHubSpotModel property);
    }
}
