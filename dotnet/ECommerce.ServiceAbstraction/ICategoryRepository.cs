using ECommerce.Domain.Entities;
using ECommerce.ServiceAbstraction.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ServiceAbstraction
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
       
    }
   
}
