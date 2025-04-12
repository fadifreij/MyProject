using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UnitTest.Entities
{
    public class CategoryModelTest
    {
        [Fact]
        public void Category_WithValidData_ShouldPassValidation()
        {
            var category = new Category
            {
                CategoryName = "Electronics"
            };

            var results = ValidateModel(category);

            Assert.Empty(results);
        }

        [Fact]
        public void Category_WithoutCategoryName_ShouldFailValidation()
        {
            var category = new Category
            {
                CategoryName = "" // Required should fail
            };

            var results = ValidateModel(category);

            Assert.Contains(results, r => r.MemberNames.Contains(nameof(Category.CategoryName)));
        }

        [Fact]
        public void Category_WithTooLongCategoryName_ShouldFailValidation()
        {
            var category = new Category
            {
                CategoryName = new string('A', 251) // Exceeds 250 chars
            };

            var results = ValidateModel(category);

            Assert.Contains(results, r => r.MemberNames.Contains(nameof(Category.CategoryName)));
        }

        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, validationContext, validationResults, true);
            return validationResults;
        }



    }
}
