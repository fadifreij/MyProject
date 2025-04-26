using ECommerce.ServiceAbstraction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Presentation.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [HttpGet("GetProductsByDepartment/{DepartmentId}")]
        public async Task<IActionResult> GetProductsByDepartment(int DepartmentId, CancellationToken cancellationToken = default)
        {
            return Ok(await _productRepository.GetProductsByDepartment(DepartmentId,cancellationToken));
        }


        [HttpGet("GetProductsBySection/{SectionId}")]
        public async Task<IActionResult> GetProductsBySection(int SectionId, CancellationToken cancellationToken = default)
        {
            return Ok(await _productRepository.GetProductsBySection(SectionId,cancellationToken));
        }
    }
}
