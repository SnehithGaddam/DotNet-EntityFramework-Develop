using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace WebApiSample.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class OrderDetail : ITrackable
    {
        [DataMember]
        public int OrderDetailId { get; set; }
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
        [DataMember]
        public short Quantity { get; set; }
        [DataMember]
        public float Discount { get; set; }
        [DataMember]
        public Order Order { get; set; }
        [DataMember]
        public Product Product { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
