using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class Tests
    {
        private Mock<IMailSender> mockMailSender;
        private CustomerCommLib.CustomerComm customerComm;

        [SetUp]
        public void Setup()
        {
            mockMailSender = new Mock<IMailSender>();
            customerComm = new CustomerCommLib.CustomerComm(mockMailSender.Object);
        }

        [Test]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            // Arrange
            mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            // Act
            bool result = customerComm.SendMailToCustomer();

            // Assert
            Assert.That(result, Is.True);
        }
    }
}