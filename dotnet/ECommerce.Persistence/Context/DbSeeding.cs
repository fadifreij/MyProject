using E_Commerce.Domain.Entities;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;


namespace E_Commerce.DAL.Context
{
    public static class DbSeeding
    {

        public static void Seed( ModelBuilder modelBuilder)
        {
            //// Seeding Section Table
            //modelBuilder.Entity<Section>().HasData(
            //         new Section { Id = 1, SectionName = "Home-Carousal" },
            //         new Section { Id = 2, SectionName = "Home-Featured-Products" , DisplayName="Featured Products"},
            //         new Section { Id = 3, SectionName = "Home-Latest-Products" , DisplayName = "Latest Products" },
            //         new Section { Id = 4, SectionName = "Home-Top-Rated-Products", DisplayName = "Top Rated Products" },
            //         new Section { Id = 5, SectionName = "Home-Review-Products", DisplayName = "Review Products" },
            //         new Section { Id = 6, SectionName = "Home-From-The-Blog", DisplayName = "From The Blog" },

            //         new Section { Id = 7, SectionName = "Shop-Carousal-Sale-Off", DisplayName = "Sale Off" }

            //     );

            // Seeding Category Table
            modelBuilder.Entity<Category>().HasData(
                     new Category { Id = 1, CategoryName = "Food" },
                     new Category { Id = 2, CategoryName = "Electronics" },
                     new Category { Id = 3, CategoryName = "Toys" },
                     new Category { Id = 4, CategoryName = "Home and furniture" }
                 );

            // Seeding Department Table
            modelBuilder.Entity<Department>().HasData(
                     // Food Department
                     new Department { Id = 1, DepartmentName = "Meat", CategoryId = 1 },
                     new Department { Id = 2, DepartmentName = "Fish & Seafood", CategoryId = 1 },
                     new Department { Id = 3, DepartmentName = "Fruit & Vegtables", CategoryId = 1 },
                     new Department { Id = 4, DepartmentName = "Backery & Cakes", CategoryId = 1 },
                     new Department { Id = 5, DepartmentName = "Frozen", CategoryId = 1 },
                     new Department { Id = 6, DepartmentName = "Drinks", CategoryId = 1 },

                     // Electronics Department
                     new Department { Id = 7, DepartmentName = "Desktop Computers", CategoryId = 2 },
                     new Department { Id = 8, DepartmentName = "Laptops", CategoryId = 2 },
                     new Department { Id = 9, DepartmentName = "PC Monitors", CategoryId = 2 },
                     new Department { Id = 10, DepartmentName = "Computer Components", CategoryId = 2 },

                     // Toys
                     new Department { Id = 11, DepartmentName = "Art and creativity toys", CategoryId = 3 },
                     new Department { Id = 12, DepartmentName = "LEGO", CategoryId = 3 },
                     new Department { Id = 13, DepartmentName = "Construction Toys", CategoryId = 3 },
                     new Department { Id = 14, DepartmentName = "Toy vehicles and sets", CategoryId = 3 },
                     new Department { Id = 15, DepartmentName = "Jigsaws and Puzzles", CategoryId = 3 },
                     new Department { Id = 16, DepartmentName = "Literacy and Communication Toys", CategoryId = 3 },
                     new Department { Id = 17, DepartmentName = "Electronic Toys and Robots", CategoryId = 3 },

                     // Home and furniture
                     new Department { Id = 18, DepartmentName = "Wardrobes", CategoryId = 4 },
                     new Department { Id = 19, DepartmentName = "Sofas", CategoryId = 4 },
                     new Department { Id = 20, DepartmentName = "Beds", CategoryId = 4 },
                     new Department { Id = 21, DepartmentName = "Duvet Cover Sets", CategoryId = 4 },
                     new Department { Id = 22, DepartmentName = "Candles", CategoryId = 4 },
                     new Department { Id = 23, DepartmentName = "Table Lamps", CategoryId = 4 },
                     new Department { Id = 24, DepartmentName = "Gaming Chairs", CategoryId = 4 }

                 );


            Product[] productsList = new Product[]
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

            };
            
            // Product Table
            modelBuilder.Entity<Product>().HasData(
                 productsList
                );

            // we want to insert those record using https://www.hangfire.io/ or multi Threading 
            //int recordId = 1;
            //SeedProductImagesAfterConvertingToBinaryByDepartment(modelBuilder, "Food", "Meat", productsList, ref recordId);
            //SeedProductImagesAfterConvertingToBinaryByDepartment(modelBuilder, "Food", "Fish & Seafood", productsList, ref recordId);
            //SeedProductImagesAfterConvertingToBinaryByDepartment(modelBuilder, "Food", "Fruit & Vegtables", productsList, ref recordId);
            //SeedProductImagesAfterConvertingToBinaryByDepartment(modelBuilder, "Food", "Backery & Cakes", productsList, ref recordId);
            //SeedProductImagesAfterConvertingToBinaryByDepartment(modelBuilder, "Food", "Frozen", productsList, ref recordId);
            //SeedProductImagesAfterConvertingToBinaryByDepartment(modelBuilder, "Food", "Drinks", productsList, ref recordId);

        }


        private static void SeedProductImagesAfterConvertingToBinaryByDepartment(ModelBuilder modelBuilder, string categoryFolderName,string departmentFolderName, Product[] products, ref int recordId)
        {
            var baseDirectory = AppContext.BaseDirectory;
            var departmentFolderPath = Path.Combine(baseDirectory, "./../../ECommerce.DAL/", $"./Images/{categoryFolderName}/{departmentFolderName}");

            
            try
            {
                // Get all subfolders in the given folder
                string[] subfolders = Directory.GetDirectories(departmentFolderPath);
                
                
                // Iterate through each subfolder
                foreach (var subfolder in subfolders)
                {
                    // Get the folder name (last part of the path)
                    string folderName = Path.GetFileName(subfolder);


                    // Get all files in the current subfolder
                    string[] files = Directory.GetFiles(subfolder);

                    foreach (var file in files)
                    {
                        // Read the file as binary data
                        byte[] fileData = File.ReadAllBytes(file);
                        
                        // seed the data in table Product Images
                        modelBuilder.Entity<ProductImages>().HasData(
                            new ProductImages { 
                                Id = recordId,
                                ProductImage =  fileData,
                                ProductId = products.Where(p=>p.ProductName == folderName).First().Id
                               // ProductName = folderName,
                              
                                });

                        recordId++;
                    }
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when seeding ProducctImages for department {departmentFolderName}: {ex.Message}");
            }

        }
       
       



       
    }



   
}
