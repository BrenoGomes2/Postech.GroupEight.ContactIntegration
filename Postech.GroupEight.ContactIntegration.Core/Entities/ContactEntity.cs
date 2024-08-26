using Postech.GroupEight.ContactIntegration.Core.ValueObjects;

namespace Postech.GroupEight.ContactIntegration.Core.Entities
{
    public class ContactEntity : EntityBase
    {
        public ContactNameValueObject ContactName { get; set; }

        public ContactPhoneValueObject ContactPhone { get; set; }

        public string Email { get; set; }
    }
}
