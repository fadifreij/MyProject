using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;
using ECommerce.Presentation.Filters;
using ECommerce.ServiceAbstraction;
using ECommerce.ServiceAbstraction.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace ECommerce.Presentation.Controllers
{
    [ApiController]
    [Route("api/Categories")]
    public class CategoryController : BaseController
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken = default)
        {
           return await HandleRequestAsync(() => _categoryRepository.GetAllAsync(cancellationToken));

        }


        [HttpGet("{CategoryId:int}")]
        [ValidatePositiveInt("CategoryId")]
        public async Task<IActionResult> GetCategoryById(int CategoryId, CancellationToken cancellationToken = default)
        {
            return await HandleRequestAsync(() => _categoryRepository.GetByIdAsync(CategoryId, cancellationToken));
        }

    }
}
