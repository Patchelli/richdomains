
using PaymentContext.Shared.Valuesbjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}