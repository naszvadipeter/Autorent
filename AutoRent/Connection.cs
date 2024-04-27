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
        public const string URL = "http://localhost:5240";

        private static string BearerToken = null;
        public static User User = null;

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

                User user = JsonConvert.DeserializeObject<User>(response);

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
                byte[] imageBytes = JsonConvert.DeserializeObject<byte[]>(response);

                Image image;
                if (imageBytes != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                else
                    image = new Bitmap(16, 16); // "Empty" image

                return image;
            }
        }

        public List<Category> GetAllCategories()
        {
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString($"{URL}/getAllCategories");
                List<Category> categoryList = JsonConvert.DeserializeObject<List<Category>>(response);
                return categoryList;
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
