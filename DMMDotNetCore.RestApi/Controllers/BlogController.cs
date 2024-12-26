using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DMMDotNetCore.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        public IActionResult Read()
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult Create()
        {

            return Ok();
        }

        [HttpPut]
        public IActionResult Update()
        {

            return Ok();
        }

        [HttpPatch]
        public IActionResult Patch()
        {

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {

            return Ok();
        }
    }
}
