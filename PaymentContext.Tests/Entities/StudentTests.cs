using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Entities;
using Xunit;

namespace PaymentContext.Tests.Entities
{
    public class StudentTests
    {
        [Fact]
        public void TestName()
        {
            var sub = new Subscription(null);
            var student = new Student("Patrick", "Patchelli", "10.900.199-6", "ppatchelli@gmail.com");
        }
    }
}