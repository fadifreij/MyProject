using E_Commerce.Domain.DTO;
using E_Commerce.Domain.Entities;
using ECommerce.Persistence;
using ECommerce.ServiceAbstraction;
using ECommerce.Services.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetDepartmentsByCategoryIdAsync(int CategoryId ,CancellationToken cancellationToken = default)
        {
            return  await _context.Set<Department>().Where(x=>x.CategoryId == CategoryId).ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<DepartmentDTO>> GetAllDepartmentsAsync(CancellationToken cancellationToken = default)
        {
            var departments = await GetAllAsync(cancellationToken);
            var departmentDtos = departments.Select(d => new DepartmentDTO
            {
                Id = d.Id,
                DepartmentName = d.DepartmentName,
                CategoryId = d.CategoryId
            }).OrderBy(x=>x.DepartmentName);
            return departmentDtos.ToList();
        }
    }


   
}
