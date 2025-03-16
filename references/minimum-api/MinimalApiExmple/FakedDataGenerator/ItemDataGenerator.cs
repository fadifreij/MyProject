using Bogus;

namespace MinimalApiExmple.FakedDataGenerator
{
    public class ItemDataGenerator
    {
        public static List<Item> GenerateItems(int number)
        {
            var itemFaker = new Faker<Item>()
               .CustomInstantiator(
                f => new Item(f.IndexFaker + 1,
                             f.Commerce.ProductName(),
                             f.Commerce.ProductDescription()
                             ));

            return itemFaker.Generate(number);

        }
    }

    public record Item(int ItemId, string ItemName, string ItemDescription)
    {
        public int ItemId { get; set; } = ItemId;
        public string ItemName { get; set; } = ItemName;
        public string ItemDescription { get; set; } = ItemDescription;
    };
}
