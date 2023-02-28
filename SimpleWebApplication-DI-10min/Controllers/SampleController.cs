using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApplication_DI_10min.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        public SampleController(ILogger<SampleController> logger)
        {
        }

    }
}