using Twilio.TwiML.Messaging;
            using MessageLib;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public Task TestMethod1()
        {
            
            var twilioGateway = new TwilioGateway("AC71c4fe6d98f7983cd93e50ee958e2c43", "9ace5e0e021e859a517230895a00e84f", "+19299305876");

            // Create a messaging service instance
            var messagingService = new MessagingService(twilioGateway);

            // Send an SMS
            var message = new MessageLib.Message
            {
                recipient = "+420778090078",
                content = "Hello"
            };

            Task isMessageSent = messagingService.SendMessageAsync(message);
            
            Assert.IsTrue(true);
            return isMessageSent;
        }
    }
}