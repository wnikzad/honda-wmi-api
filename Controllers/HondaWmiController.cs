using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HondaWmiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HondaWmiController : ControllerBase
    {
        private readonly string _dataFilePath = "honda_wmi.json"; // path to your JSON file

        [HttpGet]
        public IActionResult Get()
        {
            string jsonData = System.IO.File.ReadAllText(_dataFilePath);
            var hondaWmis = JsonConvert.DeserializeObject<List<HondaWmi>>(jsonData);
            return Ok(hondaWmis);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            string jsonData = System.IO.File.ReadAllText(_dataFilePath);
            var hondaWmis = JsonConvert.DeserializeObject<List<HondaWmi>>(jsonData);
            var hondaWmi = hondaWmis.FirstOrDefault(x => x.Id == id);
            if (hondaWmi == null)
            {
                return NotFound();
            }
            return Ok(hondaWmi);
        }
    }
}
