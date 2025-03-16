using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;

namespace E_Commerce.Domain.Entities
{
    [Table("departments")]
    public class Department : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        [Required]
        public string DepartmentName { get; set; } = string.Empty;


        public Category? Category { get; set; }
       
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
    }
}
