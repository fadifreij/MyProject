using MinimalApiExmple.FakedDataGenerator;

namespace MinimalApiExmple.Endpoints
{
    public static class ItemEndpoints
    {
        public static void MapItemEndpoints(this WebApplication app)
        {
            var items = ItemDataGenerator.GenerateItems(5);

            // GET all items
            app.MapGet("/items", () => items);

            // GET item by id
            app.MapGet("/items/{id}", (int id) => {
                var item = items.FirstOrDefault(i => i.ItemId == id);
                return item is not null ? Results.Ok(item) : Results.NotFound();
            });

            // POST a new item
            app.MapPost("/items", (Item newItem) => {
                items.Add(newItem);
                return Results.Created($"/items/{newItem.ItemId}", newItem);
            });


            // PUT to update an item
            app.MapPut("/items/{id}", (int id, Item updatedItem) => {
                var item = items.FirstOrDefault(i => i.ItemId == id);
                if (item is not null) {
                    item.ItemName = updatedItem.ItemName;
                    item.ItemDescription = updatedItem.ItemDescription;
                    return Results.Ok(item);
                }
                return Results.NotFound(); });

            // DELETE an item
            app.MapDelete("/items/{id}", (int id) => { 
                var item = items.FirstOrDefault(i => i.ItemId == id); 
                if (item is not null) { 
                    items.Remove(item); 
                    return Results.Ok(item); }
                return Results.NotFound(); });
        }

    }


}

  

