using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Posto.Core.Messages
{
    public class Message
    {
        [JsonIgnore]
        public string MessageType { get; protected set; }

        [JsonIgnore]
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
