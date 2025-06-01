using E_Commerce.Domain.DTO;
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
        Task<IEnumerable<ProductDTO>> GetProductsByDepartmentAsync(int departmentId, CancellationToken cancellation);

        Task<IEnumerable<Product>> GetProductsByCategoryBySectionAsync(int categoryId, int sectionId, CancellationToken cancellation);
    }
}
