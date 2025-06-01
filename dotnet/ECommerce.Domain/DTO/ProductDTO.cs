using E_Commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public float Price { get; set; }
        public float Discount { get; set; } = 0;

        public bool IsAvailable { get; set; }
        public float RateReview { get; set; }
        public int Qty { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public string? Description { get; set; }

        public List<ProductImageDTO>? ProductImages { get; set; }

        public List<SectionDTO>? Sections { get; set; }


    }
}
