using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLib
{
    /// <summary>
    /// Unified class for sending messages trought all different future gateways.
    /// </summary>
    public class MessagingService
    {
        private IMessagingGateway gateway;

        public MessagingService(IMessagingGateway gateway)
        {
            this.gateway = gateway;
        }

        /// <summary>
        /// method for sending Message trough chosen gateway
        /// might need added logic in future but its not needed now
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Returns true if message was sent succesfuly. False if wasnt.</returns>
        public async Task<bool> SendMessageAsync(Message message)
        {
            return await gateway.SendAsync(message);
        }
    }
}
