using E_Commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Data
{
    internal static class DepartmentData
    {
        static public Department[] departments =  {
       // Food Department
                     new Department { Id = 1, DepartmentName = "Meat", CategoryId = 1 },
                     new Department { Id = 2, DepartmentName = "Fish & Seafood", CategoryId = 1 },
                     new Department { Id = 3, DepartmentName = "Fruit & Vegtables", CategoryId = 1 },
                     new Department { Id = 4, DepartmentName = "Backery & Cakes", CategoryId = 1 },
                     new Department { Id = 5, DepartmentName = "Frozen", CategoryId = 1 },
                     new Department { Id = 6, DepartmentName = "Drinks", CategoryId = 1 },

                     // Electronics Department
                     new Department { Id = 7, DepartmentName = "Tablets & iPads", CategoryId = 2 },
                     new Department { Id = 8, DepartmentName = "Laptops & PCs", CategoryId = 2 },
                     new Department { Id = 9, DepartmentName = "Headphones & Audio", CategoryId = 2 },
                     new Department { Id = 10, DepartmentName = "Televisions", CategoryId = 2 },

                     // Toys
                     new Department { Id = 11, DepartmentName = "Art and creativity toys", CategoryId = 3 },
                     new Department { Id = 12, DepartmentName = "LEGO", CategoryId = 3 },
                     new Department { Id = 13, DepartmentName = "Construction Toys", CategoryId = 3 },
                     new Department { Id = 14, DepartmentName = "Interactive Learning Toys", CategoryId = 3 },
                     new Department { Id = 15, DepartmentName = "Wooden Toys", CategoryId = 3 },
                     new Department { Id = 16, DepartmentName = "Sensory Toys", CategoryId = 3 },
                     

                     // Home and furniture
                     new Department { Id = 17, DepartmentName = "Wardrobes", CategoryId = 4 },
                     new Department { Id = 18, DepartmentName = "Sofas", CategoryId = 4 },
                     new Department { Id = 19, DepartmentName = "Beds", CategoryId = 4 },
                     new Department { Id = 20, DepartmentName = "Table Lamps", CategoryId = 4 },
                     new Department { Id = 21, DepartmentName = "Home fragrance", CategoryId = 4 },
                     new Department { Id = 22, DepartmentName = "Kitchen Storage", CategoryId = 4 },
                     new Department { Id = 23, DepartmentName = "Kitchen Bins", CategoryId = 4 }
    };
    }
}
