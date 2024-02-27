using FluentValidation.Results;
using MediatR;
using Posto.Core.Messages;
using System.Text.Json.Serialization;

namespace Core.Util.Application
{
    public class CommandAdd : Message, IRequest<ValidationResult>
    {
        [JsonIgnore]
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        public ValidationResult? ValidationResult { get; set; }
        [JsonIgnore]
        public Guid UsuarioId { get; set; }
        [JsonIgnore]
        public Guid CompanyId { get; set; }
        protected CommandAdd()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }

    public class CommandUpd : Message, IRequest<ValidationResult>
    {
        [JsonIgnore]
        public DateTime Timestamp { get; set; }
        [JsonIgnore]
        public ValidationResult? ValidationResult { get; set; }
        public int Id { get; set; }
        public Guid UsuarioId { get; set; }
        [JsonIgnore]
        public Guid CompanyId { get; set; }

        protected CommandUpd()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
