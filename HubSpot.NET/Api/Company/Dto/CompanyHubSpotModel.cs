﻿using System;
using System.Runtime.Serialization;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.Company.Dto
{

    /// <summary>
    /// Models a Company entity within HubSpot. Default properties are included here
    /// with the intention that you'd extend this class with properties specific to 
    /// your HubSpot account.
    /// </summary>
    [DataContract]
    public class CompanyHubSpotModel : IHubSpotModel
    {
        public CompanyHubSpotModel()
        {
            Associations = new CompanyHubSpotAssociations();
        }
        [DataMember(Name = "companyId")]
        [IgnoreDataMember]
        public long? Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "domain")]
        public string Domain { get; set; }

        [DataMember(Name = "website")]
        public string Website { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "createdAt")]
        [IgnoreDataMember]
        public DateTime? CreatedAt { get; set; }

        [DataMember(Name = "updatedAt")]
        [IgnoreDataMember]
        public DateTime? UpdatedAt { get; set; }

        public string RouteBasePath => "/companies/v2";
        public bool IsNameValue => true;

        [IgnoreDataMember]
        public CompanyHubSpotAssociations Associations { get; }

        public virtual void ToHubSpotDataEntity(ref dynamic converted)
        {
        }

        public virtual void FromHubSpotDataEntity(dynamic hubspotData)
        {
        }
    }
}
