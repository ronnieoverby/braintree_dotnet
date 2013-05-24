using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Braintree;
using Braintree.Exceptions;

namespace Braintree.Tests
{
    [TestFixture]
    public class CustomerRequestTest
    {
        [Test]
        public void ToXml_Includes_DeviceSessionId()
        {
            var request = new CustomerRequest()
            {
                CreditCard = new CreditCardRequest()
                {
                    DeviceSessionId = "my_dsid"
                }
            };

            Assert.IsTrue(request.ToXml().Contains("my_dsid"));
        }
    }
}
