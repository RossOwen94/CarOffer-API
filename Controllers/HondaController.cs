using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CarOffer_API.Models;




namespace CarOffer_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HondaController : ControllerBase
    {

        private readonly ILogger<HondaController> _logger;

        public HondaController(ILogger<HondaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Honda> Get()
        {

            var json = System.IO.File.ReadAllText("./Data/honda_wmi.json");

            JArray jsonArray = JArray.Parse(json);

            var list = new List<Honda>();

            foreach (JObject item in jsonArray)
            {
                string name = item.GetValue("Name").ToString();
                string country = item.GetValue("Country").ToString();
                string createdOn = item.GetValue("CreatedOn").ToString();
                string dateAvailable = item.GetValue("DateAvailableToPublic").ToString();
                int id = item.GetValue("Id").ToObject<int>();
                string updatedOn = item.GetValue("UpdatedOn").ToString();
                string vehicleType = item.GetValue("VehicleType").ToString();
                string wmi = item.GetValue("WMI").ToString();

                var newHonda = new Honda(name,country,createdOn,dateAvailable,id,updatedOn,vehicleType,wmi);

                list.Add(newHonda);
            }

            return list;
        }
    }
}
