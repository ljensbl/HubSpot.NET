using HubSpot.NET.Core.Interfaces;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Properties.Dto
{
    public class ContactPropertyGroupHubSpotModel : IHubSpotModel
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

        public string RouteBasePath => "/contacts/groups";

        public void FromHubSpotDataEntity(dynamic hubspotData)
        {
        }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
        }
    }
}
