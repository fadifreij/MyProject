using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    [Table("section_product")]
    public class SectionProduct
    {
        public int SectionId { get; set; }
        public Section? Section { get; set; } 


        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
