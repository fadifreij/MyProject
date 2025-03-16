using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Data
{
    internal static class SectionData
    {
        static public Section[] sections =
        {

                     new Section { Id = 1, SectionName = "Home-Carousal" },
                     new Section { Id = 2, SectionName = "Home-Featured-Products" , DisplayName="Featured Products"},
                     new Section { Id = 3, SectionName = "Home-Latest-Products" , DisplayName = "Latest Products" },
                     new Section { Id = 4, SectionName = "Home-Top-Rated-Products", DisplayName = "Top Rated Products" },
                     new Section { Id = 5, SectionName = "Home-Review-Products", DisplayName = "Review Products" },
                     new Section { Id = 6, SectionName = "Home-From-The-Blog", DisplayName = "From The Blog" },

                     new Section { Id = 7, SectionName = "Shop-Carousal-Sale-Off", DisplayName = "Sale Off" }
         };
    }
}
