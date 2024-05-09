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

        public User Login(string username, string password)
        {
            using (var client = new WebClient())
            {
                var dataString = JsonConvert.SerializeObject(new { username = username, password = password });
                client.Headers.Add(HttpRequestHeader.ContentType, "" + "application/json");
                client.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = client.UploadString(new Uri($"{URL}/login"), "POST", dataString);
                }catch (Exception ex)
                {
                    return null;
                }

                var result = JsonConvert.DeserializeAnonymousType(response, new { Token = "", User = new User() });
                BearerToken = result.Token;
                User = result.User;

                return result.User;
            }
        }

        public User GetUser(int userId)
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getUser?id={userId}");
                }
                catch (Exception ex)
                {
                    return null;
                }

                User user = JsonConvert.DeserializeObject<User>(response);

                return user;
            }
        }

        public List<User> GetAllUsers()
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getAllUsers");
                }
                catch (Exception ex)
                {
                    return null;
                }

                List<User> users = JsonConvert.DeserializeObject<List<User>>(response);

                return users;
            }
        }

        public List<Car> GetAllCars()
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getAllCars");
                }
                catch (Exception ex)
                {
                    return null;
                }

                List<Car> carsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Car>>(response);
                return carsList;
            }
        }

        public Image GetCarImage(int carId)
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getCarImage?carId={carId}");
                }
                catch (Exception ex)
                {
                    return null;
                }

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
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getAllCategories");
                }
                catch (Exception ex)
                {
                    return null;
                }

                List<Category> categoryList = JsonConvert.DeserializeObject<List<Category>>(response);
                return categoryList;
            }
        }

        public bool AddRental(int UserId, int CarId, string FromDate, string ToDate)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                var dataString = JsonConvert.SerializeObject(new { UserId, CarId, FromDate, ToDate });
                client.Headers.Add(HttpRequestHeader.ContentType, "" + "application/json");
                client.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = client.UploadString(new Uri($"{URL}/addRental"), "POST", dataString);
                }
                catch (Exception ex)
                {
                    return false;
                }

                return response.Equals("\"OK\"");
            }
        }

        public List<Rental> GetRentals(int userID)
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getRentals?userID={userID}");
                }
                catch (Exception ex)
                {
                    return null;
                }

                List<Rental> rentalList = JsonConvert.DeserializeObject<List<Rental>>(response);
                return rentalList;
            }
        }

        public Car GetCar(int carID)
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getCar?carID={carID}");
                }
                catch (Exception ex)
                {
                    return null;
                }

                Car car = JsonConvert.DeserializeObject<Car>(response);
                return car;
            }
        }

        public Sale GetSale(int saleID)
        {
            using (var wb = new WebClient())
            {
                wb.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {BearerToken}");
                wb.Encoding = Encoding.UTF8;
                string response;
                try
                {
                    response = wb.DownloadString($"{URL}/getSale?saleID={saleID}");
                }
                catch (Exception ex)
                {
                    return null;
                }

                Sale sale = JsonConvert.DeserializeObject<Sale>(response);
                return sale;
            }
        }
    }
}
