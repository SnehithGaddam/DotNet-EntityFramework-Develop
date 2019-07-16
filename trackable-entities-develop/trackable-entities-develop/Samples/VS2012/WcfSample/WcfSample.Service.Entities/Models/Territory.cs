using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace WcfSample.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Territory : ITrackable
    {
        public Territory()
        {
            this.Employees = new List<Employee>();
        }

        [DataMember]
        public string TerritoryId { get; set; }
        [DataMember]
        public string TerritoryDescription { get; set; }
        [DataMember]
        public List<Employee> Employees { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
