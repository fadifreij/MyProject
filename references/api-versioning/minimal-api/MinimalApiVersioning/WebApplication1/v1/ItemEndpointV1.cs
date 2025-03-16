using Asp.Versioning.Builder;

namespace WebApplication1.v1
{
    public static class ItemEndpointV1
    {
        public static void MapItemEndpointsV1(this WebApplication app, ApiVersionSet apiVersionSet)
        {
            // GET all items
            app.MapGet("api/v{version:apiVersion}/items", () => "This is get items version 1 ")
               .WithApiVersionSet(apiVersionSet)
               .MapToApiVersion(1);
        }
    }
}
