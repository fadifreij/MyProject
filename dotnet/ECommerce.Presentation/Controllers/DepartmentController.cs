using E_Commerce.Domain.Entities;
using ECommerce.Domain.Entities;
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
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }
       
        [HttpGet("{CategoryId:int}")]
        public async Task<IActionResult> GetDepartmentsByCategoryId(int CategoryId, CancellationToken cancellationToken = default)
        {
            return Ok(await _departmentRepository.GetDepartmentsByCategoryId(CategoryId));
        }
    }
}
