using E_Commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.ServiceAbstraction
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsByDepartment(int departmentId, CancellationToken cancellation);

        Task<IEnumerable<Product>> GetProductsBySection(int sectionId, CancellationToken cancellation);
    }
}
