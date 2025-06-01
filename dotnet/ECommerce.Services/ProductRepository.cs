using E_Commerce.Domain.DTO;
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
        public async Task<IEnumerable<ProductDTO>> GetProductsByDepartmentAsync(int departmentId, CancellationToken cancellationToken)
        {
          var products = await _context.Set<Product>()
                .Where(p => p.DepartmentId == departmentId)
                .Include(p=>p.ProductImages)
                .ToListAsync(cancellationToken);

            var dtos = products.Select(p => new ProductDTO
            {
                Id = p.Id,
                ProductName = p.ProductName,
                Price = p.Price,
                Discount = p.Discount,
                IsAvailable = p.IsAvailable,
                RateReview = p.RateReview,
                Qty = p.Qty,
                DepartmentId = p.DepartmentId,
                DepartmentName = p.Department?.DepartmentName ?? "",
                Description = p.Description,
                ProductImages = p.ProductImages?.Select(img => new ProductImageDTO
                {
                    Id = img.Id,
                    ProductImage = img.ProductImage
                }).ToList(),

                Sections = p.SectionProducts?.Select(sp => new SectionDTO
                {
                    SectionId = sp.Section.Id,
                    SectionName = sp.Section.SectionName
                }).ToList() 
            });
            return dtos.ToList();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryBySectionAsync(int categoryId, int sectionId, CancellationToken cancellationToken)
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
