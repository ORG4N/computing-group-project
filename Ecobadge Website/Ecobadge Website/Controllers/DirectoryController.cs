using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Ecobadge_Website.Services;
using Ecobadge_Website.Model;

namespace Ecobadge_Website.Controllers
{
    [Route("api/business")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Business> Get()
        {
            return BusinessService.GetData().ToArray();
        }
    }
}