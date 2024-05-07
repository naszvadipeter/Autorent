using AutoRentServer.Models.Autorent;
using Newtonsoft.Json;
using System.Net.WebSockets;
using System.Text;

namespace AutoRentServer.WebSocket.Handlers
{
    public class UserHandler : WebSocketHandler
    {
        public UserHandler(ConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {
        }

        public override async Task ReceiveAsync(System.Net.WebSockets.WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            AutorentContext _autorent = new AutorentContext();

            var message = $"{Encoding.UTF8.GetString(buffer, 0, result.Count)}";

            User? newUser = null;
            try
            {
                newUser = JsonConvert.DeserializeObject<User>(message);
            }
            catch (Exception ex) 
            { 
                await Console.Out.WriteLineAsync(ex.Message); 
            }


            if (newUser != null)
            {
                _autorent.Users.Add(newUser); // Add user to database
                _autorent.SaveChanges();

                // Send all users (again) to all client
                List<User> users = _autorent.Users.ToList();
                string allUsers = JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });

                await SendMessageToAllAsync(allUsers);
            }

        }
    }
}