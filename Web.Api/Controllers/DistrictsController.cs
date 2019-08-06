using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Web.Api.Controllers
{
    [Authorize(Policy = "ApiUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        // GET api/districts/coordinates
        [HttpGet("coordinates")]
        public IActionResult Coordinates()
        {
            string jsonString = "{type:\"FeatureCollection\",features:[{id:0,geometry:{type:\"Point\",coordinates:[53.86,27.550]},properties:{balloonContent:\"Октябрьский район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:1,geometry:{type:\"Point\",coordinates:[53.86,27.602]},properties:{balloonContent:\"Ленинский район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:2,geometry:{type:\"Point\",coordinates:[53.87,27.632]},properties:{balloonContent:\"Заводской район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:3,geometry:{type:\"Point\",coordinates:[53.906,27.636]},properties:{balloonContent:\"Партизанский район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:4,geometry:{type:\"Point\",coordinates:[53.940,27.631]},properties:{balloonContent:\"Первомайский район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:5,geometry:{type:\"Point\",coordinates:[53.942,27.585]},properties:{balloonContent:\"Советский район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:6,geometry:{type:\"Point\",coordinates:[53.937,27.530]},properties:{balloonContent:\"Центральный район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:7,geometry:{type:\"Point\",coordinates:[53.9089,27.455]},properties:{balloonContent:\"Фрунзенский район\"},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}},{id:8,geometry:{type:\"Point\",coordinates:[53.873,27.480]},options:{iconLayout:'default#image',iconImageHref:'../../assets/rob22.png',iconImageSize:[70,89],iconImageOffset:[-5,-38]}}]}";
            object coordinates = JsonConvert.DeserializeObject(jsonString);

            return new OkObjectResult(coordinates);
        }
    }
}