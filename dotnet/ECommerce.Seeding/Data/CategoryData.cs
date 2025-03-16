using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Data
{
    internal static class CategoryData
    {
        static public Category[] categories =  {
        new Category { Id = 1, CategoryName = "Food" },
        new Category { Id = 2, CategoryName = "Electronics" },
        new Category { Id = 3, CategoryName = "Toys" },
        new Category { Id = 4, CategoryName = "Home and furniture" }
       };

    }
}
