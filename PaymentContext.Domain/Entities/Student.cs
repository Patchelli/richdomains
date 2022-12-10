using PaymentContext.Domain.Enum;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscritions;
        public Student(Name name, EDocumentType document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscritions = new List<Subscription>();
        }

        public Name Name { get; set; }
        public EDocumentType Document { get; set; }
        public Email Email { get; set; }
        public Address Address { get; set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get; set; }
    }
}