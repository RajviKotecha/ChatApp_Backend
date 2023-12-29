namespace ChatApp_Backend.Hub
{
    public interface IMessageHub
    {
        Task ReceiveMessage(string message);
    }
}
