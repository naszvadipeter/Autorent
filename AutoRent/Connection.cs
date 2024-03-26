using AutoRent.Models;
using System;
using System.Collections.Generic;
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

        public List<Car> GetAllCars()
        {
            using (var wb = new WebClient())
            {
                var response = wb.DownloadString($"{URL}/getAllCars");
                List<Car> carsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Car>>(response);
                return carsList;
            }
        }
    }
}
