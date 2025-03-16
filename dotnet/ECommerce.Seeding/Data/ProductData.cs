using E_Commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Data
{
    internal static class ProductData
    {
        static public Product[] products =
          {
                #region "Food -> Meat"
                
                new Product
                {
                    Id = 1,
                    ProductName = "21 Day Beef Ranch Steaks With Garlic Butter",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 3,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 2,
                    ProductName = "Beef Minced",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 3.1f,
                    Qty = 5,
                    RateReview = 4
                },
                new Product
                {
                    Id = 3,
                    ProductName = "British Beef Quarter Pounders",
                    DepartmentId = 1,
                    Discount = 0.1f,
                    IsAvailable = true,
                    Price = 3.1f,
                    Qty = 4,
                    RateReview = 5
                },
                new Product
                {
                    Id = 4,
                    ProductName = "British Beef Roasting Joint",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.8f,
                    Qty = 8,
                    RateReview = 5
                },
                new Product
                {
                    Id = 5,
                    ProductName = "British Diced Beef",
                    DepartmentId = 1,
                    Discount = 0.05f,
                    IsAvailable = true,
                    Price = 8,
                    Qty = 12,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 6,
                    ProductName = "Edwards 2 Steak Burgers",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 5,
                    Qty = 7,
                    RateReview = 4
                },
                new Product
                {
                    Id = 7,
                    ProductName = "Fat Matured Scotch Minced Beef",
                    DepartmentId = 1,
                    Discount = 0.9f,
                    IsAvailable = true,
                    Price = 10,
                    Qty = 15,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 8,
                    ProductName = "Fillet Steak",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 13,
                    Qty = 2,
                    RateReview = 5
                },
                new Product
                {
                    Id = 9,
                    ProductName = "Malcolm Allan Steak Lorne",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 20,
                    Qty = 18,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 10,
                    ProductName = "Scottish Fillet Steak",
                    DepartmentId = 1,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price = 18,
                    Qty = 50,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 11,
                    ProductName = "Scottish Lean Diced Beef",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 15,
                    Qty = 14,
                    RateReview = 4
                },
                new Product
                {
                    Id = 12,
                    ProductName = "Simon Howie Premium Steak Lorne",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 25,
                    Qty = 15,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 13,
                    ProductName = "Sirloin Steak",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 17.5f,
                    Qty = 22,
                    RateReview = 5
                },
                new Product
                {
                    Id = 14,
                    ProductName = "The Best 2 Steak Burgers",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 22.3f,
                    Qty = 45,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 15,
                    ProductName = "The Best 4 Beef Quarter Pounder Burgers",
                    DepartmentId = 1,
                    Discount = 0.1f,
                    IsAvailable = true,
                    Price = 45,
                    Qty = 50,
                    RateReview = 5
                },
                new Product
                {
                    Id = 16,
                    ProductName = "The Best Rib Eye Steak",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 38,
                    Qty = 32,
                    RateReview = 4
                },
                new Product
                {
                    Id = 17,
                    ProductName = "Traditional British Beef Topside Joint",
                    DepartmentId = 1,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 32,
                    Qty = 45,
                    RateReview = 5
                },

                // Food -> Fish & Seafood
                new Product
                {
                    Id = 18,
                    ProductName = "2 Salmon En Croute",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 5,
                    Qty = 42,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 19,
                    ProductName = "Breaded Haddock Fillets",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 9,
                    Qty = 15,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 20,
                    ProductName = "Cooked Seafood Selection",
                    DepartmentId = 2,
                    Discount = 0.1f,
                    IsAvailable = true,
                    Price = 12,
                    Qty = 14,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 21,
                    ProductName = "Cooked Shell On Cold Water Prawns",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 8,
                    Qty = 15,
                    RateReview = 5
                },
                new Product
                {
                    Id = 22,
                    ProductName = "Frozen Ready To Cook Breaded Calamari",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 7.25f,
                    Qty = 18,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 23,
                    ProductName = "Katsu Chicken Mini Fillets",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 18,
                    Qty = 22,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 24,
                    ProductName = "Raw Whole King Prawns",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 11,
                    Qty = 17,
                    RateReview = 4
                },
                new Product
                {
                    Id = 25,
                    ProductName = "Sea Bream Fillets",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 9.1f,
                    Qty = 12,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 26,
                    ProductName = "The Best Breaded Chunky Haddock Fillets",
                    DepartmentId = 2,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 7.95f,
                    Qty = 50,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 27,
                    ProductName = "The Best Cod Loin",
                    DepartmentId = 2,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price = 10,
                    Qty = 50,
                    RateReview = 5
                },
                #endregion
                #region "Food -> Fruit & Vegetables"
                new Product
                {
                    Id = 28,
                    ProductName = "Snack Size Bananas",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.75f,
                    Qty = 10,
                    RateReview = 2
                },
                new Product
                {
                    Id = 29,
                    ProductName = "Closed Cup Mushrooms",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1,
                    Qty = 12,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 30,
                    ProductName = "Rocket & Baby Leaf Salad",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.89f,
                    Qty = 6,
                    RateReview = 4
                },
                new Product
                {
                    Id = 31,
                    ProductName = "Tenderstem Broccoli",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.75f,
                    Qty = 8,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 32,
                    ProductName = "Loose Conference Pears",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.5f,
                    Qty = 9,
                    RateReview = 2.5f
                },
                new Product
                {
                    Id = 33,
                    ProductName = "Crispy Salad",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.89f,
                    Qty = 13,
                    RateReview = 5
                },
                new Product
                {
                    Id = 34,
                    ProductName = "Piccolina Vine Tomatoes",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.15f,
                    Qty = 7,
                    RateReview = 5
                },
                new Product
                {
                    Id = 35,
                    ProductName = "The Best White Potatoes",
                    DepartmentId = 3,
                    Discount = 0.3f,
                    IsAvailable = true,
                    Price = 2.3f,
                    Qty = 11,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 36,
                    ProductName = "Baby Leaf Salad",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.89f,
                    Qty = 4,
                    RateReview = 3f
                },
                new Product
                {
                    Id = 37,
                    ProductName = "Extra Fine Green Beans",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.5f,
                    Qty = 14,
                    RateReview = 1
                },
                new Product
                {
                    Id = 38,
                    ProductName = "Cucumber Portion",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.6f,
                    Qty = 8,
                    RateReview = 3
                },
                new Product
                {
                    Id = 39,
                    ProductName = "Walnuts",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 12,
                    RateReview = 3
                },
                new Product
                {
                    Id = 40,
                    ProductName = "Large Piccolina Vine Tomatoes",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 3,
                    Qty = 20,
                    RateReview = 5
                },
                new Product
                {
                    Id = 41,
                    ProductName = "Sweet & Crunchy Salad",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.89f,
                    Qty = 20,
                    RateReview = 2
                },
                new Product
                {
                    Id = 42,
                    ProductName = "Mango",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.4f,
                    Qty = 5,
                    RateReview = 1.5f
                },
                new Product
                {
                    Id = 43,
                    ProductName = "Pineapple",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.4f,
                    Qty = 15,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 44,
                    ProductName = "Sweetclem Easy Peelers",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.35f,
                    Qty = 11,
                    RateReview = 3
                },
                new Product
                {
                    Id = 45,
                    ProductName = "Strawberries",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.3f,
                    Qty = 8,
                    RateReview = 2
                },
                new Product
                {
                    Id = 46,
                    ProductName = "Seedless Green Grapes",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 8,
                    RateReview = 3
                },
                new Product
                {
                    Id = 47,
                    ProductName = "Loose Red Pepper",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.59F,
                    Qty = 8,
                    RateReview = 5
                },
                new Product
                {
                    Id = 48,
                    ProductName = "Purple Aubergine",
                    DepartmentId = 3,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.95F,
                    Qty = 12,
                    RateReview = 5
                },
                #endregion
                #region  "Food -> Backery & Cakes"
                new Product
                {
                    Id = 49,
                    ProductName = "Thick Sliced Tiger Bloomer",
                    DepartmentId = 4,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.8F,
                    Qty = 12,
                    RateReview = 4
                },
                new Product
                {
                    Id = 50,
                    ProductName = "Brioche Buns",
                    DepartmentId = 4,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.25F,
                    Qty = 15,
                    RateReview = 4
                },
                new Product
                {
                    Id = 51,
                    ProductName = "The Best White Rolls",
                    DepartmentId = 4,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.25F,
                    Qty = 15,
                    RateReview = 3
                },
                new Product
                {
                    Id = 52,
                    ProductName = "Thick Cut Multi-Seed",
                    DepartmentId = 4,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.45F,
                    Qty = 14,
                    RateReview = 4
                },
                new Product
                {
                    Id = 53,
                    ProductName = "The Best All Butter Croissants",
                    DepartmentId = 4,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.3F,
                    Qty = 14,
                    RateReview = 4
                },
                new Product
                {
                    Id = 54,
                    ProductName = "Hovis Nimble Wholemeal Bread",
                    DepartmentId = 4,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price = 1.25F,
                    Qty = 8,
                    RateReview = 4
                },
                new Product
                {
                    Id = 55,
                    ProductName = "Mr Kipling Viennese Whirls Biscuits Multipack Snack 6pk",
                    DepartmentId = 4,
                    Discount = 0.5f,
                    IsAvailable = true,
                    Price = 2.5F,
                    Qty = 18,
                    RateReview = 4
                },
                new Product
                {
                    Id = 56,
                    ProductName = "The Best White Sourdough Sliced Half Boule",
                    DepartmentId = 4,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.95F,
                    Qty = 10,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 57,
                    ProductName = "New York Bakery Co. Sesame Bagel",
                    DepartmentId = 4,
                    Discount = 0.3f,
                    IsAvailable = true,
                    Price = 1.9F,
                    Qty = 10,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 58,
                    ProductName = "New York Bakery Co. Cinnamon & Raisin Bagels",
                    DepartmentId = 4,
                    Discount = 0.3f,
                    IsAvailable = true,
                    Price = 1.9F,
                    Qty = 10,
                    RateReview = 3.5f
                },
                new Product
                {
                    Id = 59,
                    ProductName = "Cadbury Milk Chocolate Mini Rolls Cakes Multipack Snack Family Size 10pk",
                    DepartmentId = 4,
                    Discount = 0.42f,
                    IsAvailable = true,
                    Price = 3.95F,
                    Qty = 10,
                    RateReview = 4.5f
                },
                new Product
                {
                    Id = 60,
                    ProductName = "Mr Kipling Bramley Apple Pies Multipack Snack 6pk",
                    DepartmentId = 4,
                    Discount = 0.25f,
                    IsAvailable = true,
                    Price = 3,
                    Qty = 12,
                    RateReview = 5
                },
                new Product
                {
                    Id = 61,
                    ProductName = "Mr Kipling Christmas Frosty Fancies Cakes Multipack Snack 8pk",
                    DepartmentId = 4,
                    Discount = 0.25f,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 18,
                    RateReview = 4.5f
                },
                #endregion
                #region "Food -> Frozen"
                new Product
                {
                    Id = 62,
                    ProductName = "Goodfellas Thin Margherita Pizza",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.5f,
                    Qty = 22,
                    RateReview = 4.3f
                },
               new Product
                {
                    Id = 63,
                    ProductName = "Aunt Bessie's 10 Glorious Golden Yorkshire Puddings",
                    DepartmentId = 5,
                    Discount = 0.18f,
                    IsAvailable = true,
                    Price = 2.5f,
                    Qty = 8,
                    RateReview = 4.2f
                },
               new Product
                {
                    Id = 64,
                    ProductName = "McCain 4 Baked Jacket Potatoes",
                    DepartmentId = 5,
                    Discount = 0.05f,
                    IsAvailable = true,
                    Price = 3.09f,
                    Qty = 12,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 65,
                    ProductName = "12 Mozzarella Sticks",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.75f,
                    Qty = 12,
                    RateReview = 3
                },
               new Product
                {
                    Id = 66,
                    ProductName = "McCain Crispy French Fries",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 3.5f,
                    Qty = 16,
                    RateReview = 5
                },
               new Product
                {
                    Id = 67,
                    ProductName = "Birds Eye 2 Chicken Quarter Pounders",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 18,
                    RateReview = 3.5f
                },
               new Product
                {
                    Id = 68,
                    ProductName = "Birds Eye 38 Crispy Chicken Dippers",
                    DepartmentId = 5,
                    Discount = 0.4f,
                    IsAvailable = true,
                    Price = 5.5f,
                    Qty = 15,
                    RateReview = 3.5f
                },
               new Product
                {
                    Id = 69,
                    ProductName = "McCain Home Chips Straight Cut",
                    DepartmentId = 5,
                    Discount = 0.18f,
                    IsAvailable = true,
                    Price = 4.29f,
                    Qty = 13,
                    RateReview = 5
                },
               new Product
                {
                    Id = 70,
                    ProductName = "12 Tempura Prawns",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.5f,
                    Qty = 13,
                    RateReview = 4
                },
               new Product
                {
                    Id = 71,
                    ProductName = "The Best Petit Pois",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.45f,
                    Qty = 16,
                    RateReview = 4
                },
               new Product
                {
                    Id = 72,
                    ProductName = "12 Duck Spring Rolls",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.5f,
                    Qty = 13,
                    RateReview = 4
                },
               new Product
                {
                    Id = 73,
                    ProductName = "Birds Eye 10 Original Potato Waffles",
                    DepartmentId = 5,
                    Discount = 0.05f,
                    IsAvailable = true,
                    Price = 2.35f,
                    Qty = 13,
                    RateReview = 4
                },
               new Product
                {
                    Id = 74,
                    ProductName = "Aunt Bessie's Roast Potatoes",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 15,
                    RateReview = 5
                },
               new Product
                {
                    Id = 75,
                    ProductName = "Chicago Town Deep Dish Pepperoni Pizzas",
                    DepartmentId = 5,
                    Discount = 0.05f,
                    IsAvailable = true,
                    Price = 2.25f,
                    Qty = 13,
                    RateReview = 4
                },
               new Product
                {
                    Id = 76,
                    ProductName = "Dark Sweet Cherries",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.5f,
                    Qty = 18,
                    RateReview = 4
                },
               new Product
                {
                    Id = 77,
                    ProductName = "Cottage Pie",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.85f,
                    Qty = 16,
                    RateReview = 3.5f
                },
               new Product
                {
                    Id = 78,
                    ProductName = "Bannisters Farm 4 Cheese & Bacon Potato Skins",
                    DepartmentId = 5,
                    Discount = 0.05f,
                    IsAvailable = true,
                    Price = 1.8f,
                    Qty = 16,
                    RateReview = 4
                },
               new Product
                {
                    Id = 79,
                    ProductName = "Morrisons Spaghetti Bolognese",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.85f,
                    Qty = 19,
                    RateReview = 5
                },
               new Product
                {
                    Id = 80,
                    ProductName = "Aunt Bessie's Mashed Potato",
                    DepartmentId = 5,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2.89f,
                    Qty = 13,
                    RateReview = 4.5f
                },
                #endregion
                #region "Food -> Drinks"
                new Product
                {
                    Id = 81,
                    ProductName = "Robinsons Double Strength Apple & Blackcurrant No Added Sugar Squash",
                    DepartmentId = 6,
                    Discount = 0.09f,
                    IsAvailable = true,
                    Price = 3.25f,
                    Qty = 13,
                    RateReview = 4
                },
               new Product
                {
                    Id = 82,
                    ProductName = "Red Bull",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 9,
                    Qty = 50,
                    RateReview = 5
                },
               new Product
                {
                    Id = 83,
                    ProductName = "Pepsi Max No Sugar Cola Bottle",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 42,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 84,
                    ProductName = "Yorkshire Vale Water",
                    DepartmentId = 6,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 43,
                    RateReview = 3
                },
               new Product
                {
                    Id = 85,
                    ProductName = "Dr Pepper",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2 ,
                    Qty = 33,
                    RateReview = 3.5f
                },
               new Product
                {
                    Id = 86,
                    ProductName = "Pepsi Max No Sugar Cola Cans",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 3.99f,
                    Qty = 86,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 87,
                    ProductName = "Ocean Spray Cranberry Classic Juice Drink",
                    DepartmentId = 6,
                    Discount = 0.09f,
                    IsAvailable = true,
                    Price = 1.85f,
                    Qty = 54,
                    RateReview = 4
                },
               new Product
                {
                    Id = 88,
                    ProductName = "Coca-Cola Original Taste Cans",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 6.5f,
                    Qty = 60,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 89,
                    ProductName = "Fanta Orange Zero",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 77,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 90,
                    ProductName = "Appletiser 100% Apple Juice Lightly Sparkling",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 0.6f,
                    Qty = 60,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 91,
                    ProductName = "7UP Zero Sugar Lemon & Lime Cans",
                    DepartmentId = 6,
                    Discount = 0.01f,
                    IsAvailable = true,
                    Price = 9,
                    Qty = 13,
                    RateReview = 5
                },
               new Product
                {
                    Id = 92,
                    ProductName = "Fanta Lemon",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 55,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 93,
                    ProductName = "Sprite Zero Sugar",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 65,
                    RateReview = 4
                },
               new Product
                {
                    Id = 94,
                    ProductName = "Coca-Cola Original Taste",
                    DepartmentId = 6,
                    Discount = 0.058f,
                    IsAvailable = true,
                    Price = 4.7f,
                    Qty = 83,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 95,
                    ProductName = "Diet Coke Cans",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 5.85f,
                    Qty = 65,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 96,
                    ProductName = "Orange Juice from Concentrate",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.45f,
                    Qty = 56,
                    RateReview = 4.5f
                },
               new Product
                {
                    Id = 97,
                    ProductName = "Orange Juice From Concentrate Smooth",
                    DepartmentId = 6,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 1.45f,
                    Qty = 66,
                    RateReview = 4.5f
                },
            #endregion


                # region "Electronics -> Televisions"
               new Product
                {
                    Id = 98,
                    ProductName = "Samsung 55 Inch UE55DU7100KXXU Smart 4K UHD HDR LED TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 349,
                    Qty = 166,
                    RateReview =5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Samsung 55 Inch UE55DU7100KXXU Smart 4K UHD HDR LED TV")

                },
               new Product
                {
                    Id = 99,
                    ProductName = "Bush 43 Inch 43UT24SB 4K UHD HDR LED TiVo Freely TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 420,
                    Qty = 112,
                    RateReview = 4f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Bush 43 Inch 43UT24SB 4K UHD HDR LED TiVo Freely TV")

                },
               new Product
                {
                    Id = 100,
                    ProductName = "Toshiba 50 Inch 50UV2F53DB Smart 4K UHD HDR LCD Freely TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 312,
                    Qty = 110,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Toshiba 50 Inch 50UV2F53DB Smart 4K UHD HDR LCD Freely TV")

                },
               new Product
                {
                    Id = 101,
                    ProductName = "TCL 55 Inch 55PF650K Smart 4K UHD HDR LED Freely TV",
                    DepartmentId = 10,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price = 320,
                    Qty = 50,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","TCL 55 Inch 55PF650K Smart 4K UHD HDR LED Freely TV")

                },
               new Product
                {
                    Id = 102,
                    ProductName = "Hisense 32 Inch 32E4NTUK Smart HD Ready LED Freeview TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 118,
                    Qty = 78,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Hisense 32 Inch 32E4NTUK Smart HD Ready LED Freeview TV")

                },
               new Product
                {
                    Id = 103,
                    ProductName = "TCL 32 Inch 32SF540K Smart FHD HDR LED Fire TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 138,
                    Qty = 78,
                    RateReview = 4,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","TCL 32 Inch 32SF540K Smart FHD HDR LED Fire TV")

                },
               new Product
                {
                    Id = 104,
                    ProductName = "Hisense 40 Inch 40E4NTUK Smart Full HD LED Freeview TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 179,
                    Qty = 118,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Hisense 40 Inch 40E4NTUK Smart Full HD LED Freeview TV")

                },
               new Product
                {
                    Id = 105,
                    ProductName = "Hisense 55 Inch 55E78NQTUK Smart 4K HDR UHD QLED Freely TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 379,
                    Qty = 178,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Hisense 55 Inch 55E78NQTUK Smart 4K HDR UHD QLED Freely TV")

                },
               new Product
                {
                    Id = 106,
                    ProductName = "LG 43 Inch 43UR78006LK Smart 4K UHD HDR LED Freeview TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 279,
                    Qty = 151,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","LG 43 Inch 43UR78006LK Smart 4K UHD HDR LED Freeview TV")

                },
               new Product
                {
                    Id = 107,
                    ProductName = "Toshiba 43 Inch 43LV2E63DB Smart FHD HDR10 Freeview TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 179,
                    Qty = 151,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Toshiba 43 Inch 43LV2E63DB Smart FHD HDR10 Freeview TV")

                },
               new Product
                {
                    Id = 108,
                    ProductName = "Samsung 40 Inch UE40T5300AEXXU Smart Full HD HDR LED TV",
                    DepartmentId = 10,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 179,
                    Qty = 151,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Televisions","Samsung 40 Inch UE40T5300AEXXU Smart Full HD HDR LED TV")

                },
            #endregion
                #region "Electronics -> Tablets & iPads"
               new Product
                {
                    Id = 109,
                    ProductName = "Lenovo Tab M9 9 Inch 32GB Tablet - Grey",
                    DepartmentId = 7,
                    Discount = 0.4f,
                    IsAvailable = true,
                    Price = 139.99f,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Lenovo Tab M9 9 Inch 32GB Tablet - Grey")

                },
               new Product
                {
                    Id = 110,
                    ProductName = "Amazon Fire HD 8 8 Inch 32GB Wi-Fi Tablet - Hibiscus",
                    DepartmentId = 7,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 99.99f,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Amazon Fire HD 8 8 Inch 32GB Wi-Fi Tablet - Hibiscus")

                },
               new Product
                {
                    Id = 111,
                    ProductName = "Samsung Galaxy Tab A9+ 11in 64GB Wi-Fi Tablet - Navy",
                    DepartmentId = 7,
                    Discount = 0.35f,
                    IsAvailable = true,
                    Price = 239f,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Samsung Galaxy Tab A9+ 11in 64GB Wi-Fi Tablet - Navy")

                },
               new Product
                {
                    Id = 112,
                    ProductName = "HONOR Pad X8a 11 Inch 64GB Wi-Fi Tablet - Grey",
                    DepartmentId = 7,
                    Discount = 0.35f,
                    IsAvailable = true,
                    Price = 239f,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","HONOR Pad X8a 11 Inch 64GB Wi-Fi Tablet - Grey")

                },
               new Product
                {
                    Id = 113,
                    ProductName = "HONOR Pad X8a 11 Inch 128GB Wi-Fi Tablet - Grey",
                    DepartmentId = 7,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 119.99f,
                    Qty = 154,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","HONOR Pad X8a 11 Inch 128GB Wi-Fi Tablet - Grey")

                },
               new Product
                {
                    Id = 114,
                    ProductName = "Samsung Galaxy Tab A9+ 11in 128GB Wi-Fi Tablet - Grey",
                    DepartmentId = 7,
                    Discount = 0.17f,
                    IsAvailable = true,
                    Price = 289f,
                    Qty = 154,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Samsung Galaxy Tab A9+ 11in 128GB Wi-Fi Tablet - Grey")

                },
               new Product
                {
                    Id = 115,
                    ProductName = "Lenovo M10 3rd Gen 10.1 Inch 64GB Wi-Fi Tablet – Grey",
                    DepartmentId = 7,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 99.99f,
                    Qty = 165,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Lenovo M10 3rd Gen 10.1 Inch 64GB Wi-Fi Tablet – Grey")

                },
               new Product
                {
                    Id = 116,
                    ProductName = "Samsung Galaxy Tab S9 11in 128GB Wi-Fi AI Tablet - Graphite",
                    DepartmentId = 7,
                    Discount = 0.15f,
                    IsAvailable = true,
                    Price = 799.99f,
                    Qty = 165,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Samsung Galaxy Tab S9 11in 128GB Wi-Fi AI Tablet - Graphite")

                },
               new Product
                {
                    Id = 117,
                    ProductName = "Lenovo Tab M11 11 Inch 128GB Tablet Bundle - Grey",
                    DepartmentId = 7,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 199.99f,
                    Qty = 165,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Lenovo Tab M11 11 Inch 128GB Tablet Bundle - Grey")

                },
               new Product
                {
                    Id = 118,
                    ProductName = "Amazon Fire HD 10 2023 10.1 Inch 32GB Wi-Fi Tablet - Black",
                    DepartmentId = 7,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 194.99f,
                    Qty = 175,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Tablets & iPads","Amazon Fire HD 10 2023 10.1 Inch 32GB Wi-Fi Tablet - Black")

                },
                #endregion
                #region "Electronics -> Laptops & PCs"
                new Product
                {
                    Id = 119,
                    ProductName = "Lenovo 82UY0012UK 11.6in Celeron 4GB 64GB Chromebook - Blue",
                    DepartmentId = 8,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 179,
                    Qty = 122,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","Lenovo 82UY0012UK 11.6in Celeron 4GB 64GB Chromebook - Blue")

                },
                new Product
                {
                    Id = 120,
                    ProductName = "Samsung Galaxy Book4 2024 i3 8GB 256GB Laptop",
                    DepartmentId = 8,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 499,
                    Qty = 122,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","Samsung Galaxy Book4 2024 i3 8GB 256GB Laptop")

                },
                new Product
                {
                    Id = 121,
                    ProductName = "ASUS Vivobook Go 14 14in i3 8GB 128GB Laptop - Silver",
                    DepartmentId = 8,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 249.99f,
                    Qty = 172,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","ASUS Vivobook Go 14 14in i3 8GB 128GB Laptop - Silver")

                },
                new Product
                {
                    Id = 122,
                    ProductName = "HP 14a-nf0002na 14in Intel N100 4GB 128GB Chromebook",
                    DepartmentId = 8,
                    Discount = 0.1f,
                    IsAvailable = true,
                    Price = 189,
                    Qty = 169,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","HP 14a-nf0002na 14in Intel N100 4GB 128GB Chromebook")

                },
                new Product
                {
                    Id = 123,
                    ProductName = "HP 14s-dq0011na 14in Pentium 4GB 128GB Laptop Bundle",
                    DepartmentId = 8,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 229,
                    Qty = 169,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","HP 14s-dq0011na 14in Pentium 4GB 128GB Laptop Bundle")

                },
                new Product
                {
                    Id = 124,
                    ProductName = "HP Stream 14s-dq0034na 14in Celeron 4GB 128GB Laptop - Black",
                    DepartmentId = 8,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 179,
                    Qty = 222,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","HP Stream 14s-dq0034na 14in Celeron 4GB 128GB Laptop - Black")

                },
                new Product
                {
                    Id = 125,
                    ProductName = "ASUS CX1400 14in Celeron 4GB 64GB Chromebook",
                    DepartmentId = 8,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 149,
                    Qty = 222,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","ASUS CX1400 14in Celeron 4GB 64GB Chromebook")

                },
                new Product
                {
                    Id = 126,
                    ProductName = "HP 15.6in Ryzen 3 4GB 128GB Laptop + Microsoft 365 Bundle",
                    DepartmentId = 8,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 229,
                    Qty = 222,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Laptops & PCs","HP 15.6in Ryzen 3 4GB 128GB Laptop + Microsoft 365 Bundle")

                },
            #endregion
                #region "Electronics -> Headphones & Audio"
                new Product
                {
                    Id = 127,
                    ProductName = "Apple Earpods USB-C In-Ear Headphones - White",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 19.99f,
                    Qty = 200,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Apple Earpods USB-C In-Ear Headphones - White")

                },
                new Product
                {
                    Id = 128,
                    ProductName = "Beats Solo 4 On-Ear True Wireless Headphones - Black & Gold",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 129,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Beats Solo 4 On-Ear True Wireless Headphones - Black & Gold")

                },
                new Product
                {
                    Id = 129,
                    ProductName = "JLab JBuddies Studio Kids Bluetooth Headphones - Grey-Blue",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 21.99f,
                    Qty = 120,
                    RateReview = 3.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","JLab JBuddies Studio Kids Bluetooth Headphones - Grey-Blue")

                },
                new Product
                {
                    Id = 130,
                    ProductName = "Sennheiser HD 400S Over-Ear Wired Headphones - Black",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 59,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Sennheiser HD 400S Over-Ear Wired Headphones - Black")

                },
                new Product
                {
                    Id = 131,
                    ProductName = "Technics AZ60M2 In-Ear True Wireless Earbuds - Black",
                    DepartmentId = 9,
                    Discount = 0.25f,
                    IsAvailable = true,
                    Price = 199,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Technics AZ60M2 In-Ear True Wireless Earbuds - Black")

                },
                new Product
                {
                    Id = 132,
                    ProductName = "Sennheiser CX 80S In-Ear Wired Headphones - Black",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price =26.99f,
                    Qty = 120,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Sennheiser CX 80S In-Ear Wired Headphones - Black")

                },
                new Product
                {
                    Id = 133,
                    ProductName = "Samsung Galaxy Buds3 True Wireless In-Ear Earbuds - Silver",
                    DepartmentId = 9,
                    Discount = 0.1f,
                    IsAvailable = true,
                    Price =159,
                    Qty = 120,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Samsung Galaxy Buds3 True Wireless In-Ear Earbuds - Silver")

                },
                new Product
                {
                    Id = 134,
                    ProductName = "Beats Powerbeats Pro True Wireless Earbuds - Black",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price =269.95f,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Beats Powerbeats Pro True Wireless Earbuds - Black")

                },
                new Product
                {
                    Id = 135,
                    ProductName = "Beats Solo 4 On-Ear True Wireless Headphones - Matt Black",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price =125.99f,
                    Qty = 220,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Beats Solo 4 On-Ear True Wireless Headphones - Matt Black")

                },
                new Product
                {
                    Id = 136,
                    ProductName = "Beats Fit Pro True Wireless Noise Cancelling Earbuds - Black",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price =139.99f,
                    Qty = 220,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Beats Fit Pro True Wireless Noise Cancelling Earbuds - Black")

                },
                new Product
                {
                    Id = 137,
                    ProductName = "Samsung Galaxy Buds3 True Wireless In-Ear Earbuds - White",
                    DepartmentId = 9,
                    Discount = 0.15f,
                    IsAvailable = true,
                    Price =159.99f,
                    Qty = 220,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Beats Fit Pro True Wireless Noise Cancelling Earbuds - Black")

                },
                new Product
                {
                    Id = 138,
                    ProductName = "Belkin SoundForm Nano Kids In-Ear True Wireless Earbuds -Wht",
                    DepartmentId = 9,
                    Discount = 0,
                    IsAvailable = true,
                    Price =29.99f,
                    Qty = 220,
                    RateReview = 3.5f,
                    Description = DescriptionSeeder.DescriptionReader("Electronics","Headphones & Audio","Belkin SoundForm Nano Kids In-Ear True Wireless Earbuds -Wht")

                },
            #endregion


                #region "Toys -> Art and creativity toys"
                new Product
                {
                    Id = 139,
                    ProductName = "Crayola Silly Scents Tub",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =17,
                    Qty = 367,
                    RateReview = 3.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","Crayola Silly Scents Tub")

                },
                new Product
                {
                    Id = 140,
                    ProductName = "Crayola Light Up Tracing Pad",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =15,
                    Qty = 355,
                    RateReview = 4,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","Crayola Light Up Tracing Pad")

                },
                new Product
                {
                    Id = 141,
                    ProductName = "Crayola 70 Piece Stationery Set",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =15,
                    Qty = 355,
                    RateReview = 4,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","Crayola 70 Piece Stationery Set")

                },
                new Product
                {
                    Id = 142,
                    ProductName = "Crayola Mosaic Madness Art Set",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =8.25f,
                    Qty = 355,
                    RateReview = 4,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","Crayola Mosaic Madness Art Set")

                },
                new Product
                {
                    Id = 143,
                    ProductName = "Tomy Megasketcher",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =17,
                    Qty = 355,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","Tomy Megasketcher")

                },
                new Product
                {
                    Id = 144,
                    ProductName = "John Adams BLO Pens Sequins Set",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =12,
                    Qty = 355,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","John Adams BLO Pens Sequins Set")

                },
                new Product
                {
                    Id = 145,
                    ProductName = "John Adams GLOWpad",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =13,
                    Qty = 355,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","John Adams GLOWpad")

                },
                new Product
                {
                    Id = 146,
                    ProductName = "Chad Valley XL Rainbow Aqua Magic Mat",
                    DepartmentId = 11,
                    Discount = 0,
                    IsAvailable = true,
                    Price =15,
                    Qty = 355,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","Chad Valley XL Rainbow Aqua Magic Mat")

                },
                new Product
                {
                    Id = 147,
                    ProductName = "Crayola Imagination Art Set",
                    DepartmentId = 11,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price =20,
                    Qty = 355,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Art and creativity toys","Crayola Imagination Art Set")

                },
            #endregion
                #region "Toys -> LEGO"
                new Product
                {
                    Id = 148,
                    ProductName = "LEGO Icons Lamborghini Countach 5000 Quattrovalvole 10337",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =160,
                    Qty = 40,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Icons Lamborghini Countach 5000 Quattrovalvole 10337")

                },
                new Product
                {
                    Id = 149,
                    ProductName = "LEGO Icons Retro Radio Building Set for Adults 10334",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =90,
                    Qty = 49,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Icons Retro Radio Building Set for Adults 10334")

                },
                new Product
                {
                    Id = 150,
                    ProductName = "LEGO Botanicals Pretty Pink Flower Bouquet Decor Set 10342",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =55,
                    Qty = 74,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Botanicals Pretty Pink Flower Bouquet Decor Set 10342")

                },
                new Product
                {
                    Id = 151,
                    ProductName = "LEGO Technic Planet Earth and Moon in Orbit Space Toy 42179",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =70,
                    Qty = 74,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Technic Planet Earth and Moon in Orbit Space Toy 42179")

                },
                new Product
                {
                    Id = 152,
                    ProductName = "LEGO City Space Explorer Rover and Alien Life Toy Set 60431",
                    DepartmentId = 12,
                    Discount = 0.25f,
                    IsAvailable = true,
                    Price =25,
                    Qty = 60,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO City Space Explorer Rover and Alien Life Toy Set 60431")

                },
                new Product
                {
                    Id = 153,
                    ProductName = "LEGO City Spaceship and Asteroid Discovery Space Toys 60429",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =18,
                    Qty = 102,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO City Spaceship and Asteroid Discovery Space Toys 60429")

                },
                new Product
                {
                    Id = 154,
                    ProductName = "LEGO Creator 3in1 Wild Animals Panda Family Toy Set 31165",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =35,
                    Qty = 102,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Creator 3in1 Wild Animals Panda Family Toy Set 31165")

                },
                new Product
                {
                    Id = 155,
                    ProductName = "LEGO Star Wars Grogu with Hover Pram Building Toy 75403",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =90,
                    Qty = 102,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Star Wars Grogu with Hover Pram Building Toy 75403")

                },
                new Product
                {
                    Id = 156,
                    ProductName = "LEGO Harry Potter Hagrid & Harry's Motorcycle Ride Toy 76443",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =45,
                    Qty = 115,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Harry Potter Hagrid & Harry's Motorcycle Ride Toy 76443")

                },
                new Product
                {
                    Id = 157,
                    ProductName = "LEGO Disney Simba the Lion King Cub Building Toy 43243",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =18,
                    Qty = 112,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Disney Simba the Lion King Cub Building Toy 43243")

                },
                new Product
                {
                    Id = 158,
                    ProductName = "LEGO Creator 3 in 1 Exotic Parrot Animals Building Toy 31136",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =20,
                    Qty = 112,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO Creator 3 in 1 Exotic Parrot Animals Building Toy 31136")

                },
                new Product
                {
                    Id = 159,
                    ProductName = "LEGO City Race Car and Car Carrier Truck Building Toys 60406",
                    DepartmentId = 12,
                    Discount = 0,
                    IsAvailable = true,
                    Price =25,
                    Qty = 100,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","LEGO","LEGO City Race Car and Car Carrier Truck Building Toys 60406")

                },
            #endregion
                #region "Toys -> Construction Toys"
                new Product
                {
                    Id = 160,
                    ProductName = "Mega Bloks ABC Learning Train",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Mega Bloks ABC Learning Train")

                },
                new Product
                {
                    Id = 161,
                    ProductName = "Mega Bloks 60 Piece First Builders Big Building Bag- Classic",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 120,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Mega Bloks 60 Piece First Builders Big Building Bag- Classic")

                },
                new Product
                {
                    Id = 162,
                    ProductName = "Magna-Tiles Clear Colours 32 Piece Set Magnetic Toy",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =35,
                    Qty = 134,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Magna-Tiles Clear Colours 32 Piece Set Magnetic Toy")

                },
                new Product
                {
                    Id = 163,
                    ProductName = "Hot Wheels Maker Kitz Custom Race Kit",
                    DepartmentId = 13,
                    Discount = 0.1f,
                    IsAvailable = true,
                    Price =10,
                    Qty = 134,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Hot Wheels Maker Kitz Custom Race Kit")

                },
                new Product
                {
                    Id = 164,
                    ProductName = "Mega Bloks 60 Piece First Builders Big Building Bag - Pink",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Mega Bloks 60 Piece First Builders Big Building Bag - Pink")

                },
                new Product
                {
                    Id = 165,
                    ProductName = "Chad Valley PlaySmart Wooden Block Set - 80 Pieces",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Chad Valley PlaySmart Wooden Block Set - 80 Pieces")

                },
                new Product
                {
                    Id = 166,
                    ProductName = "Mega Bloks First Builders Build 'n' Learn Table",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =27,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Mega Bloks First Builders Build 'n' Learn Table")

                },
                new Product
                {
                    Id = 167,
                    ProductName = "Magna-Tiles Clear 100 Pieces Set Magnetic Toy",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =80,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","Magna-Tiles Clear 100 Pieces Set Magnetic Toy")

                },
                new Product
                {
                    Id = 168,
                    ProductName = "K'NEX 12 Model Rad Rides Building Set",
                    DepartmentId = 13,
                    Discount = 0,
                    IsAvailable = true,
                    Price =14,
                    Qty = 450,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","K'NEX 12 Model Rad Rides Building Set")

                },
                new Product
                {
                    Id = 169,
                    ProductName = "MEGA Pokémon Build & Show Pokémon Trio Building Set",
                    DepartmentId = 13,
                    Discount = 0.5f,
                    IsAvailable = true,
                    Price =60,
                    Qty = 450,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Construction Toys","MEGA Pokémon Build & Show Pokémon Trio Building Set")

                },
            #endregion
                #region "Toys -> Interactive Learning Toys"
                 new Product
                {
                    Id = 170,
                    ProductName = "Vtech Peppa Pig Laptop",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =25,
                    Qty = 102,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Vtech Peppa Pig Laptop")

                },
                 new Product
                {
                    Id = 171,
                    ProductName = "Peppa Pig Count with Peppa",
                    DepartmentId = 14,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price =20,
                    Qty = 102,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Peppa Pig Count with Peppa")

                },
                 new Product
                {
                    Id = 172,
                    ProductName = "Vtech My Laptop",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =13.5f,
                    Qty = 102,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Vtech My Laptop")

                },
                 new Product
                {
                    Id = 173,
                    ProductName = "Chad Valley PlaySmart Phonics Board",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =14,
                    Qty = 105,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Chad Valley PlaySmart Phonics Board")

                },
                 new Product
                {
                    Id = 174,
                    ProductName = "Vtech Nursery Rhymes Book",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 105,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Vtech Nursery Rhymes Book")

                },
                 new Product
                {
                    Id = 175,
                    ProductName = "Chad Valley PlaySmart Junior Touch Tablet - Blue",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =9,
                    Qty = 89,
                    RateReview = 4,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Chad Valley PlaySmart Junior Touch Tablet - Blue")

                },
                 new Product
                {
                    Id = 176,
                    ProductName = "Chad Valley Baby Tablet",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 89,
                    RateReview = 4,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Chad Valley Baby Tablet")

                },
                 new Product
                {
                    Id = 177,
                    ProductName = "PAW Patrol Junior Me Reader",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =20,
                    Qty = 89,
                    RateReview = 4,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","PAW Patrol Junior Me Reader")

                },
                 new Product
                {
                    Id = 178,
                    ProductName = "LEGO DUPLO Disney Mickey and Minnie Birthday Train Toy 10941",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =28,
                    Qty = 189,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","LEGO DUPLO Disney Mickey and Minnie Birthday Train Toy 10941")

                },
                 new Product
                {
                    Id = 179,
                    ProductName = "Orchard Toys Match and Spell Activity",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =7,
                    Qty = 189,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Orchard Toys Match and Spell Activity")

                },
                 new Product
                {
                    Id = 180,
                    ProductName = "Orchard Toys Match and Spell Activity",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =7,
                    Qty = 189,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Orchard Toys Match and Spell Activity")

                },
                 new Product
                {
                    Id = 181,
                    ProductName = "Little Tikes Story Dream Machine With Fairy Tale Collection",
                    DepartmentId = 14,
                    Discount = 0,
                    IsAvailable = true,
                    Price =45,
                    Qty = 189,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Interactive Learning Toys","Little Tikes Story Dream Machine With Fairy Tale Collection")

                },
            #endregion
                #region "Toys -> Wooden Toys"
                 new Product
                {
                    Id = 182,
                    ProductName = "Fisher-Price Wooden Stack & Sort Animals 10 Piece Toy",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =17,
                    Qty = 189,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Fisher-Price Wooden Stack & Sort Animals 10 Piece Toy")

                },
                 new Product
                {
                    Id = 183,
                    ProductName = "Chad Valley Wooden Birthday Cake",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =8,
                    Qty = 212,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley Wooden Birthday Cake")

                },
                 new Product
                {
                    Id = 184,
                    ProductName = "Chad Valley PlaySmart Wooden Shape Sorter",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =9,
                    Qty = 212,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley PlaySmart Wooden Shape Sorter")
                },
                 new Product
                {
                    Id = 185,
                    ProductName = "Chad Valley Wooden Pizza",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =8,
                    Qty = 212,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley Wooden Pizza")
                },
                 new Product
                {
                    Id = 186,
                    ProductName = "Chad Valley Wooden Pizza",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =8,
                    Qty = 212,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley Wooden Pizza")
                },
                 new Product
                {
                    Id = 187,
                    ProductName = "Chad Valley Wooden Fruit Set",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =8,
                    Qty = 212,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley Wooden Fruit Set")
                },
                 new Product
                {
                    Id = 188,
                    ProductName = "Chad Valley Wooden Fishing Set",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 220,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley Wooden Fishing Set")
                },
                 new Product
                {
                    Id = 189,
                    ProductName = "Chad Valley PlaySmart Wooden Block Set - 80 Pieces",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =10,
                    Qty = 220,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley PlaySmart Wooden Block Set - 80 Pieces")
                },
                 new Product
                {
                    Id = 190,
                    ProductName = "Chad Valley Wooden Tool Box",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =15,
                    Qty = 270,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley Wooden Tool Box")
                },
                 new Product
                {
                    Id = 191,
                    ProductName = "Chad Valley wooden Tool Bench",
                    DepartmentId = 15,
                    Discount = 0,
                    IsAvailable = true,
                    Price =35,
                    Qty = 270,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Wooden Toys","Chad Valley wooden Tool Bench")
                },

            #endregion
                #region "Toys -> Sensory Toys"
                 new Product
                {
                    Id = 192,
                    ProductName = "Nuby Ocean Friends Clip & Go Mini Mobile",
                    DepartmentId = 16,
                    Discount = 0.5f,
                    IsAvailable = true,
                    Price =16,
                    Qty = 271,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Nuby Ocean Friends Clip & Go Mini Mobile")
                },
                 new Product
                {
                    Id = 193,
                    ProductName = "Fisher-Price Simply Senses Newborn Baby Gym",
                    DepartmentId = 16,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price =30,
                    Qty = 271,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Fisher-Price Simply Senses Newborn Baby Gym")
                },
                 new Product
                {
                    Id = 194,
                    ProductName = "Chad Valley Pink Stars Baby Sensory Pop Up Ball Pit",
                    DepartmentId = 16,
                    Discount = 0.5f,
                    IsAvailable = true,
                    Price =12,
                    Qty = 271,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Chad Valley Pink Stars Baby Sensory Pop Up Ball Pit")
                },
                 new Product
                {
                    Id = 195,
                    ProductName = "Lamaze Salty Sam Activity Toy",
                    DepartmentId = 16,
                    Discount = 0,
                    IsAvailable = true,
                    Price =13,
                    Qty = 181,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Lamaze Salty Sam Activity Toy")
                },
                 new Product
                {
                    Id = 196,
                    ProductName = "Infantino Sensory Sound and Light Ball",
                    DepartmentId = 16,
                    Discount = 0,
                    IsAvailable = true,
                    Price =13,
                    Qty = 181,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Infantino Sensory Sound and Light Ball")
                },
                 new Product
                {
                    Id = 197,
                    ProductName = "Fisher-Price So Many Senses Gift Set - Baby Sensory Toys",
                    DepartmentId = 16,
                    Discount = 0,
                    IsAvailable = true,
                    Price =15,
                    Qty = 181,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Fisher-Price So Many Senses Gift Set - Baby Sensory Toys")
                },
                 new Product
                {
                    Id = 198,
                    ProductName = "Fisher-Price Spotting Fun Snow Leopard - Baby Sensory Toy",
                    DepartmentId = 16,
                    Discount = 0,
                    IsAvailable = true,
                    Price =11.99f,
                    Qty = 91,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Fisher-Price Spotting Fun Snow Leopard - Baby Sensory Toy")
                },
                 new Product
                {
                    Id = 199,
                    ProductName = "Baby Einstein Twist And Pop Clutch Toy",
                    DepartmentId = 16,
                    Discount = 0,
                    IsAvailable = true,
                    Price =12,
                    Qty = 191,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Baby Einstein Twist And Pop Clutch Toy")
                },
                 new Product
                {
                    Id = 200,
                    ProductName = "Fisher-Price Rattle 'n Rock Maracas Activity Toy",
                    DepartmentId = 16,
                    Discount = 0,
                    IsAvailable = true,
                    Price =15,
                    Qty = 191,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Fisher-Price Rattle 'n Rock Maracas Activity Toy")
                },
                 new Product
                {
                    Id = 201,
                    ProductName = "Nuby Ocean Friends Gift Set",
                    DepartmentId = 16,
                    Discount = 0.01f,
                    IsAvailable = true,
                    Price =17,
                    Qty = 191,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Toys","Sensory Toys","Nuby Ocean Friends Gift Set")
                },
            #endregion


                #region "Home and furniture -> Wardrobes"
                  new Product
                {
                    Id = 202,
                    ProductName = "Habitat Cornelia 2 Door 1 Drawer Wardrobe - Oak",
                    DepartmentId = 17,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price =595,
                    Qty = 191,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Habitat Cornelia 2 Door 1 Drawer Wardrobe - Oak")
                },
                  new Product
                {
                    Id = 203,
                    ProductName = "Habitat Atlas 3 Door Wardrobe - Oak",
                    DepartmentId = 17,
                    Discount = 0.3f,
                    IsAvailable = true,
                    Price =315,
                    Qty = 191,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Habitat Atlas 3 Door Wardrobe - Oak")
                },
                  new Product
                {
                    Id = 204,
                    ProductName = "Habitat Hamburg Linear 2 Door Wardrobe - Dark Grey",
                    DepartmentId = 17,
                    Discount = 0.3f,
                    IsAvailable = true,
                    Price =375,
                    Qty = 191,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Habitat Hamburg Linear 2 Door Wardrobe - Dark Grey")
                },
                  new Product
                {
                    Id = 205,
                    ProductName = "Argos Home Nova 3 Door Sliding Wardrobe - Anthracite",
                    DepartmentId = 17,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price =225,
                    Qty = 90,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Argos Home Nova 3 Door Sliding Wardrobe - Anthracite")
                },
                  new Product
                {
                    Id = 206,
                    ProductName = "Argos Home Nova 2 Door Sliding Wardrobe - White",
                    DepartmentId = 17,
                    Discount = 0,
                    IsAvailable = true,
                    Price =160,
                    Qty = 90,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Argos Home Nova 2 Door Sliding Wardrobe - White")
                },
                  new Product
                {
                    Id = 207,
                    ProductName = "Argos Home Seville 2 Dr Open Shelf Wardrobe -Grey Oak Effect",
                    DepartmentId = 17,
                    Discount = 0,
                    IsAvailable = true,
                    Price =130,
                    Qty = 90,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Argos Home Seville 2 Dr Open Shelf Wardrobe -Grey Oak Effect")
                },
                  new Product
                {
                    Id = 208,
                    ProductName = "Argos Home Seville 2 Door Wardrobe - Anthracite",
                    DepartmentId = 17,
                    Discount = 0,
                    IsAvailable = true,
                    Price =100,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Argos Home Seville 2 Door Wardrobe - Anthracite")
                },
                  new Product
                {
                    Id = 209,
                    ProductName = "Habitat Minato 2 Door 2 Drawer Wardrobe - White",
                    DepartmentId = 17,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price =265,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Habitat Minato 2 Door 2 Drawer Wardrobe - White")
                },
                  new Product
                {
                    Id = 210,
                    ProductName = "Argos Home Seville 1 Door Wardrobe - White",
                    DepartmentId = 17,
                    Discount = 0,
                    IsAvailable = true,
                    Price =85,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Argos Home Seville 1 Door Wardrobe - White")
                },
                  new Product
                {
                    Id = 211,
                    ProductName = "Argos Home Nova 3 Door Sliding Wardrobe - White",
                    DepartmentId = 17,
                    Discount = 0.2f,
                    IsAvailable = true,
                    Price =225,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Argos Home Nova 3 Door Sliding Wardrobe - White")
                },
                  new Product
                {
                    Id = 212,
                    ProductName = "Argos Home Brisbane 4 Door 3 Drawers Wardrobe - Grey",
                    DepartmentId = 17,
                    Discount = 0.3f,
                    IsAvailable = true,
                    Price =425,
                    Qty = 170,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Wardrobes","Argos Home Brisbane 4 Door 3 Drawers Wardrobe - Grey")
                },
            #endregion
                #region "Home and furniture -> Sofas"
                  new Product
                {
                    Id = 213,
                    ProductName = "Habitat Jacob Fabric 2 Seater Sofa - Stone",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =650,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Habitat Jacob Fabric 2 Seater Sofa - Stone")
                },
                  new Product
                {
                    Id = 214,
                    ProductName = "Habitat Koba Rattan 2 Seater Sofa - Natural",
                    DepartmentId = 18,
                    Discount = 0.3f,
                    IsAvailable = true,
                    Price =300,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Habitat Koba Rattan 2 Seater Sofa - Natural")
                },
                  new Product
                {
                    Id = 215,
                    ProductName = "Habitat Newell Fabric 2 Seater Sofa - Light Grey",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =370.5f,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Habitat Newell Fabric 2 Seater Sofa - Light Grey")
                },
                  new Product
                {
                    Id = 216,
                    ProductName = "Habitat Chesterfield Velvet 2 Seater Sofa - Charcoal",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =610,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Habitat Chesterfield Velvet 2 Seater Sofa - Charcoal")
                },
                  new Product
                {
                    Id = 217,
                    ProductName = "Habitat Hendricks Fabric 3 Seater Sofa - Charcoal- Black Leg",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =1200,
                    Qty = 50,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Habitat Hendricks Fabric 3 Seater Sofa - Charcoal- Black Leg")
                },
                  new Product
                {
                    Id = 218,
                    ProductName = "Habitat Ayr Fabric 4 Seater Sofa - Blue",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =1400,
                    Qty = 50,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Habitat Ayr Fabric 4 Seater Sofa - Blue")
                },
                  new Product
                {
                    Id = 219,
                    ProductName = "Argos Home Evie Fabric 2 Seater Sofa in a Box - Charcoal",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =270,
                    Qty = 50,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Argos Home Evie Fabric 2 Seater Sofa in a Box - Charcoal")
                },
                  new Product
                {
                    Id = 220,
                    ProductName = "Argos Home Evie Fabric 2 Seater Sofa in a Box - Charcoal",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =270,
                    Qty = 50,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Argos Home Evie Fabric 2 Seater Sofa in a Box - Charcoal")
                },
                  new Product
                {
                    Id = 221,
                    ProductName = "Argos Home Moda Faux Leather 3 Seater Sofa - Black",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =300,
                    Qty = 50,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Argos Home Moda Faux Leather 3 Seater Sofa - Black")
                },
                  new Product
                {
                    Id = 222,
                    ProductName = "Argos Home Toby Faux Leather 3 Seater Recliner Sofa - Grey",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =600,
                    Qty = 60,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Argos Home Toby Faux Leather 3 Seater Recliner Sofa - Grey")
                },
                  new Product
                {
                    Id = 223,
                    ProductName = "Argos Home Salisbury Leather 2 Seater Sofa - Tan",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =700,
                    Qty = 60,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Argos Home Salisbury Leather 2 Seater Sofa - Tan")
                },
                  new Product
                {
                    Id = 224,
                    ProductName = "Argos Home Taylor Fabric 2 Seater Sofa - Mink",
                    DepartmentId = 18,
                    Discount = 0,
                    IsAvailable = true,
                    Price =385,
                    Qty = 60,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Sofas","Argos Home Taylor Fabric 2 Seater Sofa - Mink")
                },
            #endregion
                #region "Home and furniture -> Beds"
                  new Product
                {
                    Id = 225,
                    ProductName = "Argos Home Kaycie Small Double Wooden Bed Frame - Pine",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =110,
                    Qty = 60,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Argos Home Kaycie Small Double Wooden Bed Frame - Pine")
                },
                  new Product
                {
                    Id = 226,
                    ProductName = "Habitat Onda Linen Double Headboard - Natural",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =135,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Habitat Onda Linen Double Headboard - Natural")
                },
                  new Product
                {
                    Id = 227,
                    ProductName = "Silentnight Memory Foam Rolled Single Mattress",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =189,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Silentnight Memory Foam Rolled Single Mattress")
                },
                  new Product
                {
                    Id = 228,
                    ProductName = "Silentnight Middleton 800 Pocket Comfort Mattress - Double",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =299,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Silentnight Middleton 800 Pocket Comfort Mattress - Double")
                },
                  new Product
                {
                    Id = 229,
                    ProductName = "Argos Home Freja Single Metal Bed Frame - Silver",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =90,
                    Qty = 150,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Argos Home Freja Single Metal Bed Frame - Silver")
                },
                  new Product
                {
                    Id = 230,
                    ProductName = "Jay-Be Compact Folding Bed with Mattress - Single",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =115,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Jay-Be Compact Folding Bed with Mattress - Single")
                },
                  new Product
                {
                    Id = 231,
                    ProductName = "GFW Chiswick Single Side Lift Ottoman Bed - Natural",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =325,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","GFW Chiswick Single Side Lift Ottoman Bed - Natural")
                },
                  new Product
                {
                    Id = 232,
                    ProductName = "Argos Home Avalon Single Metal Bed Frame - Black",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =130,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Argos Home Avalon Single Metal Bed Frame - Black")
                },
                  new Product
                {
                    Id = 233,
                    ProductName = "Argos Home Arthur Platform Single Bed Frame - Natural",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =130,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Argos Home Arthur Platform Single Bed Frame - Natural")
                },
                  new Product
                {
                    Id = 234,
                    ProductName = "Argos Home Lavendon Single End Open Ottoman Bed Frame - Grey",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =200,
                    Qty = 145,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Argos Home Lavendon Single End Open Ottoman Bed Frame - Grey")
                },
                  new Product
                {
                    Id = 235,
                    ProductName = "Argos Home Kristopher Single Fabric Bed Frame - Cream",
                    DepartmentId = 19,
                    Discount = 0,
                    IsAvailable = true,
                    Price =150,
                    Qty = 145,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Beds","Argos Home Kristopher Single Fabric Bed Frame - Cream")
                },
            #endregion
                #region "Home and furniture -> Table Lamps"
                  new Product
                {
                    Id = 236,
                    ProductName = "Argos Home Duno Touch Table Lamp - Brass & Black",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =15,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Argos Home Duno Touch Table Lamp - Brass & Black")
                },
                  new Product
                {
                    Id = 237,
                    ProductName = "Argos Home Ceramic Table Lamp - Cream",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =6,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Argos Home Ceramic Table Lamp - Cream")
                },
                  new Product
                {
                    Id = 238,
                    ProductName = "Habitat Caliban Globe Glass Table Lamp - Blue",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =20,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Habitat Caliban Globe Glass Table Lamp - Blue")
                },
                  new Product
                {
                    Id = 239,
                    ProductName = "Argos Home Silby Soft Touch LED Desk Lamp - White",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =16,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Argos Home Silby Soft Touch LED Desk Lamp - White")
                },
                  new Product
                {
                    Id = 240,
                    ProductName = "Habitat Bobble 61cm Ceramic Table Lamp - Cream",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =65,
                    Qty = 45,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Habitat Bobble 61cm Ceramic Table Lamp - Cream")
                },
                  new Product
                {
                    Id = 241,
                    ProductName = "Habitat Bobbin Mango Wood Table Lamp Base Only - Blue",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =26,
                    Qty = 145,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Habitat Bobbin Mango Wood Table Lamp Base Only - Blue")
                },
                  new Product
                {
                    Id = 242,
                    ProductName = "Habitat Maya Pair of Touch Table Lamps - Grey",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =25,
                    Qty = 145,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Habitat Maya Pair of Touch Table Lamps - Grey")
                },
                  new Product
                {
                    Id = 243,
                    ProductName = "Argos Home Twist 42cm Metal Table Lamp - Cream",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =20,
                    Qty = 145,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Argos Home Twist 42cm Metal Table Lamp - Cream")
                },
                  new Product
                {
                    Id = 244,
                    ProductName = "Habitat Mopsa LED Desk Lamp - Black",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =18,
                    Qty = 145,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Habitat Mopsa LED Desk Lamp - Black")
                },
                  new Product
                {
                    Id = 245,
                    ProductName = "Argos Home Global Fretwork Table Lamp",
                    DepartmentId = 20,
                    Discount = 0,
                    IsAvailable = true,
                    Price =28,
                    Qty = 125,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Table Lamps","Argos Home Global Fretwork Table Lamp")
                },
            #endregion
                #region "Home and furniture -> Home fragrance"
                  new Product
                {
                    Id = 246,
                    ProductName = "Habitat 100ml Room Spray - Sea Minerals & Sage",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price =5,
                    Qty = 125,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat 100ml Room Spray - Sea Minerals & Sage")
                },
                  new Product
                {
                    Id = 247,
                    ProductName = "Habitat Frosted Glass Electric Diffuser Gift Set",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price =35,
                    Qty = 125,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat Frosted Glass Electric Diffuser Gift Set")
                },
                  new Product
                {
                    Id = 248,
                    ProductName = "Habitat 90ml Reed Diffuser - Patchouli and Amber",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price =9,
                    Qty = 101,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat 90ml Reed Diffuser - Patchouli and Amber")
                },
                  new Product
                {
                    Id = 249,
                    ProductName = "Habitat XXL Luxe White Confetti Candle - Geranium & Pear",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price =25,
                    Qty = 111,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat XXL Luxe White Confetti Candle - Geranium & Pear")
                },
                  new Product
                {
                    Id = 250,
                    ProductName = "Habitat Scented Reed Diffuser - Jasmine and Pineapple Flower",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 9,
                    Qty = 111,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat Scented Reed Diffuser - Jasmine and Pineapple Flower")
                },
                  new Product
                {
                    Id = 251,
                    ProductName = "Habitat Pink Confetti Glass XL Candle - Jasmine & Amber",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 15,
                    Qty = 111,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat Pink Confetti Glass XL Candle - Jasmine & Amber")
                },
                  new Product
                {
                    Id = 252,
                    ProductName = "Habitat 500ml Scented Diffuser - Jasmine & Pineapple Flower",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 20,
                    Qty = 111,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat 500ml Scented Diffuser - Jasmine & Pineapple Flower")
                },
                  new Product
                {
                    Id = 253,
                    ProductName = "Habitat Confetti Glass Reed Diffuser - Pink Jasmine & Amber",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 11,
                    Qty = 111,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat Confetti Glass Reed Diffuser - Pink Jasmine & Amber")
                },
                  new Product
                {
                    Id = 254,
                    ProductName = "Salter Aroma Diffuser",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 26,
                    Qty = 111,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Salter Aroma Diffuser")
                },
                  new Product
                {
                    Id = 255,
                    ProductName = "Habitat XL Checkered Candle - Amber and Sandalwood",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 2,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat XL Checkered Candle - Amber and Sandalwood")
                },
                  new Product
                {
                    Id = 256,
                    ProductName = "Habitat 500ml Scented Reed Diffuser - Neroli and Tonka",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 20,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat 500ml Scented Reed Diffuser - Neroli and Tonka")
                },
                  new Product
                {
                    Id = 257,
                    ProductName = "Habitat 500ml Scented Diffuser - Pomegranate & Baies",
                    DepartmentId = 21,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 20,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Home fragrance","Habitat 500ml Scented Diffuser - Pomegranate & Baies")
                },
            #endregion
                  
            #region "Home and furniture -> Kitchen Storage"
                 new Product
                {
                    Id = 258,
                    ProductName = "Argos Home Bee Floral Cotton Textile Set - Cream",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 12.5f,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home Bee Floral Cotton Textile Set - Cream")
                },
                 new Product
                {
                    Id = 259,
                    ProductName = "Argos Home Bee Floral Wipe Clean Table Cloth - Cream",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 16.5f,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home Bee Floral Wipe Clean Table Cloth - Cream")
                },
                 new Product
                {
                    Id = 260,
                    ProductName = "Argos Home Floral 2 Piece Fine China Tankard",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 8,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home Floral 2 Piece Fine China Tankard")
                },
                 new Product
                {
                    Id = 261,
                    ProductName = "Argos Home Floral Set of 4 Palace Assort Mugs - Cream",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 17,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home Floral Set of 4 Palace Assort Mugs - Cream")
                },
                 new Product
                {
                    Id = 262,
                    ProductName = "Argos Home Floral Set of 4 Mugs - Cream",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 12,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home Floral Set of 4 Mugs - Cream")
                },
                 new Product
                {
                    Id = 263,
                    ProductName = "Argos Home Bee Floral 12 Piece Stoneware Dinner Set",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 35,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home Bee Floral 12 Piece Stoneware Dinner Set")
                },
                 new Product
                {
                    Id = 264,
                    ProductName = "Argos Home Bee Floral Pack of 2 Cake Tin",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 14,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home Bee Floral Pack of 2 Cake Tin")
                },
                 new Product
                {
                    Id = 265,
                    ProductName = "Argos Home 4 Piece Stoneware Pasta Bowls - Cream",
                    DepartmentId = 22,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 14,
                    Qty = 121,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Storage","Argos Home 4 Piece Stoneware Pasta Bowls - Cream")
                },
            #endregion
            #region "Home and furniture -> Kitchen Bins"
                 new Product
                {
                    Id = 266,
                    ProductName = "Moda 42 Litre Touch Top Bin - Grey",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 20,
                    Qty = 125,
                    RateReview = 3.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Moda 42 Litre Touch Top Bin - Grey")
                },
                 new Product
                {
                    Id = 267,
                    ProductName = "Moda 50 Litre Wide Pedal Bin - Black",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 32,
                    Qty = 125,
                    RateReview = 3.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Moda 50 Litre Wide Pedal Bin - Black")
                },
                 new Product
                {
                    Id = 268,
                    ProductName = "Moda 40 Litre Slim Pedal Bin - Silver",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 30,
                    Qty = 125,
                    RateReview = 3.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Moda 40 Litre Slim Pedal Bin - Silver")
                },
                 new Product
                {
                    Id = 269,
                    ProductName = "Moda 42 Litre Touch Top Bin - Ivory",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 20,
                    Qty = 125,
                    RateReview = 3.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Moda 42 Litre Touch Top Bin - Ivory")
                },
                 new Product
                {
                    Id = 270,
                    ProductName = "Curver Verto 54 Litre Touch Top Kitchen Bin – Blue",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 35,
                    Qty = 125,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Curver Verto 54 Litre Touch Top Kitchen Bin – Blue")
                },
                 new Product
                {
                    Id = 271,
                    ProductName = "Argos Home 70 Litre Recycling Bin - Black",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 50,
                    Qty = 155,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Argos Home 70 Litre Recycling Bin - Black")
                },
                 new Product
                {
                    Id = 272,
                    ProductName = "Argos Home 45 Litre Bullet Bin - Silver",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 14,
                    Qty = 155,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Argos Home 45 Litre Bullet Bin - Silver")
                },
                 new Product
                {
                    Id = 273,
                    ProductName = "Habitat 60 Litre Twin Compartment Pedal Bin - Black",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 70,
                    Qty = 155,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Habitat 60 Litre Twin Compartment Pedal Bin - Black")
                },
                 new Product
                {
                    Id = 274,
                    ProductName = "Habitat 12 Litre Waste Paper Bin - Black",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 7,
                    Qty = 157,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Habitat 12 Litre Waste Paper Bin - Black")
                },
                 new Product
                {
                    Id = 275,
                    ProductName = "Curver 40 Litre Deco Touch Top Kitchen Bin - Silver",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 33,
                    Qty = 157,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Curver 40 Litre Deco Touch Top Kitchen Bin - Silver")
                },
                 new Product
                {
                    Id = 276,
                    ProductName = "Curver 50 Litre Deco Pedal Bin - Black",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 48.5f,
                    Qty = 101,
                    RateReview = 4.5f,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Curver 50 Litre Deco Pedal Bin - Black")
                },
                 new Product
                {
                    Id = 277,
                    ProductName = "Habitat 30 Litre Domed Pedal bin - Black",
                    DepartmentId = 23,
                    Discount = 0,
                    IsAvailable = true,
                    Price = 30,
                    Qty = 70,
                    RateReview = 5,
                    Description = DescriptionSeeder.DescriptionReader("Home and furniture","Kitchen Bins","Habitat 30 Litre Domed Pedal bin - Black")
                },
            #endregion
        };
    }
}
