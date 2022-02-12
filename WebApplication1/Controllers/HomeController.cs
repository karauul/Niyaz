using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    
    public class HomeController : Controller
    {
        [HttpGet("getnumber")]
        public int calculator(int a , int b)
        {
            int c = a + b;
            return c;
        }

    }
}
