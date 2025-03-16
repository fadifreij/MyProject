using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    public class SectionProduct
    {
        public int SectionId { get; set; }
        public Section Section { get; } = new Section();


        public int ProductId { get; set; }
        public Product Product { get; } = new Product();
    }
}
