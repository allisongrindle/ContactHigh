using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AfterHours.ContactHigh.Controllers;
using AfterHours.ContactHigh.Domain.Contact;
using Moq;

namespace AfterHours.ContactHigh.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new Mock<IContactRepository>();
            var controller = new ContactController(repo.Object);

            controller.Get();
        }
    }
}
