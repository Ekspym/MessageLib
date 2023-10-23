using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MessageLib
{
    /// <summary>
    /// Twilio sms sending gateway using IMessaginGateway.
    /// </summary>
    public class TwilioGateway : IMessagingGateway
    {
        
        private readonly string accountSid;
        private readonly string authToken;
        private readonly string fromPhoneNumber;

        public TwilioGateway(string accountSid, string authToken, string fromPhoneNumber)
        {
            // Needed values for twilio
            this.accountSid = accountSid;
            this.authToken = authToken;
            this.fromPhoneNumber = fromPhoneNumber;
        }

        /// <summary>
        ///  Logic for sending SMS trough Twilio api using their library
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Return true if status == sent</returns>
        public async Task<bool> SendAsync(Message message)
        {
            try
            {
                TwilioClient.Init(accountSid, authToken);

                MessageResource twilioMessage = await MessageResource.CreateAsync(
                    body: message.content,
                    from: new PhoneNumber(fromPhoneNumber),
                    to: new PhoneNumber(message.recipient)
                );

                return twilioMessage.Status == MessageResource.StatusEnum.Sent;              
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Twilio send error: {ex.Message}");
                return false;
            }
        }
    }
}
