using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;
using ECommerce.ServiceAbstraction.Common;
using Microsoft.AspNetCore.Mvc;
namespace ECommerce.Presentation.Controllers
{
    [ApiController]
    [Route("api/Categories")]
    public class CategoryController : ControllerBase
    {
        private readonly IGenericRepository<Category> _categoryRepository;

        public CategoryController(IGenericRepository<Category> categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken = default)
        {

            return Ok(await _categoryRepository.GetAllAsync());
        }
       
    }
}
