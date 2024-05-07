using AutoRentServer.Models.Autorent;
using Newtonsoft.Json;
using System.Net.WebSockets;
using System.Text;

namespace AutoRentServer.WebSocket
{
    public abstract class WebSocketHandler
    {
        protected ConnectionManager WebSocketConnectionManager { get; set; }

        public WebSocketHandler(ConnectionManager webSocketConnectionManager)
        {
            WebSocketConnectionManager = webSocketConnectionManager;
        }

        public virtual async Task OnConnected(System.Net.WebSockets.WebSocket socket)
        {
            AutorentContext _autorent = new AutorentContext();
            List<User> users = _autorent.Users.ToList();
            string allUsers = JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });

            WebSocketConnectionManager.AddSocket(socket);
            await SendMessageAsync(socket, allUsers);
        }

        public virtual async Task OnDisconnected(System.Net.WebSockets.WebSocket socket)
        {
            await WebSocketConnectionManager.RemoveSocket(WebSocketConnectionManager.GetId(socket));
        }

        public async Task SendMessageAsync(System.Net.WebSockets.WebSocket socket, string message)
        {
            if (socket.State != WebSocketState.Open)
                return;

            await socket.SendAsync(buffer: new ArraySegment<byte>(array: Encoding.UTF8.GetBytes(message),
                                                                    offset: 0,
                                                                    count: Encoding.UTF8.GetBytes(message).Length),
                                    messageType: WebSocketMessageType.Text,
                                    endOfMessage: true,
                                    cancellationToken: CancellationToken.None);
        }

        public async Task SendMessageAsync(string socketId, string message)
        {
            await SendMessageAsync(WebSocketConnectionManager.GetSocketById(socketId), message);
        }

        public async Task SendMessageToAllAsync(string message)
        {
            foreach (var pair in WebSocketConnectionManager.GetAll())
            {
                if (pair.Value.State == WebSocketState.Open)
                    await SendMessageAsync(pair.Value, message);
            }
        }

        public abstract Task ReceiveAsync(System.Net.WebSockets.WebSocket socket, WebSocketReceiveResult result, byte[] buffer);
    }
}
