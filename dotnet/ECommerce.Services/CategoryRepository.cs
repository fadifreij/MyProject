using E_Commerce.Domain.DTO;
using ECommerce.Domain.Entities;
using ECommerce.Persistence;
using ECommerce.ServiceAbstraction;
using ECommerce.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class CategoryRepository : GenericRepository<Category>,  ICategoryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext): base(applicationDbContext) 
        {
            this.applicationDbContext = applicationDbContext;
        }


        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync(CancellationToken cancellationToken)
        {
            var entities = await GetAllAsync(cancellationToken);
            var dtos = entities.Select(c => new CategoryDTO
            {
                Id = c.Id,
                CategoryName = c.CategoryName
            });
            return dtos.ToList();

        }
    }
}
