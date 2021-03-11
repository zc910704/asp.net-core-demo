using IServer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : Controller
    {
        // GET: api/Blog
        /// <summary>
        /// Sum接口
        /// </summary>
        /// <param name="i">参数i</param>
        /// <param name="j">参数j</param>
        /// <returns></returns>
        [HttpGet]
        public int Get(int i, int j)
        {
            IAdvertisementServices advertisementServices = new AdvertisementServices();
            return advertisementServices.Sum(i, j);
        }

    }
}
