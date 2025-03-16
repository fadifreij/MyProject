using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControllerApiVersioning.Controllers.v1
{
    [ApiVersion(1,Deprecated = true)]
    [Route("api/v{v:apiVersion}/[controller]")]
    [ApiController]
    public partial class ItemsController : ControllerBase
    {
        [MapToApiVersion(1)]
      
        public IActionResult GetItemsV1()
        {
            var apiVersion = HttpContext.GetRequestedApiVersion();
            if (apiVersion!.MajorVersion == 1)
            {
                return Ok(new { message = "This API version is deprecated and will be removed in the future." });
            }

            return Ok("This is item version 1");
        }


    }
}
