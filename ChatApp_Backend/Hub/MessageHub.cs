using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
namespace ChatApp_Backend.Hub
{
    public class MessageHub : Hub<IMessageHub>
    {
        public async Task SendMessage(string message)
        {
            await Clients.Others.ReceiveMessage(message);
        }
    }
}
