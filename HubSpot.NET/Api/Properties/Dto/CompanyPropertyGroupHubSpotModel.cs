using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.Properties.Dto
{
    public class CompanyPropertyGroupHubSpotModel : IHubSpotModel
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }

        [DataMember(Name = "displayOrder")]
        public long? DisplayOrder { get; set; }

        [DataMember(Name = "hubspotDefined")]
        public bool? HubSpotDefined { get; set; }

        public bool IsNameValue => false;

        public string RouteBasePath => "/companies/groups";

        public void FromHubSpotDataEntity(dynamic hubspotData)
        {
        }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
        }
    }
}
