using E_Commerce.Domain.Entities;
using ECommerce.Persistence;
using ECommerce.ServiceAbstraction;
using ECommerce.Services.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace ECommerce.Services
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Product>> GetProductsByDepartment(int departmentId, CancellationToken cancellationToken)
        {
           return await _context.Set<Product>()
                .Where(p => p.DepartmentId == departmentId)
                .Include(p=>p.ProductImages)
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryBySection(int categoryId, int sectionId, CancellationToken cancellationToken)
        {
           
                
                var result = await _context.Set<SectionProduct>()
                                .Where(sp => sp.SectionId == sectionId)
                                .Include(sp => sp.Product)
                                .ThenInclude(p => p!.ProductImages)
                                .Include(sp => sp.Product)
                                .ThenInclude(d => d!.Department)
                                .Where(sp => sp.Product!.DepartmentId == categoryId)
                                .Select(sp => sp.Product)
                                .ToListAsync(cancellationToken);
                return result!;
            
            
            
            
        }
    }
}
