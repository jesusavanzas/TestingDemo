using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class CustomerNumitTest
    {
        [Test]
        public void FullName_ReturnEmpty()
        {



            //1. Arrage
            Customer customer = new Customer
            {
                FirstName = "john"
                LastName = "Doe"

            };
            //2. Act
            string result = customer.FuName;

            //3.Assert
            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(" "));
            Assert.That(result, Does.Contain("John"));
            Assert.That(result, Does.Contain("Doe"));
            Assert.That(result, Is.EqualTo("John Doe"));
            Assert.That(result, Does.Contain("John Doe"));




        }

    }
}




