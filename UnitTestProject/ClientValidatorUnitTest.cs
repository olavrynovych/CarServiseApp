using System;
using CarServiceApp;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class ClientValidatorUnitTest
    {
        [TestCase("123", false)]
        [TestCase("(095)3334455", true)]
        [TestCase("(999)999-9999", true)]
        [TestCase("1234567890", true)]
        [TestCase("foobar", false)]
        public void TestMethodPhoneNumber(string val, bool result)
        {
            Assert.AreEqual(result, ClientValidator.IsValidClientInfo(new CarServiceApp.Models.Client 
            {
                FirstName = "Name",
                LastName = "Last",
                CellPhone = val
            }));
        }
    }
}
