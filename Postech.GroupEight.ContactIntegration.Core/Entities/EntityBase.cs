using Postech.GroupEight.ContactIntegration.Core.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Postech.GroupEight.ContactIntegration.Core.Entities
{
    [ExcludeFromCodeCoverage]
    public abstract class EntityBase : IEntity
    {
        public Guid Id { get; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime? ModifiedAt { get; protected set; }
        public bool Active { get; protected set; }
    }
}
