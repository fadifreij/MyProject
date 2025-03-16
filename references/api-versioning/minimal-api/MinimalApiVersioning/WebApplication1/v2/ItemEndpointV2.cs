using Asp.Versioning.Builder;

namespace WebApplication1.v2
{
    public static class ItemEndpointV2
    {
        public static void MapItemEndpointsV2(this WebApplication app, ApiVersionSet apiVersionSet)
        {
            // GET all items
            app.MapGet("api/v{version:apiVersion}/items", () => "This is get items version 2 ")
               .WithApiVersionSet(apiVersionSet)
               .MapToApiVersion(2); 
        }
    }
}
