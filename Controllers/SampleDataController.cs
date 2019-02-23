using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fifaCoinsBestEver.Models;
using Microsoft.AspNetCore.Mvc;

namespace fifaCoinsBestEver.Controllers
{
    [Produces("application/json")]
    [Route("api/test")]
    public class SampleDataController : Controller
    {
        private readonly Context _context;

        public SampleDataController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public User GetFirstUser()
        {
            return _context.users.First();
        }
    }
}