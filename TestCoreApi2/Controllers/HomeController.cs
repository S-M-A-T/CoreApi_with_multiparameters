using Microsoft.AspNetCore.Mvc;

namespace TestCoreApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet(Name = "GETInt")]

        public int GET(int ID) {
            return ID;
              }
    }
}
