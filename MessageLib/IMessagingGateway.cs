using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLib
{
    /// <summary>
    /// Interface for unified gateway creation. Use it for any sending method.
    /// </summary>
    public interface IMessagingGateway
    {
        Task<bool> SendAsync(Message message);
    }
}
