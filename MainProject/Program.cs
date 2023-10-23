// Initialize the Twilio gateway with your credentials
using Twilio.TwiML.Messaging;
using MessageLib;

var twilioGateway = new TwilioGateway("AC71c4fe6d98f7983cd93e50ee958e2c43", "9ace5e0e021e859a517230895a00e84f", "+19299305876");

// Create a messaging service instance
var messagingService = new MessagingService(twilioGateway);

// Send an SMS
var message = new MessageLib.Message
{
    recipient = "+420778090078",
    content = "Hello"
};

bool isMessageSent = await messagingService.SendMessageAsync(message);

string s = "s";
Console.WriteLine(s);