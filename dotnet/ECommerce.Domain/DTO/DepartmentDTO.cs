using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.DTO
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
    }
}
