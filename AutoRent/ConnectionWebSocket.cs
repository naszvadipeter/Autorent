using AutoRent.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRent
{
    delegate void SetDataSourceCallback(dynamic data);
    internal class ConnectionWebSocket
    {
        public const string URL = "wss://localhost:7253/ws/users";
        Uri serverUri;

        private DataGridView UsersDGV;

        public ConnectionWebSocket(ref DataGridView UsersDGV) 
        {
            this.UsersDGV = UsersDGV;
            serverUri = new Uri(URL);
        }

        public async Task ConnectWebSocketAsync()
        {
            using (ClientWebSocket webSocket = new ClientWebSocket())
            {
                await webSocket.ConnectAsync(serverUri, CancellationToken.None);

                await Task.Run(async () =>
                {
                    while (webSocket.State == WebSocketState.Open)
                    {
                        WebSocketReceiveResult result;
                        ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[1024]);

                        string fullMessage = string.Empty;
                        do
                        {
                            result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);
                            string message = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);

                            fullMessage += message;
                        }
                        while (!result.EndOfMessage);

                        // Get users from message JSON
                        var data = JsonConvert.DeserializeObject<List<User>>(fullMessage).Select(x => new
                        {
                            x.Id,
                            x.Username,
                            x.Name,
                            x.Password,
                            x.Role,
                        }).ToList();

                        // Set Data to DGV data source
                        if (UsersDGV.InvokeRequired)
                        {
                            SetDataSourceCallback d = new SetDataSourceCallback(SetDataSource);
                            UsersDGV.Invoke(d, new object[] { data });
                        }
                        else
                        {
                            UsersDGV.DataSource = data;
                        }
                    }
                });
            }
        }

        private void SetDataSource(dynamic data)
        {
            UsersDGV.DataSource = data;
            UsersDGV.AutoResizeColumns();
        }

        // Send data (NEW USER)
        public async Task SendMessageAsync(string username, string password, string name, string role)
        {
            using (ClientWebSocket webSocket = new ClientWebSocket())
            {
                await webSocket.ConnectAsync(serverUri, CancellationToken.None);

                User newUser = new User { Username = username, Password = password, Name = name, Role = role };
                string sendMessage = JsonConvert.SerializeObject(newUser, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                ArraySegment<byte> sendBuffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(sendMessage));
                await webSocket.SendAsync(sendBuffer, WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }
    }
}
