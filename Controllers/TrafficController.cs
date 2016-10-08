using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VizceralAPI.Models;
using VizceralAPI.Services;

namespace VizceralAPI.Controllers
{
    [Route("api/[controller]")]
    public class TrafficController : Controller
    {
        ITrafficAggregator _trafficAggregator;

        public TrafficController(ITrafficAggregator trafficAggregator)
        {
            _trafficAggregator = trafficAggregator;
        }

        // GET api/traffic
        [HttpGet]
        public async Task<Traffic> Get()
        {            
            return await _trafficAggregator.Latest(1); 
        }

        // GET api/traffic/5
        [HttpGet("{minutes}")]
        public async Task<Traffic> Get(int minutes)
        {
            return await _trafficAggregator.Latest(minutes); 
        }
    }
}
