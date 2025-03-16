using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    [Table("sections")]
    public class Section : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        [Required]
        public string SectionName { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        
        public string? DisplayName { get; set; } = string.Empty;
    }
}
