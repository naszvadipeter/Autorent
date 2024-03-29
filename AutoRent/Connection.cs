using AutoRent.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    internal class Connection
    {
        public const string URL = "https://localhost:7253";

        public Connection() { }

        public int? Login(string username, string password)
        {
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(new { username = username, password = password });
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                string response = client.UploadString(new Uri($"{URL}/login"), "POST", dataString);
                return ToNullableInt(response);
            }
        }

        public User GetUser(int userId)
        {
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString($"{URL}/getUser?id={userId}");

                User user = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(response);

                return user;
            }
        }

        public List<Car> GetAllCars()
        {
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString($"{URL}/getAllCars");
                List<Car> carsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Car>>(response);
                return carsList;
            }
        }

        public Image GetCarImage(int carId)
        {
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString($"{URL}/getCarImage?carId={carId}");

                string base64String = JsonConvert.DeserializeObject<string>(response);
                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
        }

        #region Extra methods
        public static int? ToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i)) 
                return i;
            return null;
        }
        #endregion
    }
}
