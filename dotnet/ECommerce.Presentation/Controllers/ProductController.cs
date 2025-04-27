using ECommerce.Presentation.Filters;
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
        [ValidatePositiveInt("CategoryId")]
        public async Task<IActionResult> GetProductsByDepartment(int DepartmentId, CancellationToken cancellationToken = default)
        {
            return Ok(await _productRepository.GetProductsByDepartment(DepartmentId,cancellationToken));
        }

        // ~/api/ The ~ means “start from the root of the application
        [HttpGet("~/api/Category/{CategoryId}/Section/{SectionId}/GetProducts")]
        public async Task<IActionResult> GetProductsBySectionint (int SectionId, int CategoryId, CancellationToken cancellationToken = default)
        {
            return Ok(await _productRepository.GetProductsByCategoryBySection(CategoryId,SectionId,cancellationToken));
        }
       
    }
}
