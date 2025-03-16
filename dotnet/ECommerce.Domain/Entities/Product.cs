using ECommerce.Domain.Common;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities
{
    [Table("products")]
    public class Product : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        public float Price { get; set; }
        public float Discount { get; set; } = 0;
        
        public bool IsAvailable { get; set; }
        public float RateReview { get; set; }
        public int Qty { get; set; }

        public Department? Department { get; } 
        public int DepartmentId { get; set; }

        public string? Description { get; set; }

        public ICollection<ProductImages>? ProductImages { get; }    
   
    }
    [Table("product_images")]
    public class ProductImages: BaseEntity
    {
        public byte[] ProductImage { get; set; } = new byte[0];
        
        public int ProductId { get; set; }
        public Product? Product { get; set; } 

    }



}
