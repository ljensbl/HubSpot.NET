﻿using HubSpot.NET.Api.Owner.Dto;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotOwnerApi
    {
        OwnerListHubSpotModel GetAll();
    }
}