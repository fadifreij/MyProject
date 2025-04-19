using E_Commerce.Domain.Entities;
using ECommerce.ServiceAbstraction.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ServiceAbstraction
{
   
        public interface IDepartmentRepository : IGenericRepository<Department>
        {
           public  Task<IEnumerable<Department>> GetDepartmentsByCategoryId(int CategoryId, CancellationToken cancellation);
        }
    
}
