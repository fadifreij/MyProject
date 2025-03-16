using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControllerApiVersioning.Controllers.v2
{
    [ApiVersion(2)]
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiController]
    public partial class ItemsController : ControllerBase
    {
        [MapToApiVersion(2)]
        public IActionResult GetItemsV2()
        {
            return Ok("This is item version 2");
        }
    }
}
