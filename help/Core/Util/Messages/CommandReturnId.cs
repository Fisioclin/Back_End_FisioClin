using System;
using System.Text.Json.Serialization;
using FluentValidation.Results;
using MediatR;

namespace Posto.Core.Messages
{
    public abstract class CommandReturnId : Message, IRequest<ValidationResult>
    {
        [JsonIgnore]
        public DateTime Timestamp { get; private set; }
        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        protected CommandReturnId()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
