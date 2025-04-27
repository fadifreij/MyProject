using E_Commerce.Domain.Entities;
using ECommerce.Domain.Entities;
using ECommerce.Presentation.Filters;
using ECommerce.ServiceAbstraction;
using ECommerce.ServiceAbstraction.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Presentation.Controllers
{
    [ApiController]
    [Route("api/Departments")]
    public class DepartmentController : BaseController
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }
       
        [HttpGet("Category/{CategoryId:int}/GetDepartments")]
        [ValidatePositiveInt("CategoryId")]
        public async Task<IActionResult> GetDepartmentsByCategoryId(int CategoryId, CancellationToken cancellationToken = default)
        {
            
            return await HandleRequestAsync(() => _departmentRepository.GetDepartmentsByCategoryId(CategoryId,cancellationToken));
        }
    }
}
